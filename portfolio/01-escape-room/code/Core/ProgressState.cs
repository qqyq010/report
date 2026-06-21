using UnityEngine;

// 직렬화 가능한 진행 데이터 컨테이너.
// GameManager가 이 클래스의 인스턴스를 하나 들고 있으며, 다른 시스템에 값을 노출한다.
[System.Serializable]
public class ProgressState
{
    // 주요 진행 플래그들.
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

    // enum 타입에 따라 해당 퍼즐 완료 상태를 기록한다.
    public void MarkPuzzleCleared(PuzzleType puzzleType)
    {
        switch (puzzleType)
        {
            case PuzzleType.Puzzle1:
                _puzzle1Cleared = true;
                break;

            case PuzzleType.Puzzle2:
                _puzzle2Cleared = true;
                break;

            case PuzzleType.Treasure:
                _treasureCleared = true;
                break;
        }
    }

    // 다른 시스템이 내부 필드명을 직접 알지 않아도 진행 상태를 조회할 수 있게 해준다.
    public bool IsPuzzleCleared(PuzzleType puzzleType)
    {
        switch (puzzleType)
        {
            case PuzzleType.Puzzle1:
                return _puzzle1Cleared;

            case PuzzleType.Puzzle2:
                return _puzzle2Cleared;

            case PuzzleType.Treasure:
                return _treasureCleared;
        }

        return false;
    }

    public void SetPhase2Unlocked(bool value)
    {
        _phase2Unlocked = value;
    }

    public void SetExitUnlocked(bool value)
    {
        _exitUnlocked = value;
    }

    // Treasure 완료 시 엔드게임 흐름이 열리는 경우를 위한 편의 헬퍼.
    public void UnlockPhase2AndExit()
    {
        _phase2Unlocked = true;
        _exitUnlocked = true;
    }
}
