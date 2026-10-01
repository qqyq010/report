# EscapeRoom

적의 시야를 피하고 퍼즐을 풀어 탈출하는 개인 프로젝트입니다. Unity와 C#을 사용해 게임 상태, 적 감지, 퍼즐 진행과 실패 후 복귀 흐름을 구성했습니다.

## 주요 기능과 코드

| 기능 | 코드 |
|---|---|
| 게임 상태와 행동 가능 여부 관리 | [GameManager](code/Core/GameManager.cs) |
| 퍼즐 진행도와 탈출 조건 관리 | [ProgressState](code/Core/ProgressState.cs) |
| 거리·시야각·벽 가림에 따른 적 감지 | [EnemyVision](code/Enemy/EnemyVision.cs) |
| 감지 결과를 실패 처리로 전달 | [DetectionController](code/Enemy/DetectionController.cs) |
| 실패 처리 중복 방지와 복구 | [FailureHandler](code/Core/FailureHandler.cs) |
| 복귀 위치 저장과 적용 | [CheckpointManager](code/Core/CheckpointManager.cs) · [CheckpointTrigger](code/World/CheckpointTrigger.cs) |
| 적이 확인할 플레이어 위치 | [PlayerDetectionTarget](code/Player/PlayerDetectionTarget.cs) |
| Treasure 퍼즐의 진행과 실패 조건 | [TreasureGridManager](code/Puzzle/TreasureGridManager.cs) · [TreasureEnemy](code/Puzzle/TreasureEnemy.cs) |

## 작업에서 살펴본 점

적에게 발각된 뒤 실패 처리가 여러 번 겹치지 않도록 하고, 복귀 위치와 입력 상태를 함께 다뤘습니다. 퍼즐 진행 상태와 플레이어의 행동 상태를 나눠 각 기능의 역할을 정리했습니다.

개발 과정에서는 AI 도구를 활용했습니다. 제안된 구조와 최종 코드에 남은 구조를 대조한 내용은 [작업 과정](ai-codex-evidence.md)에 정리했습니다.

[코드별 설명](evidence-source-map.md) · [기능별 코드 발췌](../../career/self_intro_upgrade_20260705_2S/scripts/project1/README.md)
