using UnityEngine;

// 플레이어가 지나가면 현재 체크포인트를 갱신하는 트리거.
[RequireComponent(typeof(Collider))]
public class CheckpointTrigger : MonoBehaviour
{
    [Header("Checkpoint")]
    [SerializeField] private CheckpointManager _checkpointManager;
    [SerializeField] private Transform _checkpoint;

    [Header("Player Filter")]
    [HideInInspector, SerializeField] private string _playerTag = "Player";

    [Header("Option")]
    [SerializeField] private bool _triggerOnce = true;

    private bool _hasTriggered;

    private void Reset()
    {
        Collider col = GetComponent<Collider>();
        col.isTrigger = true;

        if (_checkpoint == null)
            _checkpoint = transform;
    }

    private void Awake()
    {
        if (_checkpoint == null)
            _checkpoint = transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (_triggerOnce && _hasTriggered)
            return;

        if (!IsPlayerCollider(other))
            return;

        if (_checkpointManager == null || _checkpoint == null)
        {

            return;
        }

        _checkpointManager.SetCheckpoint(_checkpoint);
        _hasTriggered = true;

    }

    private bool IsPlayerCollider(Collider other)
    {
        if (other == null)
            return false;

        if (DetectionController.Instance != null)
            return DetectionController.Instance.IsPlayerCollider(other);

        return other.CompareTag(_playerTag) || other.transform.root.CompareTag(_playerTag);
    }
}
