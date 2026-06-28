# Unity/C# 부트캠프 프로젝트 기술문서

부제 후보: Inventory/Shop 구조화, 검증 워크플로우, 감지/실패 처리 구현 경험

## 1. 문서 목적

- 이 문서는 부트캠프 과정에서 진행한 프로젝트를 기술적으로 정리한 1차 초안이다.
- 이후 작성할 자소서와 PPT의 기준 문서로 사용한다.
- 목적은 성과를 과장하는 것이 아니라, 어떤 기능을 어떻게 다루었고 어떤 기준으로 문제를 분리했는지 설명하는 것이다.
- 프로젝트 경험은 `직접 구현`, `팀 결과물/협업 기여`, `확인 필요`, `과장 위험`으로 나누어 다룬다.
- 검증 수준은 `코드 확인`, `문서 확인`, `Play Mode 확인`, `빌드 확인`, `live proof`, `확인 필요`를 구분한다.

## 2. 전체 개발 서사

### 2.1 Coin Laundry에서 경험한 문제

Coin Laundry는 팀프로젝트1이며, 기술문서의 첫 번째 핵심 장으로 둔다. 이 프로젝트에서는 Inventory / Shop 기능을 중심으로 UI 입력, runtime state 반영, 구매 실패, refund, merge 책임 분리 문제를 다룬다.

Inventory / Shop 기능은 단순한 UI 화면 문제가 아니었다. 사용자가 아이템을 잡고 움직이는 preview 상태, 실제 inventory state에 반영되는 commit 상태, 구매 중 재화 차감과 아이템 수령, 실패 시 복구 경로가 연결되어 있었다. 이 장에서는 전체 인벤토리/상점 시스템 단독 구현이 아니라, 현재 repo의 sanitized summary와 파일 인덱스 기준으로 설명 가능한 구조만 다룬다.

### 2.2 Project3 Fisher에서 확장한 관점

Project3 Fisher는 팀프로젝트2이며, 완성 게임 포트폴리오가 아니라 검증/문서화/툴링/협업 경계 관리 보조 근거로 둔다. Coin Laundry에서 다룬 인벤토리/상점/데이터 계열 문제를 더 큰 협업 구조와 서버 경계에서 다룬 경험으로 연결한다.

이 장의 중심은 기능 완성 claim이 아니다. 코드 수정 전에 current-truth, verification queue, live proof, public evidence boundary를 분리하는 방식이다. PlayFab / CloudScript 문제는 Unity 요청, 서버 응답, live proof를 나누어 보아야 하며, Codex/AI는 코드 생성기가 아니라 검토, 문서화, 검증 큐 관리 도구로 제한한다.

### 2.3 EscapeRoom으로 보강되는 구현 근거

EscapeRoom은 개인 프로젝트이며, 팀프로젝트 서사에서 직접 구현 방어가 필요한 지점을 보강하는 코드 근거다. 현재 repo에는 공개 가능한 핵심 C# 코드 10개가 있으며, 상태 관리, 감지 판정, 실패 처리, 체크포인트, 퍼즐 진행을 코드 기준으로 설명할 수 있다.

단, scene/prefab/Inspector 연결, Play Mode, 빌드, 시연 영상은 현재 repo 기준 확인 필요다. HideZone, PuzzleSafeZone, Player 이동 구현도 현재 repo 기준 확인 필요로 둔다.

## 3. 팀프로젝트1: Coin Laundry

### 3.1 프로젝트에서 다룬 범위

- 팀프로젝트1.
- 현재 repo 기준 canonical name: `Coin Laundry`.
- 기술문서에서는 Inventory / Shop 중심 기능을 다룬다.
- 전체 시스템 단독 구현이 아니라 sanitized evidence 기준으로 설명 가능한 구조만 다룬다.
- 원본 팀 `.cs` 파일은 현재 repo에 포함되어 있지 않다.
- 현재 repo의 `projects/project2-coin-laundry/code-evidence/`에는 `README.md`만 확인되며, 개별 excerpt 파일은 추가 확인 필요다.

근거 경로:

- `projects/project2-coin-laundry/summary.md`
- `projects/project2-coin-laundry/technical-evidence.md`
- `projects/project2-coin-laundry/claim-evidence-map.md`
- `projects/project2-coin-laundry/source-file-map.md`
- `projects/project2-coin-laundry/interview-points.md`
- `projects/project2-coin-laundry/code-evidence/README.md`
- `portfolio/02-coin-laundry/core-file-index.md`
- `portfolio/02-coin-laundry/evidence-source-map.md`

### 3.2 문제: UI 입력과 실제 상태 변경이 섞이는 문제

인벤토리 UI에서는 사용자가 아이템을 잡고 움직이는 preview 상태와 실제 inventory state에 반영되는 commit 상태가 섞일 수 있다. 이 둘이 섞이면 배치 실패, 회전, 판매, merge 같은 기능에서 화면 표시와 실제 데이터가 어긋날 수 있다.

문제는 "아이템을 어디에 보여줄 것인가"와 "언제 실제 데이터로 확정할 것인가"가 같은 책임으로 다뤄질 때 생긴다. preview는 사용자 입력 중의 임시 판단이고, commit은 runtime inventory state를 변경하는 책임이다. 두 단계가 분리되지 않으면 실패 복구와 상태 일관성을 설명하기 어려워진다.

근거 후보:

- `projects/project2-coin-laundry/technical-evidence.md`
- `projects/project2-coin-laundry/claim-evidence-map.md`
- `projects/project2-coin-laundry/source-file-map.md`
- 문서상 관련 파일명: `InventoryUIController.cs`, `InventoryRuntimeService.cs`, `InventoryMergeService.cs`

확인 필요:

- 원본 코드.
- 작성자/커밋/담당 범위.
- 실제 Play Mode 검증 로그.
- preview renderer와 runtime inventory 호출 순서.

### 3.3 설계: preview와 commit 분리

preview 단계는 UI 입력과 시각적 판단을 담당한다. 사용자가 아이템을 잡고 움직이거나 회전하는 동안에는 실제 runtime inventory state를 즉시 변경하지 않는 구조가 필요하다.

commit 단계는 실제 상태 변경을 담당한다. 배치가 확정되거나 merge가 실행되는 시점에 runtime inventory service 또는 merge service로 책임을 넘기는 구조로 설명할 수 있다. 이 분리는 UI 반응성과 데이터 일관성을 구분하기 위한 판단이었다.

표현 제한:

- "직접 구현했다"로 확정하지 않는다.
- "담당 범위 후보에서 preview와 commit 분리 구조를 정리했고, 면접에서 설명 가능한 근거를 만들었다"로 표현한다.
- 팀 인벤토리 전체를 혼자 설계/구현했다고 쓰지 않는다.

### 3.4 문제: Shop 구매 실패 시 재화 복구

상점 구매는 단순히 골드를 차감하고 아이템을 주는 흐름이 아니다. 구매 흐름에는 재화 차감, 인벤토리 수령, 성공 이벤트, 실패 시 복구가 연결된다. 아이템 수령이 실패했는데 재화만 차감되면 플레이어 상태가 깨진다.

따라서 구매 흐름은 transaction-like flow로 정리해야 한다. spend 이후 receive가 실패할 수 있다는 전제를 두고, 실패 시 refund 경로를 별도로 둬야 한다.

근거 후보:

- `projects/project2-coin-laundry/technical-evidence.md`
- `projects/project2-coin-laundry/claim-evidence-map.md`
- `portfolio/_shared/sanitized-evidence-matrix.md`
- 문서상 관련 파일명: `ShopPurchaseService.cs`, `InventoryRuntimeService.cs`

확인 필요:

- 실패 케이스 재현 로그.
- 환불 경로의 실제 호출 순서.
- 재화 처리 코드와 inventory receive 코드의 ownership.
- Play Mode 검증 범위.

### 3.5 설계: spend -> receive -> refund 흐름

구매 흐름은 다음 순서로 설명한다.

1. 구매 요청이 들어온다.
2. 구매 조건과 재화를 확인한다.
3. 재화를 차감한다.
4. 아이템을 runtime inventory에 수령한다.
5. 수령 실패 시 refund 경로로 재화를 복구한다.
6. 성공/실패 결과를 분리해 UI 또는 event 흐름으로 전달한다.

이 흐름의 핵심은 실패가 발생할 수 있는 지점을 먼저 인정하는 것이다. 성공 경로만 보면 단순한 구매 기능처럼 보이지만, 실패 경로까지 보면 재화와 인벤토리 상태를 함께 지켜야 하는 문제다.

표현 제한:

- "상점 시스템 전체를 완성했다"로 쓰지 않는다.
- "담당 구매 흐름에서 spend, receive, refund 순서를 설명할 수 있다"로 낮춘다.
- 실제 실패 재현 로그가 없으면 검증 완료로 쓰지 않는다.

### 3.6 Merge 판정과 실행 책임 분리

merge는 UI에서 바로 처리하면 책임이 섞인다. UI는 사용자의 입력, preview, 요청 생성에 집중하고, service는 merge 가능 여부와 실제 상태 변경을 담당해야 한다.

`CanMerge`와 `TryMergeItems`처럼 판정과 실행을 나누는 구조가 필요하다. 판정은 두 아이템이 합쳐질 수 있는지 확인하고, 실행은 실제 inventory state 변경을 수행한다. 이 둘을 분리하면 UI preview가 merge service를 대체하지 않게 만들 수 있다.

근거 후보:

- `projects/project2-coin-laundry/technical-evidence.md`
- `projects/project2-coin-laundry/claim-evidence-map.md`
- 문서상 관련 파일명: `InventoryMergeService.cs`, `InventoryUIController.cs`

확인 필요:

- 원본 코드.
- 실제 `CanMerge` / `TryMergeItems` 호출 흐름.
- swap / restore / fallback merge 조건.
- 담당 범위와 팀원 구현분 경계.

### 3.7 검증과 한계

현재 Coin Laundry 장의 검증 수준은 주로 문서 확인이다. `core-file-index.md`, `evidence-source-map.md`, `technical-evidence.md`, `claim-evidence-map.md` 기준으로 면접에서 설명 가능한 구조는 정리되어 있다.

하지만 다음 항목은 아직 보강 필요다.

- 작성자/커밋/팀 change log.
- 팀 공개 승인 또는 면접 전용 사용 기준.
- Play Mode 원본 검증 로그.
- 실제 시연 영상.
- EventBus 또는 이벤트 연결 코드.
- 원본 코드 공개 가능 범위.

따라서 이 장에서는 "전체 인벤토리/상점 시스템 단독 구현"으로 표현하지 않는다. 안전한 표현은 "담당 범위 후보에서 Inventory / Shop 흐름을 구조적으로 설명할 수 있도록 정리했다"이다.

## 4. 팀프로젝트2: Project3 Fisher

### 4.1 프로젝트에서 다룬 범위

- 팀프로젝트2.
- canonical name: `Project3 Fisher`.
- 완성 게임 포트폴리오가 아니라 검증/문서화/툴링/협업 경계 관리 보조 근거다.
- 현재 repo에는 Project3 원본 팀 소스, PlayFab 설정, CloudScript 원본, 밸런스 workbook 원본, UI/아트 원본이 없다.
- 기술문서에서는 직접 구현 확정이 아니라 검증 기준과 책임 경계 분리 방식을 다룬다.

근거 경로:

- `projects/project3-fisher/summary.md`
- `projects/project3-fisher/role-and-scope.md`
- `projects/project3-fisher/technical-evidence.md`
- `projects/project3-fisher/claim-evidence-map.md`
- `projects/project3-fisher/source-file-map.md`
- `projects/project3-fisher/interview-points.md`
- `portfolio/03-project3-fisher/ai-assisted-workflow.md`
- `portfolio/03-project3-fisher/evidence-source-map.md`
- `portfolio/03-project3-fisher/tools-and-verification.md`

### 4.2 문제: 기능보다 먼저 검증 경계가 필요했던 상황

Project3에서는 Fisher/CSH, PlayFab, CloudScript, 밸런스, UI 리소스가 연결된다. 이런 구조에서는 코드만 수정하면 팀 최신본, live 업로드, 서버 요청/응답, 공개 가능 범위가 섞일 수 있다.

따라서 먼저 검증 경계를 나누어야 했다.

- 현재 기준이 무엇인지: current-truth.
- 무엇을 검증해야 하는지: verification queue.
- 로컬 코드 확인인지, Play Mode인지, live proof인지: verification label.
- public repo에 남길 수 있는지: public evidence boundary.

이 장의 핵심은 "기능을 완성했다"가 아니라, 기능을 다루기 전에 확인해야 할 경계를 분리했다는 점이다.

### 4.3 CloudScript / PlayFab 경계 분리

PlayFab 문제는 Unity 호출부, CloudScript handler, 서버 응답, live proof를 나눠 보아야 한다. UI에서 증상이 보인다고 해서 원인이 UI에만 있는 것은 아니며, 서버 응답이 정상이어도 live 반영이 확인되지 않으면 성공으로 볼 수 없다.

UseBox 같은 문제는 클라이언트 요청, CloudScript handler, FunctionResult, live proof를 분리해서 봐야 한다. live 업로드가 필요한 항목은 로컬 검증 후보와 구분해야 한다.

주의:

- 서버 전체 구현으로 쓰지 않는다.
- PlayFab 전체 설계로 쓰지 않는다.
- live 배포 완료로 쓰지 않는다.
- 현재 repo 기준 handler, Unity caller, live proof는 추가 확인 필요다.

### 4.4 Balance / Workbook / Validator 후보

밸런스는 최종 수치 확정이 아니라 검증 기준과 근거 분리 관점에서 다룬다. workbook, validator, simulator, CSV/JSON 계약, pacing dashboard 같은 자료는 Project3에서 중요한 후보지만, 현재 repo에는 원본 workbook과 실행 로그가 없다.

따라서 기술문서에서는 다음처럼 제한한다.

- 밸런스 전체 확정이 아니라 검증 기준 분리로 설명한다.
- workbook과 validator는 보강 필요 자료로 둔다.
- 수치 조정 결과를 성과처럼 쓰지 않는다.
- CSV/JSON 계약은 실제 자료 확보 전까지 후보로 둔다.

근거 경로:

- `projects/project3-fisher/balance-evidence.md`
- `projects/project3-fisher/technical-evidence.md`
- `portfolio/03-project3-fisher/tools-and-verification.md`

### 4.5 UI / Art Pipeline 경계

UI 리소스는 생성물 자체보다 적용 기준이 중요했다. 투명 배경, padding, naming convention, sprite 기준, Unity 적용 여부를 분리해야 한다. AI 이미지 산출물, 팀원 아트, 본인 지시/검수/적용 범위를 섞으면 과장 위험이 생긴다.

기술문서에서는 UI/아트 파이프라인을 "전체 UI 아트 제작"이 아니라 리소스 기준과 검수 지시문, 적용 여부를 분리한 작업 기준으로 다룬다.

근거 경로:

- `projects/project3-fisher/ui-art-pipeline-evidence.md`
- `projects/project3-fisher/technical-evidence.md`
- `portfolio/03-project3-fisher/ai-assisted-workflow.md`

확인 필요:

- 실제 지시문.
- 산출물 원본.
- Unity 적용 로그.
- 팀원/AI 산출물과 본인 기여 범위.

### 4.6 Codex/AI 사용 방식

Codex/AI를 무조건 코드 작성에 쓰지 않았다. 이 문서에서 AI 활용은 구현 claim이 아니라 검토와 검증 큐 관리 방식으로 설명한다.

사용 방향:

- read-only scan.
- 영향 범위 제한.
- snippet append 금지.
- 전체 원본 기준 검증 후보 생성.
- current-truth와 verification queue 정리.
- public evidence boundary 관리.

금지할 표현:

- AI가 전부 구현했다.
- AI가 만든 결과를 본인 직접 제작물처럼 표현한다.
- AI/Codex 없이 전부 직접 작성했다.

### 4.7 검증과 한계

Project3 Fisher는 자소서 보조 소재로 사용 가능하다. 현재 안전하게 사용할 수 있는 소재는 다음이다.

- code 확인, build/self-test, Play Mode, live proof를 분리해 기록한 기준.
- 팀 원본 소스와 PlayFab 설정을 GitHub에 복사하지 않는 공개 범위 관리.
- AI/Codex를 분석/검토/검증 큐 관리 보조로 제한한 기준.
- PlayFab 문제를 Unity 요청, 서버 응답, live proof로 나누어 보려는 진단 기준.

보강 필요:

- 실제 `.cs` code evidence.
- Fisher/CSH 담당 범위.
- CloudScript handler와 Unity caller.
- balance workbook과 validator log.
- Play Mode / build / live proof 로그.
- 팀 공개 승인.

따라서 Project3를 완성 게임 포트폴리오, 서버 전체 구현, 전체 밸런스 확정, 모든 검증 완료로 표현하지 않는다.

## 5. 개인프로젝트: EscapeRoom

### 5.1 프로젝트에서 다룬 범위

EscapeRoom은 개인 프로젝트다. 팀프로젝트 서사에서 직접 구현 방어가 필요한 지점을 보강하는 코드 근거로 사용한다. 현재 repo에는 공개 가능한 핵심 C# 코드 10개가 `portfolio/01-escape-room/code/` 아래에 있다.

근거 경로:

- `projects/project1-escape-room/summary.md`
- `projects/project1-escape-room/technical-evidence.md`
- `projects/project1-escape-room/claim-evidence-map.md`
- `projects/project1-escape-room/source-file-map.md`
- `projects/project1-escape-room/interview-points.md`
- `portfolio/01-escape-room/code/`

설명 가능한 축:

- GameState / ProgressState 분리.
- EnemyVision 거리 / 각도 / Raycast 감지.
- DetectionController / FailureHandler 실패 흐름.
- CheckpointManager / CheckpointTrigger 복귀 흐름.
- TreasureGridManager / TreasureEnemy 퍼즐 reset / phase unlock / 추적 적 흐름.

### 5.2 GameState / ProgressState 분리

한 씬에서 이동, 상호작용, 감지, 퍼즐 진행 상태가 섞이면 어떤 조건에서 플레이어가 행동 가능한지 설명하기 어려워진다. EscapeRoom에서는 `GameManager`와 `ProgressState`를 나누어 현재 행동 가능 상태와 퍼즐 진행도를 분리했다.

`GameManager`는 현재 게임 상태와 행동 가능 여부를 다루고, `ProgressState`는 퍼즐 클리어, Phase2, Exit unlock 같은 진행 플래그를 다룬다. 이 분리는 런타임 상태와 진행도를 한 덩어리로 묶지 않기 위한 구조다.

근거 경로:

- `portfolio/01-escape-room/code/Core/GameManager.cs`
- `portfolio/01-escape-room/code/Core/ProgressState.cs`
- `projects/project1-escape-room/claim-evidence-map.md`

확인 필요:

- enum 정의.
- scene 연결.
- Play Mode 영상.

### 5.3 EnemyVision 거리/각도/Raycast 감지

적 감지는 단순 거리 판정만으로 처리하면 벽, 방향, 시야각을 반영하기 어렵다. EscapeRoom의 `EnemyVision`은 거리, 각도, Raycast line-of-sight 순서로 감지 조건을 나누어 판단한다.

설명 가능한 흐름:

1. 플레이어와 적 사이의 거리를 확인한다.
2. 적의 전방 기준으로 플레이어가 시야각 안에 있는지 확인한다.
3. Raycast로 line-of-sight를 확인해 장애물 여부를 본다.
4. `PlayerDetectionTarget`을 통해 감지 대상 Transform을 분리한다.

근거 경로:

- `portfolio/01-escape-room/code/Enemy/EnemyVision.cs`
- `portfolio/01-escape-room/code/Enemy/DetectionController.cs`
- `portfolio/01-escape-room/code/Player/PlayerDetectionTarget.cs`
- `projects/project1-escape-room/technical-evidence.md`

표현 제한:

- 상용 수준 스텔스 AI로 표현하지 않는다.
- 모든 적 AI 로직 직접 구현으로 표현하지 않는다.
- layer mask, 장애물 배치, Play Mode 검증은 확인 필요로 둔다.

### 5.4 FailureHandler와 Checkpoint 복귀

감지 성공 또는 퍼즐 실패는 실패 처리와 복귀 흐름으로 이어진다. 이때 실패 처리가 중복 실행되거나 복귀 위치가 꼬이면 재시도 경험이 깨질 수 있다.

EscapeRoom에서는 `DetectionController`가 감지 결과를 보고하고, `FailureHandler`가 실패 중복 실행을 막으며, 체크포인트 복귀 책임은 `CheckpointManager` / `CheckpointTrigger`와 연결된다. 즉, 감지, 실패 처리, 복귀 책임을 한 곳에 몰아넣지 않고 역할별로 나누었다.

근거 경로:

- `portfolio/01-escape-room/code/Enemy/DetectionController.cs`
- `portfolio/01-escape-room/code/Core/FailureHandler.cs`
- `portfolio/01-escape-room/code/Core/CheckpointManager.cs`
- `portfolio/01-escape-room/code/World/CheckpointTrigger.cs`

확인 필요:

- `InputLockController`.
- FailureReason / FailureRecoveryType enum 정의.
- scene trigger 배치.
- Play Mode 검증.

### 5.5 Treasure Puzzle 상태 관리

Treasure Puzzle은 퍼즐 진행, path, reset, phase unlock이 섞일 수 있는 구조다. `TreasureGridManager`는 node 등록, path 생성, reset, puzzle solved, phase unlock 흐름을 관리한다. `TreasureEnemy`는 퍼즐 내부 추적 적과 실패 조건을 담당한다.

이 장에서는 "모든 퍼즐을 완벽하게 구현했다"가 아니라, Treasure 퍼즐의 상태/reset/phase unlock 흐름을 코드로 설명할 수 있다는 점에 집중한다.

근거 경로:

- `portfolio/01-escape-room/code/Puzzle/TreasureGridManager.cs`
- `portfolio/01-escape-room/code/Puzzle/TreasureEnemy.cs`
- `portfolio/01-escape-room/code/Core/ProgressState.cs`
- `projects/project1-escape-room/claim-evidence-map.md`

확인 필요:

- `TreasureNode`.
- `TreasurePlayerMovement`.
- `TreasureTrigger`.
- 실제 node 연결.
- 시연 영상.

### 5.6 검증과 한계

EscapeRoom은 현재 세 프로젝트 중 코드 근거 방어력이 가장 높다. 공개 코드 10개가 repo에 있으며, 상태 관리, 감지, 실패 처리, 체크포인트, Treasure 퍼즐 흐름을 파일 단위로 설명할 수 있다.

한계:

- scene/prefab/Inspector 연결은 현재 repo에 없다.
- Play Mode, 빌드, 시연 영상은 추가 확인 필요다.
- HideZone, PuzzleSafeZone, Player 이동 구현 파일은 현재 repo 기준 확인 필요다.
- 일부 enum과 지원 타입은 현재 repo에 없다.

따라서 기술문서에서는 코드 구조 설명은 가능하지만, 모든 런타임 검증 완료로 표현하지 않는다.

## 6. 세 프로젝트를 통해 정리한 개발 방식

세 프로젝트를 하나의 흐름으로 묶으면 다음 개발 방식이 드러난다.

1. Coin Laundry에서는 기능 구현 중 상태 변경과 실패 처리 책임 분리의 필요성을 경험했다.
2. Project3 Fisher에서는 같은 문제를 더 큰 협업 구조에서 다루며 검증 수준과 공개 가능 근거를 먼저 나누는 방식으로 확장했다.
3. EscapeRoom에서는 Unity/C# 기본 구현을 통해 상태, 감지, 실패, 체크포인트, 퍼즐 구조를 직접 코드로 설명할 수 있는 근거를 만들었다.

이 흐름의 핵심은 기능 이름이 아니라 책임 분리다.

- UI preview와 commit 분리.
- spend / receive / refund 흐름 분리.
- Unity 요청 / 서버 응답 / live proof 분리.
- 코드 확인 / Play Mode / 빌드 / live proof 분리.
- 감지 / 실패 처리 / 체크포인트 복귀 분리.
- 퍼즐 진행 / reset / phase unlock 분리.

## 7. 검증 기준

검증 수준은 다음처럼 구분한다.

| 구분 | 의미 | 사용 기준 |
| --- | --- | --- |
| 코드 확인 | repo의 코드 또는 code excerpt를 읽고 구조를 확인한 상태 | 실제 실행 검증과 구분 |
| 문서 확인 | summary, claim map, source map 등 문서 근거가 있는 상태 | 구현 완료 claim으로 올리지 않음 |
| Play Mode 확인 | Unity Play Mode에서 재현/확인을 마친 상태 | 원본 로그 또는 영상 필요 |
| 빌드 확인 | 빌드 또는 batch/self-test 결과가 있는 상태 | Play Mode와 구분 |
| live proof | 서버/live 환경 반영까지 확인된 상태 | PlayFab/CloudScript에서 특히 분리 |
| 확인 필요 | 현재 repo 기준 근거가 부족한 상태 | 자소서/이력서 확정 표현 금지 |

프로젝트별 현재 검증 수준:

| 프로젝트 | claim | 현재 검증 수준 | 근거 경로 | 보강 필요 자료 |
| --- | --- | --- | --- | --- |
| Coin Laundry | Inventory preview/commit 분리 | 문서 확인 | `projects/project2-coin-laundry/technical-evidence.md`, `claim-evidence-map.md` | 원본 코드, 작성자/커밋, Play Mode 로그 |
| Coin Laundry | Shop spend -> receive -> refund 흐름 | 문서 확인 | `technical-evidence.md`, `claim-evidence-map.md` | 실패 재현 로그, 재화 처리 코드 |
| Coin Laundry | Merge 판정/실행 책임 분리 | 문서 확인 | `technical-evidence.md`, `source-file-map.md` | 원본 코드, 호출 흐름 |
| Project3 Fisher | 검증 수준 분리 | 문서 확인 | `projects/project3-fisher/technical-evidence.md`, `portfolio/03-project3-fisher/tools-and-verification.md` | 실제 build/Play Mode/live 로그 |
| Project3 Fisher | PlayFab 요청/응답/live proof 분리 | 문서 확인 | `claim-evidence-map.md`, `portfolio/03-project3-fisher/evidence-source-map.md` | handler, caller, live proof |
| Project3 Fisher | AI/Codex 검증 큐 관리 | 문서 확인 | `portfolio/03-project3-fisher/ai-assisted-workflow.md` | 실제 반영 사례 로그 |
| EscapeRoom | GameState / ProgressState 분리 | 코드 확인 | `GameManager.cs`, `ProgressState.cs` | enum, scene 연결 |
| EscapeRoom | EnemyVision 감지 | 코드 확인 | `EnemyVision.cs`, `DetectionController.cs`, `PlayerDetectionTarget.cs` | layer/obstacle 설정, Play Mode |
| EscapeRoom | Failure / Checkpoint 복귀 | 코드 확인 | `FailureHandler.cs`, `CheckpointManager.cs`, `CheckpointTrigger.cs` | InputLockController, scene trigger |
| EscapeRoom | Treasure Puzzle reset / phase unlock | 코드 확인 | `TreasureGridManager.cs`, `TreasureEnemy.cs` | 누락 타입, 시연 영상 |

## 8. 한계와 보강 예정

이 문서는 과장을 줄이기 위해 확인 필요 항목을 의도적으로 남긴다.

Coin Laundry 보강 예정:

- 작성자/커밋/팀 change log 확인.
- Play Mode 원본 검증 로그 확보.
- 팀 공개 승인 또는 면접 전용 사용 기준 확인.
- EventBus 또는 이벤트 연결 코드 확인.
- 시연 영상 또는 발표자료 연결.

Project3 Fisher 보강 예정:

- 실제 `.cs` 코드 또는 sanitized excerpt 확보.
- Fisher/CSH 담당 범위 확인.
- CloudScript handler, Unity caller, failure/live proof 확보.
- balance workbook과 validator 실행 로그 확보.
- UI/아트 파이프라인 산출물과 Unity 적용 근거 확보.

EscapeRoom 보강 예정:

- scene/prefab/Inspector 연결 확인.
- Play Mode 또는 빌드 검증 로그 확보.
- 시연 영상, 스크린샷, 발표자료 연결.
- HideZone, PuzzleSafeZone, Player 이동 코드 확인.
- 누락 enum과 지원 타입 확인.

## 9. 면접에서 방어할 질문

### Coin Laundry

- preview와 commit을 왜 나눴는가?
- 구매 실패 시 refund 흐름은 어떻게 잡았는가?
- merge 판정과 실행 책임은 왜 분리했는가?
- 이 기능들을 직접 구현했다고 말할 수 있는가?
- 코드 확인, 문서 확인, Play Mode 확인을 어떻게 구분했는가?

안전한 답변 방향:

- 현재 repo 기준 직접 구현 확정은 보류한다.
- 담당 범위 후보와 팀 결과물을 분리해 답한다.
- sanitized summary와 source map 기준으로 설명 가능한 구조를 말한다.
- 작성자/커밋/검증 로그는 추가 확인 필요라고 답한다.

### Project3 Fisher

- Project3를 왜 메인 완성작이 아니라 보조 근거로 두는가?
- PlayFab 요청/응답/live proof를 왜 나눴는가?
- AI/Codex는 코드 작성인지 검증 보조인지?
- 팀 원본 코드와 public repo는 왜 분리했는가?
- CloudScript나 PlayFab을 직접 구축했는가?

안전한 답변 방향:

- 완성작 claim이 아니라 검증/문서화/툴링 태도 설명으로 제한한다.
- 서버 전체 구현이 아니라 요청/응답/live proof 분리 기준으로 설명한다.
- AI/Codex는 분석, 검토, 검증 큐 관리 보조로 설명한다.
- 팀 원본 코드, PlayFab 설정, 원본 로그는 public repo에 올리지 않는다고 답한다.

### EscapeRoom

- `GameManager`와 `ProgressState`를 왜 나눴는가?
- EnemyVision은 어떤 순서로 감지하는가?
- FailureHandler와 Checkpoint는 어떻게 연결되는가?
- Treasure Puzzle의 상태 관리는 어디서 하는가?
- scene 연결과 Play Mode 검증은 어디까지 확인됐는가?

안전한 답변 방향:

- 공개 코드 기준으로 상태, 감지, 실패, 체크포인트, 퍼즐 흐름을 설명한다.
- scene/prefab/Play Mode/영상은 확인 필요로 분리한다.
- repo에 없는 HideZone, PuzzleSafeZone, Player 이동은 구현 완료로 말하지 않는다.

## 10. 자소서/PPT로 넘길 핵심 문장

아래 문장은 완성 자소서 문장이 아니라, 이후 3/5 자소서 초안과 4/5 PPT 스토리보드로 넘길 후보 문장이다.

- "팀프로젝트에서 인벤토리와 상점 기능을 다루며, UI 입력과 실제 상태 변경, 구매 실패와 환불, merge 책임이 서로 섞일 수 있다는 점을 먼저 보았다."
- "Coin Laundry에서는 preview와 commit, spend와 receive, refund 경로를 분리해 설명 가능한 구조로 정리했다."
- "Project3 Fisher에서는 같은 인벤토리/상점/데이터 계열 문제를 더 큰 협업 구조에서 다루며, 코드 수정 전 current-truth와 verification queue를 먼저 나누는 방식으로 접근했다."
- "PlayFab이나 CloudScript 문제는 Unity 요청, 서버 응답, live proof를 섞지 않아야 하며, 확인한 수준과 아직 확인해야 할 수준을 분리해 기록했다."
- "개인 프로젝트 EscapeRoom에서는 상태 관리, 감지, 실패 처리, 체크포인트, 퍼즐 진행을 역할별 코드로 나누어 Unity/C# 기본 구현 역량을 보강했다."
- "세 프로젝트를 통해 기능 구현 자체보다 상태 변경 책임, 실패 복구, 검증 수준, 공개 가능 근거를 분리하는 방식이 중요하다는 것을 정리했다."

## 11. 문체와 사용 제한

- AI 문체를 피한다.
- 과도하게 포장하지 않는다.
- "성장했습니다", "기여했습니다"를 반복하지 않는다.
- 실제로 한 판단과 확인한 근거를 중심으로 쓴다.
- 강사님이 기업 제출 전에 검토하는 문서처럼 쓴다.
- 단정이 약한 부분은 `확인 필요`, `후보`, `설명 가능한 구조`로 낮춘다.
- 자소서 완성본, PPT 파일, PPTX, DOCX는 이 단계에서 만들지 않는다.
- Drive 원본, 대용량 자료, 민감정보, 팀 원본 코드는 GitHub에 복사하지 않는다.
