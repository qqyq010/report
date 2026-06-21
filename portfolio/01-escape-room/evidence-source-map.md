# EscapeRoom Evidence Source Map

이 문서는 개인 프로젝트 EscapeRoom STAR 사례에서 사용한 공개 가능한 코드 근거를 정리합니다.

## Claim

감지, 퍼즐 진행, 실패 처리, 체크포인트 복귀를 단일 흐름으로 뭉치지 않고 역할별 스크립트로 나누어 구현했습니다.

## Public Evidence

| Public File | Main Evidence | How To Explain |
| --- | --- | --- |
| `code/Core/GameManager.cs` | player/world/puzzle/detection 상태 접근자 | 현재 진행 상태에 따라 이동, 회전, 상호작용, 감지 처리를 허용할지 판단하는 중심 상태 관리자 |
| `code/Core/ProgressState.cs` | puzzle cleared, door unlocked, clear state | 퍼즐 진행도와 탈출 조건을 별도 상태로 관리 |
| `code/Enemy/EnemyVision.cs` | detection gate, distance/angle/raycast check | 감지 판정을 담당하고, 게임 상태가 감지를 허용할 때만 판정 |
| `code/Enemy/DetectionController.cs` | detection report to failure flow | 감지 이벤트를 실패 처리로 넘기는 연결부 |
| `code/Core/FailureHandler.cs` | duplicate failure guard, player restore, puzzle reset hook | 실패 처리 중복 실행을 막고 체크포인트 복귀와 상태 복구를 담당 |
| `code/Core/CheckpointManager.cs` | checkpoint save/restore | 플레이어 복귀 위치를 별도로 저장/복원 |
| `code/World/CheckpointTrigger.cs` | checkpoint trigger | 씬 안에서 체크포인트 갱신 진입점을 제공 |
| `code/Puzzle/TreasureGridManager.cs` | puzzle reset, phase unlock | 퍼즐 실패/성공에 따른 상태 갱신과 진행 흐름을 담당 |
| `code/Puzzle/TreasureEnemy.cs` | puzzle obstacle logic | 퍼즐 내부 실패 요인을 분리 |
| `code/Player/PlayerDetectionTarget.cs` | detection target abstraction | 적 감지 대상 위치를 플레이어 구현과 분리 |

## STAR Mapping

| STAR Part | Evidence |
| --- | --- |
| Situation | 감지, 퍼즐, 실패 복귀가 한 씬에서 동시에 동작해야 하는 개인 프로젝트 |
| Task | 상태 꼬임 없이 실패 후 복귀하고, 퍼즐 진행도를 유지/초기화할 기준 분리 |
| Action | 상태 접근자, 감지 컨트롤러, 실패 핸들러, 체크포인트 매니저로 책임 분리 |
| Result | 문제 발생 시 감지, 실패 처리, 위치 복구, 퍼즐 진행도 중 어느 단계인지 설명 가능 |

## Verification Boundary

- 공개 저장소에는 핵심 C# 코드만 포함되어 있습니다.
- Scene, prefab, Unity Play Mode 실행 영상은 이 저장소에 포함하지 않았습니다.
- 따라서 GitHub README에서는 "코드상 구조를 설명 가능"으로 표현하고, "모든 런타임 검증 완료"라고 쓰지 않습니다.
