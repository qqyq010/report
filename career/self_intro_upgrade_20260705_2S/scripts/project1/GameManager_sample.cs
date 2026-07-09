// Sanitized portfolio sample. Original project-specific paths, assets, and non-essential code were removed.
using System;
using UnityEngine;

public enum Project1GameState
{
    Normal,
    PuzzleCursor,
    TreasurePuzzle,
    Locked
}

public enum Project1PuzzleType
{
    Puzzle1,
    Puzzle2,
    Treasure
}

public sealed class Project1GameManagerSample : MonoBehaviour
{
    [SerializeField] private Project1GameState _initialState = Project1GameState.Normal;
    [SerializeField] private Project1GameState _currentState = Project1GameState.Normal;
    [SerializeField] private Project1ProgressStateSample _progress = new Project1ProgressStateSample();

    public event Action<Project1GameState, Project1GameState> StateChanged;
    public event Action ProgressChanged;

    public Project1GameState CurrentState => _currentState;
    public Project1ProgressStateSample Progress => _progress;

    public bool CanUseWorldInteraction => _currentState == Project1GameState.Normal;
    public bool CanUseNormalMovement => _currentState == Project1GameState.Normal;
    public bool CanProcessDetection => _currentState == Project1GameState.Normal;
    public bool CanUsePlayerInteraction =>
        _currentState == Project1GameState.Normal ||
        _currentState == Project1GameState.PuzzleCursor;

    private void Awake()
    {
        _currentState = _initialState;
    }

    public void SetState(Project1GameState newState)
    {
        if (_currentState == newState)
            return;

        Project1GameState previousState = _currentState;
        _currentState = newState;
        StateChanged?.Invoke(previousState, _currentState);
    }

    public void RestoreNormalState()
    {
        SetState(Project1GameState.Normal);
    }

    public bool IsPuzzleCleared(Project1PuzzleType puzzleType)
    {
        return _progress.IsPuzzleCleared(puzzleType);
    }

    public void MarkPuzzleCleared(Project1PuzzleType puzzleType)
    {
        _progress.MarkPuzzleCleared(puzzleType);

        if (puzzleType == Project1PuzzleType.Treasure)
            _progress.UnlockPhase2AndExit();

        ProgressChanged?.Invoke();
    }
}
