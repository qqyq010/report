# EscapeRoom

개인 프로젝트로 진행한 단일 씬 기반 잠입/퍼즐 탈출 게임입니다.

## One Line

적의 시야를 피하고 퍼즐을 해결한 뒤 탈출하는 흐름을 단일 씬 안에서 구현했습니다.

## Public Code

| File | Role |
| --- | --- |
| `code/Core/GameManager.cs` | 게임 상태와 진행도 접근점 관리 |
| `code/Core/ProgressState.cs` | 퍼즐 클리어, Phase2, Exit unlock 상태 관리 |
| `code/Core/FailureHandler.cs` | 실패 처리, 입력 잠금, 복귀 루틴 |
| `code/Core/CheckpointManager.cs` | 체크포인트 저장과 플레이어 복귀 |
| `code/Enemy/EnemyVision.cs` | 적 시야 감지와 line-of-sight 판정 |
| `code/Enemy/DetectionController.cs` | 감지 누적과 실패 처리 연결 |
| `code/World/CheckpointTrigger.cs` | 체크포인트 트리거 |
| `code/Player/PlayerDetectionTarget.cs` | 감지 대상 transform 해석 |
| `code/Puzzle/TreasureGridManager.cs` | Treasure 퍼즐 진행과 실패 처리 |
| `code/Puzzle/TreasureEnemy.cs` | Treasure 퍼즐 내 적 이동/충돌 처리 |

## Interview Focus

- `GameManager`와 `ProgressState`를 나눈 이유
- 감지 판정과 실패 처리를 분리한 이유
- 실패 후 체크포인트 복귀에서 입력과 카메라 상태가 꼬이지 않게 한 방식
- 퍼즐 진행 상태와 플레이어 행동 상태를 같은 변수로 처리하지 않은 이유

## Verification Caveat

이 저장소에는 핵심 코드만 공개합니다. Unity scene, prefab, Inspector binding,
최종 빌드 파일은 포함하지 않았습니다.
