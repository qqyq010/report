using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

// Treasure 퍼즐의 메인 그리드 조정자.
// 노드를 등록하고, 길 시각 요소를 만들며, 연결 상태를 갱신하고, 퍼즐을 리셋한다.
public class TreasureGridManager : MonoBehaviour
{
    public static TreasureGridManager Instance { get; private set; }

    [Header("Nodes")]
    // 이 퍼즐 레이아웃에 속하는 모든 Treasure 노드.
    [FormerlySerializedAs("_nodes")]
    [SerializeField] private TreasureNode[] _treasureNodes;

    [Header("Path")]
    // 노드 사이 연결을 시각적으로 그릴 prefab.
    [SerializeField] private GameObject _pathPrefab;
    // 길 시각 요소 배치와 논리 그리드 이동 계산에 함께 사용하는 월드 간격.
    [SerializeField] private float _gridSize = 3f;

    [Header("Actors")]
    // player / enemy 참조가 없어도 그리드 자체는 초기화될 수 있지만
    // 이동과 reset 기능은 연결되기 전까지 정상 동작하지 않는다.
    [FormerlySerializedAs("_player")]
    [SerializeField] private TreasurePlayerMovement _treasurePlayer;
    [FormerlySerializedAs("_enemy")]
    [SerializeField] private TreasureEnemy _treasureEnemy;
    // 기존 shared start node 참조를 남겨 두면 오래된 scene/prefab과도 호환이 쉽다.
    // 현재 reset은 각 actor가 runtime에 캡처한 시작 노드를 우선 사용한다.
    [FormerlySerializedAs("_startNode")]
    [SerializeField] private TreasureNode _authoredStartNode;

    [Header("Result")]
    [SerializeField] private bool _returnToNormalOnGoal = true;

    [Header("Audio")]
    [SerializeField] private AudioSource _puzzleAudioSource;
    [SerializeField] private AudioClip _successClip;
    [SerializeField] private AudioClip _failureClip;
    [SerializeField, Range(0f, 1f)] private float _successVolume = 1f;
    [SerializeField, Range(0f, 1f)] private float _failureVolume = 1f;

    [Header("Trigger Sounds")]
    [SerializeField] private AudioClip _triggerClip;
    [SerializeField, Range(0f, 1f)] private float _triggerVolume = 1f;
    [FormerlySerializedAs("_triggerSoundTriggers")]
    [SerializeField] private List<TreasureTrigger> _triggerSoundSources = new();

    // 매 턴마다 배열 전체를 훑지 않고도 GridPos로 노드를 찾을 수 있게 해주는 빠른 lookup.
    private readonly Dictionary<Vector2Int, TreasureNode> _nodeLookup = new();
    // trigger 목록을 캐시해 두면 reset 때 scene 전체를 다시 찾지 않아도 된다.
    private TreasureTrigger[] _cachedTriggers;
    private bool _isSolved;

    public float GridSize => _gridSize;
    public bool IsSolved => _isSolved;
    public TreasureNode StartNode => _authoredStartNode;
    public TreasureNode AuthoredStartNode => _authoredStartNode;

    // 월드 / 그리드 간격을 GridPos 계산에 쓰는 정수 step으로 변환한다.
    private int GridStep => Mathf.Max(1, Mathf.RoundToInt(_gridSize));

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        ResolveAudioSource();
    }

    private void Start()
    {
        _isSolved = GameManager.Instance != null && GameManager.Instance.TreasureCleared;

        // 시작 순서는 중요하다:
        // 1) 노드 등록
        // 2) 시각 요소 생성
        // 3) trigger 캐시
        // 4) 초기 trigger 상태 적용
        // 5) 길 가시성 갱신
        RegisterTreasureNodes();
        CreatePathVisuals();
        CacheTriggers();
        ApplyInitialTriggerStates();
        UpdateAllPaths();
    }

    public TreasureNode GetNode(Vector2Int gridPosition)
    {
        _nodeLookup.TryGetValue(gridPosition, out TreasureNode treasureNode);
        return treasureNode;
    }

    public TreasureNode FindNearestNode(Vector3 worldPosition)
    {
        if (_treasureNodes == null || _treasureNodes.Length == 0)
            return null;

        TreasureNode nearestNode = null;
        float nearestDistanceSqr = float.MaxValue;

        foreach (TreasureNode treasureNode in _treasureNodes)
        {
            if (treasureNode == null)
                continue;

            Vector3 offset = treasureNode.transform.position - worldPosition;
            offset.y = 0f;
            float distanceSqr = offset.sqrMagnitude;

            if (distanceSqr >= nearestDistanceSqr)
                continue;

            nearestDistanceSqr = distanceSqr;
            nearestNode = treasureNode;
        }

        return nearestNode;
    }

    // 플레이어가 한 칸 이동을 마친 뒤 호출된다.
    public void OnPlayerMoved()
    {
        if (_isSolved)
            return;

        _treasureEnemy?.ProcessTurn();
    }

    public void HandlePlayerReachedNode(TreasureNode treasureNode)
    {
        if (_isSolved || treasureNode == null || treasureNode.Type != TreasureNode.NodeType.Goal)
            return;

        _isSolved = true;
        PlayPuzzleSound(_successClip, _successVolume);

        if (GameManager.Instance != null)
        {
            GameManager.Instance.SetTreasureCleared();

            if (_returnToNormalOnGoal)
                GameManager.Instance.RestoreNormalState();
        }
    }

    // 기존 호출부와 UnityEvent 호환용.
    public void HandlePlayerEnteredNode(TreasureNode treasureNode)
    {
        HandlePlayerReachedNode(treasureNode);
    }

    public void UpdateAllPaths()
    {
        // trigger 변화나 전체 reset 이후 보이는 길 상태를 다시 계산한다.
        foreach (TreasureNode treasureNode in _treasureNodes)
        {
            if (treasureNode == null)
                continue;

            UpdateNodePathVisuals(treasureNode);
        }
    }

    public void ResetPuzzle()
    {
        if (_isSolved)
            return;

        PlayPuzzleSound(_failureClip, _failureVolume);

        // reset 순서는 시작 순서를 거의 그대로 따른다:
        // 1) 노드 논리 복원
        // 2) 작성된 trigger 기본값 재적용
        // 3) path 시각 요소 갱신
        // 4) actor를 시작 노드로 되돌리기
        foreach (TreasureNode treasureNode in _treasureNodes)
        {
            if (treasureNode == null)
                continue;

            treasureNode.ResetPaths();
        }

        ApplyInitialTriggerStates();
        UpdateAllPaths();

        // Treasure actors can have different authored start nodes, so reset each one
        // back to the node it captured at runtime instead of forcing a shared spawn.
        _treasurePlayer?.ResetPlayer();
        _treasureEnemy?.ResetEnemy();
    }

    public void ForceSolved(bool returnToNormalState = true)
    {
        _isSolved = true;

        if (GameManager.Instance != null)
        {
            if (!GameManager.Instance.TreasureCleared)
                GameManager.Instance.SetTreasureCleared();
            else if (!GameManager.Instance.Phase2Unlocked || !GameManager.Instance.ExitUnlocked)
                GameManager.Instance.UnlockPhase2AndExit();

            if (returnToNormalState)
                GameManager.Instance.RestoreNormalState();
        }
    }

    public void PlayTriggerSound(TreasureTrigger trigger)
    {
        if (trigger == null || _triggerClip == null || _triggerSoundSources == null || _triggerSoundSources.Count == 0)
            return;

        foreach (TreasureTrigger triggerSource in _triggerSoundSources)
        {
            if (triggerSource != trigger)
                continue;

            PlayPuzzleSound(_triggerClip, _triggerVolume);
            return;
        }
    }

    private void RegisterTreasureNodes()
    {
        _nodeLookup.Clear();

        foreach (TreasureNode treasureNode in _treasureNodes)
        {
            if (treasureNode == null)
                continue;

            // 같은 GridPos가 중복되면 첫 등록만 유지해서 dictionary 예외를 피한다.
            if (!_nodeLookup.ContainsKey(treasureNode.GridPos))
                _nodeLookup.Add(treasureNode.GridPos, treasureNode);
        }
    }

    private void CreatePathVisuals()
    {
        // path 시각 요소는 선택 사항이다.
        // prefab 연결이 없어도 퍼즐 논리 자체는 동작할 수 있다.
        if (_pathPrefab == null)
            return;

        int step = GridStep;
        float halfGridSize = _gridSize * 0.5f;

        foreach (TreasureNode treasureNode in _treasureNodes)
        {
            if (treasureNode == null)
                continue;

            // path 배치는 노드가 이 grid manager 아래 로컬 좌표 기준으로 배치되어 있다는 전제를 둔다.
            Vector3 localPosition = treasureNode.transform.localPosition;

            TreasureNode rightNode = GetNode(treasureNode.GridPos + new Vector2Int(step, 0));
            TreasureNode downNode = GetNode(treasureNode.GridPos + new Vector2Int(0, -step));

            // 같은 링크에 path 오브젝트가 중복 생성되지 않도록 한 방향에서만 만든다.
            if (rightNode != null)
            {
                GameObject rightPath = Instantiate(_pathPrefab, transform);
                rightPath.transform.localPosition = localPosition + new Vector3(halfGridSize, 0f, 0f);
                rightPath.transform.localRotation = Quaternion.identity;
                rightPath.transform.localScale = new Vector3(_gridSize, 0.1f, 0.5f);

                treasureNode.RegisterRightPath(rightPath);
            }

            if (downNode != null)
            {
                GameObject downPath = Instantiate(_pathPrefab, transform);
                downPath.transform.localPosition = localPosition + new Vector3(0f, 0f, -halfGridSize);
                downPath.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
                downPath.transform.localScale = new Vector3(_gridSize, 0.1f, 0.5f);

                treasureNode.RegisterDownPath(downPath);
            }
        }
    }

    private void UpdateNodePathVisuals(TreasureNode treasureNode)
    {
        int step = GridStep;

        TreasureNode rightNode = GetNode(treasureNode.GridPos + new Vector2Int(step, 0));
        TreasureNode downNode = GetNode(treasureNode.GridPos + new Vector2Int(0, -step));

        if (rightNode != null)
        {
            // 가로 연결은 양쪽 노드가 공통 링크를 모두 열었다고 동의할 때만 보인다.
            bool isOpen = treasureNode.Right && rightNode.Left;
            treasureNode.SetRightVisual(isOpen);
        }

        if (downNode != null)
        {
            // 세로 연결도 같은 규칙을 따른다.
            bool isOpen = treasureNode.Down && downNode.Up;
            treasureNode.SetDownVisual(isOpen);
        }
    }

    private void CacheTriggers()
    {
        // 에디터에서 비활성화된 자식 trigger도 reset 시 복구될 수 있도록 inactive child까지 포함한다.
        _cachedTriggers = GetComponentsInChildren<TreasureTrigger>(true);
    }

    private void ApplyInitialTriggerStates()
    {
        // 캐시가 없거나 오래되었으면 기본값 적용 전에 다시 만든다.
        if (_cachedTriggers == null || _cachedTriggers.Length == 0)
            CacheTriggers();

        if (_cachedTriggers == null)
            return;

        foreach (TreasureTrigger trigger in _cachedTriggers)
        {
            if (trigger == null)
                continue;

            trigger.CloseTargetPaths();
        }
    }

    private void ResolveAudioSource()
    {
        if (_puzzleAudioSource != null)
            return;

        _puzzleAudioSource = GetComponent<AudioSource>();
        if (_puzzleAudioSource != null)
            return;

        _puzzleAudioSource = gameObject.AddComponent<AudioSource>();
        _puzzleAudioSource.playOnAwake = false;
        _puzzleAudioSource.loop = false;
        _puzzleAudioSource.spatialBlend = 0f;
    }

    private void PlayPuzzleSound(AudioClip clip, float volume)
    {
        if (clip == null)
            return;

        ResolveAudioSource();
        _puzzleAudioSource.PlayOneShot(clip, Mathf.Clamp01(volume));
    }
}
