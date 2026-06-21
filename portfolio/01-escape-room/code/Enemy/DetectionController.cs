using UnityEngine;

// 감지 상태를 총괄하는 중심 컨트롤러.
public class DetectionController : MonoBehaviour
{
    public static DetectionController Instance { get; private set; }

    [Header("Player Detection Target")]
    [SerializeField] private Transform _playerRoot;

    [Header("Failure Link")]
    [SerializeField] private FailureHandler _failureHandler;
    private bool _debugIgnoreDetection;

    public Transform PlayerRoot
    {
        get
        {
            TryGetPlayerRoot(out Transform playerRoot);
            return playerRoot;
        }
    }

    public bool DebugIgnoreDetection => _debugIgnoreDetection;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    private void OnDestroy()
    {
        if (Instance == this)
            Instance = null;
    }

    public bool IsPlayerCollider(Collider other)
    {
        if (other == null)
            return false;

        return TryGetPlayerRoot(out Transform playerRoot) && other.transform.root == playerRoot;
    }

    public bool TryGetPlayerRoot(out Transform playerRoot)
    {
        playerRoot = _playerRoot;
        return playerRoot != null;
    }

    public void ReportDetection(EnemyVision source)
    {
        // Debug cheat can ignore only enemy detection while leaving other
        // failure flows intact.
        if (_debugIgnoreDetection)
            return;

        if (_failureHandler != null)
        {
            _failureHandler.HandleFailure(
                FailureReason.Detection,
                source != null ? source.transform : null
            );
            return;
        }

        GameManager.Instance?.SetState(GameState.Locked);
    }

    public void SetDebugIgnoreDetection(bool ignoreDetection)
    {
        _debugIgnoreDetection = ignoreDetection;
    }
}
