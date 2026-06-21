using System.Collections;
using UnityEngine;

public class FailureHandler : MonoBehaviour
{
    [System.Serializable]
    private class FailureRecoveryProfile
    {
        // 이 프로필이 담당하는 실패 원인.
        [SerializeField] private FailureReason _reason = FailureReason.Detection;
        // 실패 처리 흐름이 끝난 뒤 복구할 GameState.
        [SerializeField] private GameState _restoreState = GameState.Normal;
        // 실패마다 별도 핸들러를 만들지 않아도 inspector에서 복구 방식을 바꿀 수 있게 해준다.
        [SerializeField] private FailureRecoveryType _recoveryType = FailureRecoveryType.RestoreCheckpoint;
        // 복귀 전에 짧은 여유를 둬서 VFX, SFX, 실패 피드백이 보일 시간을 만든다.
        [SerializeField] private float _delay = 0.5f;

        public FailureRecoveryProfile(FailureReason reason, GameState restoreState, FailureRecoveryType recoveryType, float delay)
        {
            _reason = reason;
            _restoreState = restoreState;
            _recoveryType = recoveryType;
            _delay = delay;
        }

        public FailureReason Reason => _reason;
        public GameState RestoreState => _restoreState;
        public FailureRecoveryType RecoveryType => _recoveryType;
        public float Delay => _delay;
    }

    public static FailureHandler Instance { get; private set; }

    [Header("References")]
    [SerializeField] private InputLockController _inputLockController;
    [SerializeField] private CheckpointManager _checkpointManager;

    [Header("Recovery Profiles")]
    [SerializeField] private FailureRecoveryProfile[] _recoveryProfiles;

    private bool _isHandlingFailure;


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        EnsureRecoveryProfiles();
    }

    private void OnValidate()
    {
        EnsureRecoveryProfiles();
    }

    public void HandleFailure(FailureReason reason, Transform source)
    {
        // 이 가드는 의도된 것이다.
        // 같은 실패가 연속으로 들어와 코루틴과 체크포인트 복구가 겹쳐 쌓이는 것을 막는다.
        if (_isHandlingFailure)
            return;

        StartCoroutine(HandleFailureRoutine(reason, source));
    }

    private IEnumerator HandleFailureRoutine(FailureReason reason, Transform source)
    {
        // 실패 원인별 동작을 하드코딩하지 않고 inspector 데이터에서 가져온다.
        FailureRecoveryProfile profile = GetRecoveryProfile(reason);

        int lockToken = -1;
        _isHandlingFailure = true;
        try
        {
            if (_inputLockController != null)
                lockToken = _inputLockController.LockInput(profile.RestoreState, reason.ToString());
            else
                GameManager.Instance?.SetState(GameState.Locked);


            if (profile.Delay > 0f)
                yield return new WaitForSeconds(profile.Delay);

            // 복구 처리와 입력 복구를 분리해 두면 나중에 한쪽만 독립적으로 확장하기 쉽다.
            ApplyRecovery(profile);
        }
        finally
        {
            if (_inputLockController != null)
                _inputLockController.UnlockInput(lockToken);
            else
                GameManager.Instance?.SetState(profile.RestoreState);

            _isHandlingFailure = false;
        }
    }

    private void EnsureRecoveryProfiles()
    {
        // inspector가 비어 있어도 전체 실패 흐름이 아무 일도 안 하는 상태가 되지 않도록 안전한 기본값을 채운다.
        if (_recoveryProfiles != null && _recoveryProfiles.Length > 0)
            return;

        // Detection은 체크포인트 복구, Puzzle 실패는 inspector에서 바꾸지 않으면 제어만 반환한다.
        _recoveryProfiles = new[]
        {
            new FailureRecoveryProfile(FailureReason.Detection, GameState.Normal, FailureRecoveryType.RestoreCheckpoint, 0.5f),
            new FailureRecoveryProfile(FailureReason.Puzzle, GameState.Normal, FailureRecoveryType.None, 0.2f),
            new FailureRecoveryProfile(FailureReason.Treasure, GameState.Normal, FailureRecoveryType.RestoreCheckpoint, 0.5f)
        };
    }

    private FailureRecoveryProfile GetRecoveryProfile(FailureReason reason)
    {
        // 목록이 작고 사람이 inspector에서 직접 관리하는 데이터라 선형 탐색으로 충분하다.
        for (int i = 0; i < _recoveryProfiles.Length; i++)
        {
            if (_recoveryProfiles[i] != null && _recoveryProfiles[i].Reason == reason)
                return _recoveryProfiles[i];
        }

        return new FailureRecoveryProfile(reason, GameState.Normal, FailureRecoveryType.RestoreCheckpoint, 0.5f);
    }

    private void ApplyRecovery(FailureRecoveryProfile profile)
    {
        // 지금은 switch 범위를 좁게 유지한다.
        // 나중에 복구 타입이 늘어나면 먼저 enum에 추가한 뒤 여기로 확장하는 편이 안전하다.
        switch (profile.RecoveryType)
        {
            case FailureRecoveryType.None:
                return;

            case FailureRecoveryType.RestoreCheckpoint:
                if (_checkpointManager != null)
                {
                    _checkpointManager.RestorePlayerToCheckpoint();
                    return;
                }


                return;
        }
    }
}
