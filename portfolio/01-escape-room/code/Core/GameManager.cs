using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [Header("State")]
    [SerializeField] private GameState _initialState = GameState.Normal;

    [SerializeField] private GameState _currentState = GameState.Normal;

    [Header("Progress")]
    [SerializeField] private ProgressState _progress = new ProgressState();

    public System.Action<GameState, GameState> OnStateChanged;
    public System.Action OnProgressChanged;

    public bool Puzzle1Cleared => _progress.Puzzle1Cleared;
    public bool Puzzle2Cleared => _progress.Puzzle2Cleared;
    public bool TreasureCleared => _progress.TreasureCleared;
    public bool Phase2Unlocked => _progress.Phase2Unlocked;
    public bool ExitUnlocked => _progress.ExitUnlocked;

    public GameState CurrentState => _currentState;
    public ProgressState Progress => _progress;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;

        // 씬이 바뀌어도 진행 상태와 현재 상태가 유지되도록 이 오브젝트를 살아 있게 둠
        DontDestroyOnLoad(gameObject);
        _currentState = _initialState;
    }

    public void SetState(GameState newState)
    {
        if (_currentState == newState)
            return;

        GameState previous = _currentState;
        _currentState = newState;
        OnStateChanged?.Invoke(previous, _currentState);
    }


    public bool CanUseWorldInteraction => _currentState == GameState.Normal;
    public bool CanUsePlayerInteraction => _currentState == GameState.Normal || _currentState == GameState.PuzzleCursor;
    public bool CanUseNormalMovement => _currentState == GameState.Normal;
    public bool CanRotateCamera => _currentState == GameState.Normal;
    public bool CanUsePuzzleInteraction => _currentState == GameState.PuzzleCursor;
    public bool CanUseTreasureMovement => _currentState == GameState.TreasurePuzzle;
    public bool CanProcessDetection => _currentState == GameState.Normal;

    public bool ShouldLockCursor => _currentState != GameState.PuzzleCursor;
    public bool ShouldUseMousePositionForInteraction => _currentState == GameState.PuzzleCursor;
    public bool ShouldRequireInteractionDistance => _currentState != GameState.PuzzleCursor;

    public void RestoreNormalState()
    {
        SetState(GameState.Normal);
    }

    public bool IsPuzzleCleared(PuzzleType puzzleType)
    {
        return _progress.IsPuzzleCleared(puzzleType);
    }

    public void MarkPuzzleCleared(PuzzleType puzzleType)
    {
        _progress.MarkPuzzleCleared(puzzleType);


        if (puzzleType == PuzzleType.Treasure)
            _progress.UnlockPhase2AndExit();

        NotifyProgressChanged();
    }

    public void SetPuzzle1Cleared()
    {
        MarkPuzzleCleared(PuzzleType.Puzzle1);
    }

    public void SetPuzzle2Cleared()
    {
        MarkPuzzleCleared(PuzzleType.Puzzle2);
    }

    public void SetTreasureCleared()
    {
        MarkPuzzleCleared(PuzzleType.Treasure);
    }

    public void SetPhase2Unlocked(bool value)
    {
        _progress.SetPhase2Unlocked(value);
        NotifyProgressChanged();
    }

    public void SetExitUnlocked(bool value)
    {
        _progress.SetExitUnlocked(value);
        NotifyProgressChanged();
    }

    public void UnlockPhase2AndExit()
    {
        _progress.UnlockPhase2AndExit();
        NotifyProgressChanged();
    }

    private void NotifyProgressChanged()
    {
        OnProgressChanged?.Invoke();
    }
}
