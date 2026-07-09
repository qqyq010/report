// Sanitized portfolio sample. Original project-specific paths, assets, and non-essential code were removed.
using UnityEngine;

public sealed class Project1CheckpointManagerSample : MonoBehaviour
{
    [SerializeField] private Transform _playerRoot;
    [SerializeField] private Transform _defaultCheckpoint;
    [SerializeField] private bool _applyCheckpointRotation = true;

    private Transform _currentCheckpoint;

    public Transform CurrentCheckpoint => _currentCheckpoint;

    private void Start()
    {
        _currentCheckpoint = _defaultCheckpoint;
    }

    public void SetCheckpoint(Transform checkpoint)
    {
        if (checkpoint == null)
            return;

        _currentCheckpoint = checkpoint;
    }

    public void RestorePlayerToCheckpoint()
    {
        Transform targetCheckpoint = _currentCheckpoint != null ? _currentCheckpoint : _defaultCheckpoint;
        if (_playerRoot == null || targetCheckpoint == null)
            return;

        Rigidbody playerBody = _playerRoot.GetComponent<Rigidbody>();
        if (playerBody != null)
        {
            playerBody.velocity = Vector3.zero;
            playerBody.angularVelocity = Vector3.zero;
            playerBody.position = targetCheckpoint.position;

            if (_applyCheckpointRotation)
                playerBody.rotation = targetCheckpoint.rotation;

            return;
        }

        _playerRoot.position = targetCheckpoint.position;
        if (_applyCheckpointRotation)
            _playerRoot.rotation = targetCheckpoint.rotation;
    }
}
