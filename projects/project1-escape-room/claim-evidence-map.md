# Project 1 - Claim Evidence Map

## 목적

EscapeRoom에서 자소서/면접에 사용할 수 있는 claim 후보를 공개 코드와 문서 근거에 연결한다.

## Claim Evidence Map

| claim 후보 | 근거 코드 | 근거 문서 | 관련 기능 | 직접 구현 여부 | AI/Codex 보조 여부 | 과장 위험 | 안전한 표현 | 금지 표현 | 추가 검증 필요 여부 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| 게임 흐름 상태와 퍼즐 진행도를 분리해 관리했다 | `GameManager.cs`, `ProgressState.cs` | `portfolio/01-escape-room/evidence-source-map.md`, `source-file-map.md` | GameState, ProgressState, puzzle clear, Phase2, Exit unlock | 직접 구현 후보 | 직접 코드에는 흔적 없음. AI/Codex 분석 대조 대상 가능 | 중간 | 단일 씬에서 이동/상호작용/감지 가능 상태와 퍼즐 진행도를 분리했다고 설명 가능 | 전체 시스템을 완성도 높게 설계했다 | enum 정의, scene 연결, Play Mode |
| 적 감지를 거리, 각도, Raycast line-of-sight로 나눠 판정했다 | `EnemyVision.cs`, `DetectionController.cs`, `PlayerDetectionTarget.cs` | `portfolio/01-escape-room/evidence-source-map.md` | Enemy detection, view angle, distance, Raycast | 직접 구현 후보 | AI/Codex 분석 대조 대상 가능 | 중간 | 잠입 요소에서 거리/각도/Raycast를 순서대로 확인하는 감지 구조를 구현했다고 설명 가능 | 상용 수준 스텔스 AI를 구현했다 | layer mask, view origin, 적 종류 범위 |
| 감지 성공을 실패 처리와 체크포인트 복귀 흐름으로 연결했다 | `DetectionController.cs`, `FailureHandler.cs`, `CheckpointManager.cs`, `CheckpointTrigger.cs` | `evidence-source-map.md`, `source-file-map.md` | detection report, failure guard, restore checkpoint | 직접 구현 후보 | AI/Codex 분석 대조 대상 가능 | 중간 | 감지 결과를 실패 처리로 넘기고, 중복 실패 방지와 체크포인트 복귀를 분리했다고 설명 가능 | 모든 실패/QA 흐름을 완성했다 | `InputLockController`, scene trigger, Play Mode |
| Treasure 퍼즐의 grid/path/reset/phase unlock 흐름을 코드로 관리했다 | `TreasureGridManager.cs`, `TreasureEnemy.cs`, `ProgressState.cs` | `evidence-source-map.md`, `source-file-map.md` | Treasure puzzle, path, reset, phase unlock | 직접 구현 후보 | AI/Codex 분석 대조 대상 가능 | 중간 | Treasure 퍼즐에서 노드/경로/리셋/성공 후 phase unlock 흐름을 코드로 관리했다고 설명 가능 | 모든 퍼즐을 완벽하게 구현했다 | `TreasureNode`, `TreasurePlayerMovement`, `TreasureTrigger`, scene 연결 |
| 퍼즐 내부 적이 플레이어의 이전 노드를 따라가며 실패 조건을 만든다 | `TreasureEnemy.cs`, `TreasureGridManager.cs` | `source-file-map.md` | clone enemy, delayed tracking, reset | 직접 구현 후보 | 직접 코드에는 흔적 없음 | 낮음~중간 | Treasure 퍼즐 내부에서 추적 적과 충돌 실패 조건을 분리했다고 설명 가능 | 모든 AI 로직을 직접 구현했다 | 실제 플레이 영상, node 연결 |
| AI/Codex 제안을 최종 코드와 대조해 남은 구조와 빠진 구조를 구분했다 | `ai-codex-evidence.md`, 공개 코드 전체 | `portfolio/01-escape-room/ai-codex-evidence.md` | AI-assisted review, documentation | 구현 claim 아님. 작업 방식 후보 | AI/Codex 보조로 분리 | 낮음 | AI/Codex는 분석/검토/문서화 보조였고, 최종 코드와 대조했다고 설명 가능 | AI/Codex 없이 전부 직접 작성했다 / AI가 전부 구현했다 | 원본 Codex report 위치 |

## 바로 사용 가능 후보

- 개인 프로젝트에서 감지, 실패, 체크포인트, 퍼즐 진행을 역할별 코드로 분리한 경험.
- EnemyVision의 거리/각도/Raycast 감지 구조.
- FailureHandler와 CheckpointManager 기반 실패 처리/복귀 흐름.
- Treasure 퍼즐의 grid/path/reset/phase unlock 구조.

## 근거 보강 후 사용 가능 후보

- 실제 시연 기반 문제 해결 사례.
- HideZone, PuzzleSafeZone, Player 이동.
- scene/prefab/Inspector 연결.
- Play Mode 또는 빌드 검증.

## AI/Codex 보조로 분리할 항목

- 감지, 실패, 체크포인트, 퍼즐 진행 문제를 SceneA 기준으로 분석한 흔적.
- 최종 코드에 남은 구조와 빠진 후보를 대조한 작업 방식.

## 과장 위험 / 금지 표현

- 상용 수준 스텔스 AI.
- 모든 AI 로직 직접 구현.
- 모든 런타임 검증 완료.
- 모든 퍼즐 완벽 구현.
- AI/Codex 없이 전부 직접 작성.
