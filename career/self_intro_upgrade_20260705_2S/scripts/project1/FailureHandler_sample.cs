// Sanitized portfolio sample. Original project-specific paths, assets, and non-essential code were removed.
using System.Collections;
using UnityEngine;

public enum Project1FailureReason
{
    Detection,
    Puzzle,
    Treasure
}

public enum Project1RecoveryAction
{
    None,
    RestoreCheckpoint
}

public sealed class Project1FailureHandlerSample : MonoBehaviour
{
    [System.Serializable]
    private sealed class RecoveryProfile
    {
        [SerializeField] private Project1FailureReason _reason;
        [SerializeField] private Project1GameState _restoreState;
        [SerializeField] private Project1RecoveryAction _recoveryAction;
        [SerializeField] private float _delaySeconds;

        public RecoveryProfile(
            Project1FailureReason reason,
            Project1GameState restoreState,
            Project1RecoveryAction recoveryAction,
            float delaySeconds)
        {
            _reason = reason;
            _restoreState = restoreState;
            _recoveryAction = recoveryAction;
            _delaySeconds = delaySeconds;
        }

        public Project1FailureReason Reason => _reason;
        public Project1GameState RestoreState => _restoreState;
        public Project1RecoveryAction RecoveryAction => _recoveryAction;
        public float DelaySeconds => _delaySeconds;
    }

    [SerializeField] private Project1GameManagerSample _gameManager;
    [SerializeField] private Project1CheckpointManagerSample _checkpointManager;
    [SerializeField] private RecoveryProfile[] _profiles =
    {
        new RecoveryProfile(Project1FailureReason.Detection, Project1GameState.Normal, Project1RecoveryAction.RestoreCheckpoint, 0.5f),
        new RecoveryProfile(Project1FailureReason.Puzzle, Project1GameState.Normal, Project1RecoveryAction.None, 0.2f),
        new RecoveryProfile(Project1FailureReason.Treasure, Project1GameState.Normal, Project1RecoveryAction.RestoreCheckpoint, 0.5f)
    };

    private bool _isHandlingFailure;

    public bool IsHandlingFailure => _isHandlingFailure;

    public void HandleFailure(Project1FailureReason reason)
    {
        if (_isHandlingFailure)
            return;

        StartCoroutine(HandleFailureRoutine(reason));
    }

    private IEnumerator HandleFailureRoutine(Project1FailureReason reason)
    {
        RecoveryProfile profile = FindProfile(reason);

        _isHandlingFailure = true;
        try
        {
            if (profile.DelaySeconds > 0f)
                yield return new WaitForSeconds(profile.DelaySeconds);

            ApplyRecovery(profile);
        }
        finally
        {
            _isHandlingFailure = false;
        }
    }

    private RecoveryProfile FindProfile(Project1FailureReason reason)
    {
        for (int i = 0; i < _profiles.Length; i++)
        {
            RecoveryProfile profile = _profiles[i];
            if (profile != null && profile.Reason == reason)
                return profile;
        }

        return new RecoveryProfile(reason, Project1GameState.Normal, Project1RecoveryAction.RestoreCheckpoint, 0.5f);
    }

    private void ApplyRecovery(RecoveryProfile profile)
    {
        if (profile.RecoveryAction == Project1RecoveryAction.RestoreCheckpoint)
            _checkpointManager?.RestorePlayerToCheckpoint();

        _gameManager?.SetState(profile.RestoreState);
    }
}
