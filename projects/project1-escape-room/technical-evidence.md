# Project 1 - Technical Evidence

## 목적

기술문서, 포트폴리오, 면접 답변에 사용할 구현 근거를 정리한다.

## 현재 확정된 사실

- 기존 공개 C# 코드 근거가 `portfolio/01-escape-room/code/` 아래에 있다.
- 공개 코드는 핵심 구조 설명용이며 scene/prefab/Inspector binding과 실행 영상은 포함하지 않는다.

## 직접 구현 근거

| 주제 | 문제 상황 | 구현 또는 개선한 구조 | 관련 코드 | 검증 방식 | 한계 | 면접에서 설명 가능한 수준 | 추가 보강 필요 자료 |
| --- | --- | --- | --- | --- | --- | --- | --- |
| GameState / ProgressState | 한 씬에서 이동, 상호작용, 감지, 퍼즐 진행 상태가 섞일 위험 | 현재 행동 가능 상태는 `GameManager`, 퍼즐 진행도는 `ProgressState`로 분리 | `GameManager.cs`, `ProgressState.cs` | 코드 확인, 공개 문서 확인 | enum 정의와 scene 연결은 현재 repo에 없음 | 상태와 진행도를 분리한 이유 설명 가능 | enum 정의, Play Mode 영상 |
| EnemyVision 거리/각도/Raycast | 적 감지가 단순 거리만으로 처리되면 벽/방향을 반영하지 못함 | 거리, 시야각, Raycast line-of-sight 순서로 판정 | `EnemyVision.cs`, `DetectionController.cs`, `PlayerDetectionTarget.cs` | 코드 확인 | layer mask, scene 배치 검증 없음 | 잠입 감지 판정 순서 설명 가능 | 시연 영상, layer/obstacle 설정 |
| Detection / Failure 연결 | 감지 성공 후 실패 처리와 복구가 중복 실행될 위험 | `DetectionController`가 감지를 보고하고 `FailureHandler`가 중복 실패를 guard | `DetectionController.cs`, `FailureHandler.cs` | 코드 확인 | `InputLockController` 원본 없음 | 감지와 실패 처리 책임 분리 설명 가능 | 입력 잠금 코드, 실패 연출 |
| Checkpoint 복귀 | 실패 후 플레이어 위치/회전/물리 상태가 꼬일 위험 | checkpoint 저장과 player root 복구를 별도 manager/trigger로 분리 | `CheckpointManager.cs`, `CheckpointTrigger.cs` | 코드 확인 | 실제 trigger 배치와 player root 연결 확인 필요 | 실패 후 복귀 흐름 설명 가능 | scene/prefab 검증, Play Mode |
| Treasure Puzzle | 퍼즐 진행, path, reset, phase unlock이 섞일 위험 | grid manager가 node/path/reset/clear를 관리하고 enemy가 delayed tracking 실패 조건 제공 | `TreasureGridManager.cs`, `TreasureEnemy.cs`, `ProgressState.cs` | 코드 확인 | `TreasureNode`, `TreasurePlayerMovement`, `TreasureTrigger` 없음 | Treasure 퍼즐의 상태/reset/phase unlock 설명 가능 | 누락 타입, 시연 영상 |
| AI/Codex 경계 | AI 보조를 직접 구현 claim과 섞을 위험 | AI/Codex는 분석/검토/문서화 보조로 분리하고 최종 코드와 대조 | `ai-codex-evidence.md`, `evidence-source-map.md` | 문서 확인 | 원본 Codex report는 현재 repo에 없음 | AI 활용 범위를 과장 없이 설명 가능 | 원본 report 위치 |

## 확인 필요

- 각 기능의 실제 실행 검증 여부.
- 코드 공개 가능성 재검토.
- 프로젝트 기간, Unity 버전.
- scene/prefab/Inspector binding.
- Play Mode 또는 빌드 검증.

## 자소서 활용 가능 포인트

- 상태와 진행도 분리.
- 감지 판정 조건을 단계화한 잠입 요소.
- 실패 처리와 체크포인트 복귀 분리.
- Treasure 퍼즐 reset/phase unlock.

## 면접 예상 질문

- `GameManager`와 `ProgressState`를 왜 나눴는가?
- 감지는 거리, 각도, Raycast를 어떤 순서로 판정하는가?
- 감지 성공 후 실패 처리와 체크포인트 복귀는 어떻게 이어지는가?
- Treasure 퍼즐의 상태, reset, phase unlock은 어디서 관리하는가?
- AI/Codex는 어떤 보조 역할이었는가?

## 과장 위험 / 금지 표현

- 실행 검증을 하지 않은 기능은 검증 완료처럼 표현하지 않는다.
- 상용 수준 AI, 모든 퍼즐 완벽 구현, 모든 버그 해결이라고 표현하지 않는다.
