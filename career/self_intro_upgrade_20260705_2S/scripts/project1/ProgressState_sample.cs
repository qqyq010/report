// Sanitized portfolio sample. Original project-specific paths, assets, and non-essential code were removed.
using System;
using UnityEngine;

[Serializable]
public sealed class Project1ProgressStateSample
{
    [SerializeField] private bool _puzzle1Cleared;
    [SerializeField] private bool _puzzle2Cleared;
    [SerializeField] private bool _treasureCleared;
    [SerializeField] private bool _phase2Unlocked;
    [SerializeField] private bool _exitUnlocked;

    public bool Puzzle1Cleared => _puzzle1Cleared;
    public bool Puzzle2Cleared => _puzzle2Cleared;
    public bool TreasureCleared => _treasureCleared;
    public bool Phase2Unlocked => _phase2Unlocked;
    public bool ExitUnlocked => _exitUnlocked;

    public void MarkPuzzleCleared(Project1PuzzleType puzzleType)
    {
        switch (puzzleType)
        {
            case Project1PuzzleType.Puzzle1:
                _puzzle1Cleared = true;
                break;
            case Project1PuzzleType.Puzzle2:
                _puzzle2Cleared = true;
                break;
            case Project1PuzzleType.Treasure:
                _treasureCleared = true;
                break;
        }
    }

    public bool IsPuzzleCleared(Project1PuzzleType puzzleType)
    {
        switch (puzzleType)
        {
            case Project1PuzzleType.Puzzle1:
                return _puzzle1Cleared;
            case Project1PuzzleType.Puzzle2:
                return _puzzle2Cleared;
            case Project1PuzzleType.Treasure:
                return _treasureCleared;
            default:
                return false;
        }
    }

    public void UnlockPhase2AndExit()
    {
        _phase2Unlocked = true;
        _exitUnlocked = true;
    }
}
