using UnityEngine;


public class EnemyVision : MonoBehaviour
{
    [Header("Vision")]
    // 이 적이 볼 수 있는 최대 거리.
    [SerializeField] private float _detectionRange = 10f;

    // 전체 시야각. 내부적으로는 이 값을 반으로 나눠 좌우 반각 기준으로 비교한다.
    [SerializeField, Range(1f, 180f)] private float _viewAngle = 60f;

    // ray 시작점으로 사용할 위치. 비어 있으면 적 자신의 transform을 사용한다.
    [SerializeField] private Transform _viewOrigin;

    // 벽과 플레이어를 모두 포함해야 가림 판정이 정상적으로 동작한다.
    [SerializeField] private LayerMask _visibilityMask = ~0;

    [Header("Option")]
    // 감지 성공 후 같은 프레임/짧은 구간에서 중복 호출되는 것을 막는다.
    [SerializeField] private float _redetectCooldown = 0.2f;

    [Header("Debug")]
    [HideInInspector, SerializeField] private bool _drawDebugRay = true;
    [HideInInspector, SerializeField] private bool _logBlockedChecks = false;
    [HideInInspector, SerializeField] private float _blockedLogCooldown = 1f;
    [HideInInspector, SerializeField] private Color _visibleRayColor = Color.red;
    [HideInInspector, SerializeField] private Color _blockedRayColor = Color.gray;

    private DetectionController _detectionController;
    private float _lastDetectTime = -999f;
    private float _nextBlockedLogTime = -999f;

    private void Reset()
    {
        if (_viewOrigin == null)
            _viewOrigin = transform;
    }

    private void Awake()
    {
        if (_viewOrigin == null)
            _viewOrigin = transform;
    }

    private void Start()
    {
        _detectionController = DetectionController.Instance;
    }

    private void Update()
    {
        if (!TryGetVisionTarget(out Transform playerRoot, out Transform visionTarget))
            return;

        Vector3 origin = _viewOrigin.position;
        Vector3 toPlayer = visionTarget.position - origin;

        float distance = toPlayer.magnitude;
        if (distance <= 0.001f || distance > _detectionRange)
            return;

        Vector3 direction = toPlayer / distance;
        float angle = Vector3.Angle(_viewOrigin.forward, direction);

        if (angle > _viewAngle * 0.5f)
            return;

        bool canSeePlayer = TryCheckLineOfSight(origin, direction, distance, playerRoot);

        if (canSeePlayer == false)
            return;

        if (Time.time < _lastDetectTime + _redetectCooldown)
            return;

        _lastDetectTime = Time.time;
        _detectionController.ReportDetection(this);
    }

    private bool TryGetVisionTarget(out Transform playerRoot, out Transform visionTarget)
    {
        playerRoot = null;
        visionTarget = null;

        // 퍼즐 상태나 복구 상태에서는 감지를 건너뛴다.
        if (GameManager.Instance != null && !GameManager.Instance.CanProcessDetection)
        {
            LogBlockedCheck("GameState prevents detection.");
            return false;
        }

        if (_detectionController == null)
            _detectionController = DetectionController.Instance;

        if (_detectionController == null)
        {
            LogBlockedCheck("DetectionController is missing.");
            return false;
        }

        if (!_detectionController.TryGetPlayerRoot(out playerRoot))
        {
            LogBlockedCheck("PlayerRoot is missing.");
            return false;
        }

        visionTarget = PlayerDetectionTarget.ResolveTransform(playerRoot);
        if (visionTarget == null)
            visionTarget = playerRoot;

        return true;
    }

    private bool TryCheckLineOfSight(Vector3 origin, Vector3 direction, float distance, Transform playerRoot)
    {
        bool hitSomething = Physics.Raycast(
            origin,
            direction,
            out RaycastHit hit,
            distance,
            _visibilityMask,
            QueryTriggerInteraction.Ignore
        );

        if (_drawDebugRay)
        {
            Color rayColor = _blockedRayColor;

            if (hitSomething && (hit.transform == playerRoot || hit.transform.IsChildOf(playerRoot)))
                rayColor = _visibleRayColor;

            Debug.DrawRay(origin, direction * distance, rayColor);
        }

        if (hitSomething == false)
        {
            LogBlockedCheck("Line of sight missed all colliders.");
            return false;
        }

        if (hit.transform != playerRoot && !hit.transform.IsChildOf(playerRoot))
        {
            LogBlockedCheck($"Line of sight blocked by {hit.transform.name}.");
            return false;
        }

        return true;
    }

    private void OnValidate()
    {
        if (_detectionRange < 0.1f)
            _detectionRange = 0.1f;

        _viewAngle = Mathf.Clamp(_viewAngle, 1f, 180f);

        if (_redetectCooldown < 0f)
            _redetectCooldown = 0f;

        if (_blockedLogCooldown < 0f)
            _blockedLogCooldown = 0f;
    }

    public Transform ViewOrigin => _viewOrigin;
    public float ViewDistance => _detectionRange;
    public float ViewAngle => _viewAngle;
    public LayerMask VisibilityMask => _visibilityMask;

    private void LogBlockedCheck(string message)
    {
        if (!_logBlockedChecks)
            return;

        if (Time.time < _nextBlockedLogTime)
            return;

        _nextBlockedLogTime = Time.time + _blockedLogCooldown;
        Debug.Log($"EnemyVision[{name}]: {message}", this);
    }
}
