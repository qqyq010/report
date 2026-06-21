using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

// Treasure 퍼즐에서 사용하는 추적 적.
// 플레이어가 지나간 이전 노드 기록을 지연 추적으로 따라간다.
public class TreasureEnemy : MonoBehaviour
{
    // 플레이어 참조와 노드 이동 이력을 추적 기준으로 사용한다.
    [FormerlySerializedAs("_player")]
    [SerializeField] private TreasurePlayerMovement _treasurePlayer;
    [FormerlySerializedAs("_currentNode")]
    [SerializeField] private TreasureNode _currentTreasureNode;
    [SerializeField] private Animator _animator;
    // 한 번의 추적 이동에 걸리는 시간.
    [FormerlySerializedAs("_moveDuration")]
    [SerializeField] private float _stepMoveDuration = 0.35f;

    // 적이 즉시 따라붙지 않도록 플레이어의 이전 노드를 저장한다.
    private readonly Queue<TreasureNode> _moveHistory = new();
    private int _turnCount;
    private bool _isMoving;
    private TreasureNode _initialTreasureNode;
    private Quaternion _initialRotation;

    private static readonly int IsMovingParam = Animator.StringToHash("IsMoving");

    private void Awake()
    {
        _initialRotation = transform.rotation;
        ResolveAnimator();
        DisableRootMotion();
    }

    private void Start()
    {
        InitializeCurrentNodeFromScenePlacement();
        _initialTreasureNode = _currentTreasureNode;
        SetMoving(false);
    }

    public void ProcessTurn()
    {
        // 이전 이동 보간이 끝나기 전에는 다음 요청을 무시한다.
        if (_isMoving || _treasurePlayer == null || _treasurePlayer.CurrentNode == null)
            return;

        _turnCount++;
        _moveHistory.Enqueue(_treasurePlayer.CurrentNode);

        // 첫 두 턴 동안은 적을 지연시킨다.
        if (_turnCount < 3)
            return;

        if (_moveHistory.Count <= 0)
            return;

        TreasureNode nextNode = _moveHistory.Dequeue();
        StartCoroutine(MoveToNodeRoutine(nextNode));
    }

    public void ResetEnemy(TreasureNode startNode = null)
    {
        TreasureNode targetNode = startNode != null ? startNode : _initialTreasureNode;
        if (targetNode == null)
            return;

        StopAllCoroutines();
        _moveHistory.Clear();
        _turnCount = 0;

        _currentTreasureNode = targetNode;
        transform.position = targetNode.transform.position;
        transform.rotation = _initialRotation;
        _isMoving = false;
        SetMoving(false);
    }

    private IEnumerator MoveToNodeRoutine(TreasureNode targetNode)
    {
        _isMoving = true;
        SetMoving(true);

        Vector3 startPosition = transform.position;
        Vector3 endPosition = targetNode.transform.position;
        Vector3 moveDirection = endPosition - startPosition;
        moveDirection.y = 0f;
        FaceDirection(moveDirection);

        float elapsed = 0f;
        while (elapsed < _stepMoveDuration)
        {
            elapsed += Time.deltaTime;
            transform.position = Vector3.Lerp(startPosition, endPosition, elapsed / _stepMoveDuration);
            yield return null;
        }

        transform.position = endPosition;
        _currentTreasureNode = targetNode;

        SetMoving(false);
        CheckPlayerCollision();
        _isMoving = false;
    }

    private void CheckPlayerCollision()
    {
        if (_treasurePlayer == null)
            return;

        TreasureGridManager treasureGrid = TreasureGridManager.Instance;
        if (treasureGrid != null && treasureGrid.IsSolved)
            return;

        // 플레이어와 적이 같은 논리 노드에 있으면 잡힌 것으로 본다.
        if (_currentTreasureNode == _treasurePlayer.CurrentNode)
            treasureGrid?.ResetPuzzle();
    }

    private void InitializeCurrentNodeFromScenePlacement()
    {
        TreasureGridManager treasureGrid = TreasureGridManager.Instance;
        if (_currentTreasureNode == null && treasureGrid != null)
            _currentTreasureNode = treasureGrid.AuthoredStartNode;

        if (_currentTreasureNode == null && _treasurePlayer != null)
            _currentTreasureNode = _treasurePlayer.CurrentNode;

        if (_currentTreasureNode == null && treasureGrid != null)
            _currentTreasureNode = treasureGrid.FindNearestNode(transform.position);

        if (_currentTreasureNode != null)
            transform.position = _currentTreasureNode.transform.position;
    }

    private void ResolveAnimator()
    {
        if (_animator == null)
            _animator = GetComponent<Animator>();
    }

    private void DisableRootMotion()
    {
        if (_animator != null)
            _animator.applyRootMotion = false;
    }

    private void SetMoving(bool isMoving)
    {
        if (_animator != null)
            _animator.SetBool(IsMovingParam, isMoving);
    }

    private void FaceDirection(Vector3 moveDirection)
    {
        if (moveDirection.sqrMagnitude <= 0.0001f)
            return;

        transform.rotation = Quaternion.LookRotation(moveDirection.normalized, Vector3.up);
    }
}
