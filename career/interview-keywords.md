# Interview Keywords

## 목적

면접에서 설명할 수 있는 키워드를 프로젝트 근거와 연결한다.
키워드는 아는 단어 목록이 아니라, 코드/문서/검증 근거로 설명 가능한 주제만
면접 카드로 승격한다.

## 현재 확정된 사실

- 후보 키워드는 직접 구현, 팀 결과물 / 협업 기여, 확인 필요, 과장 위험으로 분류한다.
- Project3 키워드는 완성 게임의 대표 성과가 아니라 검증, 문서화, 툴링 태도의 보조 근거로 다룬다.

## 직접 구현 근거

- Project1 후보: EscapeRoom, GameState, ProgressState, EnemyVision, Raycast, FailureHandler, Checkpoint, Treasure Puzzle.
- Project2 후보: Coin Laundry, Inventory, Shop, Unity UI, runtime state, merge responsibility, verification summary. EventBus/디버깅은 추가 확인 필요.
- Project3 후보: TODO: Fisher, CSH, 밸런스, CloudScript, UI 아트 파이프라인, 검증 문서.

## Project1 - EscapeRoom 키워드 후보

| 키워드 | 상태 | 근거 경로 | 사용 기준 |
| --- | --- | --- | --- |
| GameState / ProgressState | 사용 가능 후보 | `projects/project1-escape-room/claim-evidence-map.md`, `portfolio/01-escape-room/code/Core/GameManager.cs` | 상태와 진행도 분리 설명으로 사용 |
| EnemyVision | 사용 가능 후보 | `portfolio/01-escape-room/code/Enemy/EnemyVision.cs` | 거리/각도/Raycast 감지 구조로 제한 |
| Raycast line-of-sight | 사용 가능 후보 | `EnemyVision.cs`, `technical-evidence.md` | 장애물/시야 판정 개념 설명으로 사용 |
| FailureHandler | 사용 가능 후보 | `portfolio/01-escape-room/code/Core/FailureHandler.cs` | 실패 중복 방지와 복구 흐름 설명 |
| Checkpoint | 사용 가능 후보 | `CheckpointManager.cs`, `CheckpointTrigger.cs` | 실패 후 위치/회전 복구 흐름 설명 |
| Treasure Puzzle | 사용 가능 후보 | `TreasureGridManager.cs`, `TreasureEnemy.cs` | grid/path/reset/phase unlock 설명 |
| AI/Codex 활용 | 보조 후보 | `portfolio/01-escape-room/ai-codex-evidence.md` | 분석/검토/문서화 보조로만 사용 |
| HideZone / PuzzleSafeZone / Player 이동 | 확인 필요 | 현재 repo 코드 근거 없음 | 추가 자료 전 핵심 키워드로 사용하지 않음 |

## Project2 - Coin Laundry 키워드 후보

| 키워드 | 상태 | 근거 경로 | 사용 기준 |
| --- | --- | --- | --- |
| Unity UI | 사용 가능 후보 | `projects/project2-coin-laundry/code-evidence/InventoryUIController.preview-commit.excerpt.cs`, `technical-evidence.md` | held item, preview, placement confirm 설명으로 제한. 직접 구현 확정은 보류 |
| Inventory | 사용 가능 후보 | `portfolio/02-coin-laundry/evidence-source-map.md`, `projects/project2-coin-laundry/technical-evidence.md` | preview/commit, runtime receive 소재로 제한 |
| Shop | 사용 가능 후보 | `projects/project2-coin-laundry/code-evidence/ShopPurchaseService.purchase-refund.excerpt.cs`, `portfolio/_shared/sanitized-evidence-matrix.md` | 구매 실패 시 환불 경로 소재로 제한 |
| Merge | 사용 가능 후보 | `projects/project2-coin-laundry/code-evidence/InventoryMergeService.merge-responsibility.excerpt.cs` | `CanMerge` 판정과 `TryMergeItems` 실행 책임 분리로 제한 |
| EventBus | 확인 필요 | excerpt에 event publish 호출은 있으나 EventBus 본문은 미반영 | 추가 코드 자료 제공 전 핵심 키워드로 사용하지 않음 |
| 런타임 상태 관리 | 사용 가능 후보 | `projects/project2-coin-laundry/code-evidence/InventoryRuntimeService.receive-flow.excerpt.cs` | 구매 아이템 수령, fallback, event publish 흐름 설명으로 제한 |
| 디버깅 | 확인 필요 | 환불/배치 실패 시나리오가 코드 흐름 후보로 보강됨 | 실제 버그 수정 로그, 재현 절차 필요 |
| 검증 로그 | 사용 가능 후보 | `projects/project2-coin-laundry/evidence/verification-summary.md` | 코드 확인/문서 확인/Play Mode/빌드 확인 구분 소재로 사용 |
| 팀 협업 | 사용 가능 후보 | `portfolio/_shared/publication-policy.md`, `implemented-by-me.md` | 공개 범위와 담당 범위 분리 소재로 사용 |
| 포트폴리오 문서화 | 사용 가능 | `portfolio/02-coin-laundry/`, `projects/project2-coin-laundry/` | sanitized summary와 내부 claim 정리 연결로 사용 |

## 팀 결과물 / 협업 근거

- 팀 프로젝트 키워드는 팀 결과물과 개인 담당 범위를 함께 기록한다.
- 팀 공용 시스템, 서버 계약, 전체 QA, 전체 밸런스처럼 범위가 큰 키워드는 개인 단독 키워드로 쓰지 않는다.

## 확인 필요

- TODO: 면접에서 코드 수준으로 설명 가능한 키워드와 개념 수준 키워드 분리.
- TODO: 각 키워드별 근거 파일, 문서, 로그, 영상 링크.
- TODO: 실제 실행 검증 여부.
- TODO: 팀원 구현분과 본인 구현분의 경계.
- TODO: sanitized excerpt 공개 승인 여부.

## 자소서 활용 가능 포인트

- 담당 범위 내 구현은 자소서 핵심 소재 후보로 둔다.
- 검증 로그 기반 문제 추적과 코드/문서/테스트 근거 기반 개선은 기술문서와 면접 답변에 연결한다.
- Project3는 보조 근거로 두고 작업 방식과 검증 태도를 설명하는 데 사용한다.

## 면접 예상 질문

- TODO: 이 키워드가 실제 코드에서 어디에 나타나는가?
- TODO: 어떤 문제를 해결하기 위해 이 구조를 썼는가?
- TODO: 팀 결과물 중 본인이 설명할 수 있는 범위는 어디까지인가?
- TODO: 검증 로그나 테스트 근거가 있는가?

## 과장 위험 / 금지 표현

- 용어만 알고 실제 구현 근거가 없는 키워드는 핵심 역량으로 쓰지 않는다.
- 서버 전체 구현, 라이브 서비스 운영, QA 전체 담당, 밸런스 전체 확정은 근거가 생기기 전까지 금지한다.
- 설명 가능한 깊이가 부족한 키워드는 확인 필요로 남긴다.
