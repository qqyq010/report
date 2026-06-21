using UnityEngine;
using UnityEngine.Serialization;

// 실패나 강제 리셋 이후 플레이어를 저장된 체크포인트로 되돌린다.
public class CheckpointManager : MonoBehaviour
{
    [Header("Checkpoint")]
    // 복구 시 텔레포트할 플레이어 루트.
    [SerializeField] private Transform _playerRoot;

    // 기본 복구 위치로 사용할 체크포인트.
    [SerializeField] private Transform _defaultCheckpoint;

    // 플레이어가 체크포인트의 forward 방향을 바라보도록 회전까지 맞출지 여부.
    [SerializeField] private bool _applyCheckpointRotation = true;

    // 물리/trigger 상태가 즉시 따라오도록 transform 동기화를 강제로 수행한다.
    [FormerlySerializedAs("_syncTransformsAfterRestore")]
    [HideInInspector, SerializeField] private bool _syncPhysicsTransformsAfterRestore = true;

    private Transform _currentCheckpoint;

    public Transform CurrentCheckpoint => _currentCheckpoint;

    private void Start()
    {
        ResolvePlayerReference();
        _currentCheckpoint = _defaultCheckpoint;
    }

    // 외부 시스템이 게임 도중 새로운 체크포인트를 현재 기준점으로 승격시킬 수 있다.
    public void SetCheckpoint(Transform checkpoint)
    {
        if (checkpoint == null)
            return;

        _currentCheckpoint = checkpoint;
    }

    public void RestorePlayerToCheckpoint()
    {
        if (_currentCheckpoint == null)
            _currentCheckpoint = _defaultCheckpoint;

        if (_playerRoot == null)
            ResolvePlayerReference();

        if (_playerRoot == null || _currentCheckpoint == null)
            return;

        Rigidbody playerBody = _playerRoot.GetComponent<Rigidbody>();
        if (playerBody != null)
        {
            if (playerBody.isKinematic)
                playerBody.isKinematic = false;

            playerBody.useGravity = true;
            playerBody.linearVelocity = Vector3.zero;
            playerBody.angularVelocity = Vector3.zero;

            playerBody.position = _currentCheckpoint.position;
            if (_applyCheckpointRotation)
                playerBody.rotation = _currentCheckpoint.rotation;
        }
        else
        {
            _playerRoot.position = _currentCheckpoint.position;

            if (_applyCheckpointRotation)
                _playerRoot.rotation = _currentCheckpoint.rotation;
        }

        if (_syncPhysicsTransformsAfterRestore)
            Physics.SyncTransforms();
    }

    private void ResolvePlayerReference()
    {
        if (DetectionController.Instance != null && DetectionController.Instance.TryGetPlayerRoot(out Transform detectedPlayerRoot))
            _playerRoot = detectedPlayerRoot;
    }
}
