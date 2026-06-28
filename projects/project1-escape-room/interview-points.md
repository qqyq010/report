# Project 1 - Interview Points

## 목적

면접에서 Project 1을 설명할 때 사용할 질문과 답변 근거를 정리한다.

## 현재 확정된 사실

- 대표 설명 후보는 상태 관리, 적 감지, 실패/체크포인트, Treasure 퍼즐, AI/Codex 보조 범위다.

## 직접 구현 근거

- 답변마다 `source-file-map.md`, `claim-evidence-map.md`, `portfolio/01-escape-room/evidence-source-map.md`를 함께 확인한다.

## 확인 필요

- 난이도 조절, 실패 피드백, Play Mode 검증 여부.
- Player 이동, HideZone, PuzzleSafeZone, scene/prefab 연결.

## 면접 예상 질문

### 방어 가능한 질문

| 예상 질문 | 답변에 사용할 근거 | 설명 가능한 코드/문서 경로 | 답변 시 강조점 | 피해야 할 표현 | 추가 확인 필요 사항 |
| --- | --- | --- | --- | --- | --- |
| `GameManager`와 `ProgressState`를 왜 나눴는가? | 상태/진행도 분리 | `GameManager.cs`, `ProgressState.cs`, `claim-evidence-map.md` | 현재 행동 가능 상태와 퍼즐 진행도를 분리 | 전체 시스템을 완성도 높게 설계했다 | enum 정의, scene 연결 |
| 감지는 거리, 각도, Raycast를 어떤 순서로 판정하는가? | EnemyVision 감지 구조 | `EnemyVision.cs`, `DetectionController.cs` | distance, angle, line-of-sight 순서 | 상용 수준 스텔스 AI | layer mask, 장애물 배치 |
| 감지 성공 후 실패 처리와 체크포인트 복귀는 어떻게 이어지는가? | DetectionController, FailureHandler, CheckpointManager | `DetectionController.cs`, `FailureHandler.cs`, `CheckpointManager.cs` | 감지 보고, 중복 실패 guard, 복귀 책임 분리 | 모든 실패/QA 흐름을 완성했다 | `InputLockController`, Play Mode |
| Treasure 퍼즐의 상태, reset, phase unlock은 어디서 관리하는가? | TreasureGridManager, TreasureEnemy | `TreasureGridManager.cs`, `TreasureEnemy.cs`, `ProgressState.cs` | node/path/reset/phase unlock과 실패 조건 분리 | 모든 퍼즐을 완벽하게 구현했다 | 누락 타입과 scene 연결 |
| AI/Codex는 코드 작성이 아니라 어떤 보조 역할이었는가? | AI/Codex evidence | `portfolio/01-escape-room/ai-codex-evidence.md` | 분석/검토/문서화 보조와 최종 코드 대조 | AI 없이 전부 직접 작성했다 / AI가 전부 구현했다 | 원본 Codex report |

### 추가 확인 필요한 질문

| 예상 질문 | 현재 상태 | 추가 확인 필요 |
| --- | --- | --- |
| HideZone은 어떻게 구현했는가? | 현재 repo 코드 근거 없음 | 원본 코드 또는 영상 |
| PuzzleSafeZone은 어떻게 구현했는가? | 현재 repo 코드 근거 없음 | 원본 코드 또는 영상 |
| Player 이동은 직접 구현했는가? | 공개 코드에 Player 이동 파일 없음 | Player 이동 구현 파일 |
| 실제 Play Mode에서 검증했는가? | 현재 repo에는 실행 영상/로그 없음 | 영상, 빌드, 검증 로그 |

### 위험 질문

| 위험 질문 | 위험한 이유 | 안전한 대응 방향 |
| --- | --- | --- |
| 모든 적 AI를 직접 구현했나요? | `EnemyVision` 감지 구조 외 모든 AI 근거는 없음 | 공개 코드 기준 감지 판정 구조로 제한 |
| 전체 퍼즐 시스템이 완성됐나요? | Treasure 관련 지원 타입과 scene 연결이 없음 | 공개된 Treasure 흐름과 확인 필요 항목 분리 |
| AI/Codex 없이 전부 직접 작성했나요? | AI/Codex 보조 문서가 있음 | 보조 도구로 분석/검토했고 최종 코드를 대조했다고 설명 |

## 과장 위험 / 금지 표현

- 결과만 말하고 구현 과정을 설명하지 못하는 답변은 보류한다.
- repo에 없는 기능을 구현 완료처럼 답하지 않는다.
