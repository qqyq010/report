# Unity/C# 부트캠프 프로젝트 기술문서

부제: Inventory/Shop 구조화, 검증 경계 관리, 감지/실패 처리 구현 근거

## 1. 문서 개요

이 문서는 Unity/C# 주니어 클라이언트 개발 지원을 위한 기술문서 제출본입니다. 목적은 프로젝트를 성과 중심으로 포장하는 것이 아니라, 각 프로젝트에서 다룬 기능과 문제를 어떤 책임 단위로 나누었고 어디까지 근거로 확인했는지 정리하는 것입니다.

이 문서는 자소서와 PPT의 기준 문서입니다.

- 자소서: 이 문서의 핵심 서사를 1500~2000자 범위로 압축합니다.
- PPT: 이 문서의 흐름을 발표 장표와 시각 자료 후보로 재구성합니다.
- 프로젝트별 표현, 근거 경로, 검증 수준, 확인 필요 항목을 정리하는 기준 문서로 사용합니다.

프로젝트 사용 순서는 다음과 같습니다.

1. Coin Laundry: 팀프로젝트1, Inventory/Shop 중심 기술 사례.
2. Project3 Fisher: 팀프로젝트2, 검증/문서화/툴링/협업 경계 보조 사례.
3. EscapeRoom: 개인 프로젝트, Unity/C# 코드 구현 근거 보강 사례.

표현 제한 기준은 다음과 같습니다.

- 직접 구현, 팀 결과물/협업 기여, 확인 필요, 과장 위험을 분리합니다.
- 코드 확인, 문서 확인, Play Mode 확인, 빌드 확인, 라이브 반영 근거(live proof)를 구분합니다.
- 팀 프로젝트는 본인 담당 범위가 확인되지 않은 항목을 직접 구현으로 확정하지 않습니다.
- Drive 원본 자료, 대용량 파일, 팀 원본 코드, 민감정보는 GitHub에 복사하지 않습니다.

## 2. 전체 개발 서사

### 2.1 Coin Laundry에서 경험한 Inventory/Shop 문제

Coin Laundry에서는 Inventory/Shop 기능을 중심으로 UI 입력, 런타임 상태, 구매 실패, refund, merge 책임 분리 문제를 다룹니다. 인벤토리에서 아이템을 잡고 움직이는 preview 상태와 실제 인벤토리 상태에 반영되는 commit 상태가 섞이면 화면 표시와 실제 데이터가 어긋날 수 있습니다.

상점 구매도 단순한 성공 경로만으로 설명하기 어렵습니다. 골드 차감, 아이템 수령, 실패 시 refund가 연결되므로 receive 실패를 전제로 복구 경로를 별도로 나누어 확인해야 합니다. merge도 UI에서 바로 처리하면 판정과 실행 책임이 섞이기 때문에 서비스 단위의 책임 분리가 필요합니다.

현재 제출본에서는 이 내용을 전체 인벤토리/상점 시스템 단독 구현으로 쓰지 않습니다. `projects/project2-coin-laundry/source-file-map.md`, `claim-evidence-map.md`, `technical-evidence.md` 기준으로 설명 가능한 구조만 다룹니다.

### 2.2 Project3 Fisher에서 확장한 검증/협업 경계

Project3 Fisher는 완성 게임 포트폴리오가 아니라 보조 근거입니다. Coin Laundry에서 다룬 인벤토리/상점/데이터 계열 문제가 더 큰 협업 구조, PlayFab/CloudScript 경계, 밸런스 문서, UI 리소스 기준과 연결되는 사례로 사용합니다.

이 장의 중심은 기능 완성 주장이 아닙니다. 코드 수정 전 현재 기준(current-truth), 검증 대기 목록(verification queue), 라이브 반영 근거, 공개 가능 근거와 비공개 원본의 경계(public evidence boundary)를 나누는 방식입니다. PlayFab 관련 문제는 Unity 요청, 서버 응답, 라이브 반영 근거를 분리해야 하며, Codex/AI는 분석, 검토, 문서화, 검증 대기 목록 관리 보조로 제한합니다.

### 2.3 EscapeRoom으로 보강하는 Unity/C# 구현 근거

EscapeRoom은 개인 프로젝트입니다. 팀 프로젝트에서 직접 구현 확정 표현을 조심해야 하는 부분을 코드 근거로 보강하는 역할을 합니다. 현재 repo에는 `portfolio/01-escape-room/code/` 아래 공개 가능한 핵심 C# 코드가 있으며, GameState/ProgressState, EnemyVision, FailureHandler, Checkpoint, Treasure Puzzle 흐름을 파일 단위로 설명할 수 있습니다.

단, scene/prefab/Inspector 연결, Play Mode, 빌드, 시연 영상은 현재 repo 기준 추가 확인이 필요합니다. HideZone, PuzzleSafeZone, Player 이동 구현도 현재 제출본에서는 구현 완료로 쓰지 않습니다.

## 3. 팀프로젝트1: Coin Laundry

### 3.1 담당 범위와 표현 기준

Coin Laundry는 팀프로젝트1입니다. 기술문서에서는 Inventory/Shop 흐름을 중심으로 다룹니다.

사용 가능한 표현:

- Inventory/Shop에서 UI 입력과 실제 상태 변경 시점을 분리해 설명 가능한 구조로 정리했습니다.
- 구매 실패 시 재화 차감과 아이템 수령이 어긋날 수 있어 spend, receive, refund 흐름을 나누어 보았습니다.
- merge 판정과 실행 책임을 UI와 서비스 기준으로 분리해 설명할 수 있습니다.
- 팀 원본 코드와 공개 가능한 요약/근거를 분리했습니다.

외부 제출 시 사용하지 않을 표현:

- 전체 인벤토리/상점 시스템을 혼자 구현했습니다.
- 팀 전체 시스템을 설계했습니다.
- 모든 Play Mode 검증을 완료했습니다.
- 모든 버그를 해결했습니다.
- sanitized summary만으로 직접 구현이 확정됐다고 말합니다.

근거 경로:

- `projects/project2-coin-laundry/summary.md`
- `projects/project2-coin-laundry/technical-evidence.md`
- `projects/project2-coin-laundry/claim-evidence-map.md`
- `projects/project2-coin-laundry/source-file-map.md`
- `projects/project2-coin-laundry/interview-points.md`
- `portfolio/02-coin-laundry/core-file-index.md`
- `portfolio/02-coin-laundry/evidence-source-map.md`

### 3.2 Inventory preview와 commit 분리

인벤토리 UI에서는 사용자가 아이템을 잡고 움직이는 preview 상태와 실제 인벤토리 상태에 확정 반영되는 commit 상태가 분리되어야 합니다. preview는 입력 중 임시 위치, 회전, 배치 가능성을 판단하는 단계이고, commit은 실제 런타임 상태를 바꾸는 단계입니다.

이 분리가 필요한 이유는 다음과 같습니다.

- preview 중 상태를 실제 데이터로 확정하면 실패 복구가 어려워집니다.
- 회전, 배치 실패, merge, 판매 같은 기능에서 화면 표시와 실제 데이터가 달라질 수 있습니다.
- UI는 입력과 요청 생성에 집중하고, 실제 상태 변경은 런타임 서비스로 넘기는 구조가 설명 가능합니다.

현재 검증 수준은 다음과 같습니다.

- 문서 확인.
- 원본 코드, 작성자/커밋, Play Mode 검증은 추가 확인이 필요합니다.

관련 파일명 후보:

- `InventoryUIController.cs`
- `InventoryRuntimeService.cs`
- `InventoryMergeService.cs`

### 3.3 Shop spend, receive, refund 흐름

상점 구매는 성공 경로만 보면 단순한 골드 차감과 아이템 지급처럼 보입니다. 그러나 receive가 실패하면 골드만 차감되고 인벤토리에 아이템이 들어가지 않는 상태가 생길 수 있습니다. 따라서 구매 흐름은 실패 가능성을 포함해 나누어야 합니다.

설명 가능한 흐름:

1. 구매 요청을 받습니다.
2. 구매 조건과 재화를 확인합니다.
3. 재화를 차감합니다.
4. 아이템을 런타임 인벤토리에 수령합니다.
5. 수령 실패 시 refund 경로로 재화를 복구합니다.
6. 성공/실패 결과를 UI 또는 event 흐름으로 전달합니다.

현재 검증 수준은 다음과 같습니다.

- 문서 확인.
- 실패 케이스 재현 로그, 환불 호출 순서, 재화 처리 ownership은 추가 확인이 필요합니다.

관련 파일명 후보:

- `ShopPurchaseService.cs`
- `InventoryRuntimeService.cs`

### 3.4 Merge 판정과 실행 책임 분리

merge는 UI에서 바로 처리하면 판정, 실행, 복구 책임이 섞입니다. UI는 사용자의 입력과 preview 요청을 만들고, 서비스는 merge 가능 여부와 실제 인벤토리 상태 변경을 담당하는 편이 설명하기 쉽습니다.

설명 가능한 구조:

- `CanMerge`: 두 아이템이 합쳐질 수 있는지 판정합니다.
- `TryMergeItems`: 실제 merge 실행과 상태 변경을 담당합니다.
- UI preview는 서비스의 판정/실행 책임을 대체하지 않습니다.

현재 검증 수준은 다음과 같습니다.

- 문서 확인.
- 실제 `CanMerge` / `TryMergeItems` 호출 흐름, swap/restore/fallback 조건, 담당 범위는 추가 확인이 필요합니다.

### 3.5 검증 수준과 한계

Coin Laundry 장은 현재 문서 확인과 sanitized summary 중심으로 정리되어 있습니다. 기술 구조를 설명할 수 있는 근거는 정리되어 있으나, 직접 구현 확정으로 올리기에는 자료가 부족합니다.

보강이 필요한 자료:

- 4개 핵심 파일의 작성자/커밋/팀 change log.
- 팀 공개 승인 또는 비공개 검토용 사용 기준.
- 원본 코드 공개 가능 범위.
- Play Mode 원본 검증 로그.
- Inventory/Shop 시연 영상.
- EventBus 또는 이벤트 연결 코드.

자소서/PPT 사용 수위:

- 사용 가능: 담당 범위 후보, 설명 가능한 구조, 문서 근거 기반 정리.
- 보류: 직접 구현 확정, 전체 시스템 단독 구현, QA 완료 주장.

## 4. 팀프로젝트2: Project3 Fisher

### 4.1 보조 근거로 사용하는 이유

Project3 Fisher는 팀프로젝트2입니다. 이 문서에서는 완성 게임 포트폴리오로 사용하지 않고, 검증/문서화/툴링/협업 경계 관리 보조 근거로만 사용합니다.

사용 가능한 표현:

- 검증 수준을 code 확인, build/self-test, Play Mode, 라이브 반영 근거로 나누어 기록했습니다.
- 팀 원본 코드, PlayFab 설정, 원본 로그를 public repo에 복사하지 않는 기준을 정리했습니다.
- AI/Codex를 구현 성과 대체가 아니라 분석, 검토, 검증 대기 목록 관리 보조로 활용했습니다.
- PlayFab 관련 문제를 Unity 요청, 서버 응답, 라이브 반영 근거로 분리해 보려 했습니다.

외부 제출 시 사용하지 않을 표현:

- 완성 게임 포트폴리오.
- 서버 전체 구현.
- PlayFab 전체 설계.
- 라이브 서비스 운영.
- 전체 밸런스 확정.
- 모든 검증 완료.

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

### 4.2 현재 기준 / 검증 대기 목록 / 라이브 반영 근거 분리

Project3 Fisher에서는 코드 수정 전에 현재 기준과 검증 대상을 나누는 것이 중요했습니다.

- 현재 기준: 지금 기준으로 맞는 문서, 코드, 팀 결정이 무엇인지 확인합니다.
- 검증 대기 목록: 검증해야 할 항목을 목록화합니다.
- 라이브 반영 근거: 서버/live 환경 반영까지 확인된 자료를 별도 근거로 둡니다.
- 공개 범위 경계: GitHub에 둘 수 있는 요약과 Drive/비공개에 둘 원본을 분리합니다.

이 분리는 기능 완성을 주장하기 위한 것이 아니라, 팀 프로젝트에서 확인 수준을 섞지 않기 위한 기준입니다.

### 4.3 PlayFab / CloudScript 요청·응답 경계

PlayFab / CloudScript 관련 문제는 UI 증상만으로 원인을 확정하기 어렵습니다. Unity 호출부, CloudScript handler, 서버 응답, 라이브 반영 근거를 따로 보아야 합니다.

설명 가능한 분리:

- Unity request: 클라이언트가 어떤 인자와 상태로 요청했는가.
- CloudScript handler: 서버 쪽에서 어떤 분기와 검증을 수행하는가.
- response: 성공/실패 결과가 어떤 형태로 돌아오는가.
- 라이브 반영 근거: live 환경에 반영되어 같은 결과가 재현되는가.

현재 검증 수준은 다음과 같습니다.

- 문서 확인.
- handler, caller, failure log, 라이브 반영 근거는 추가 확인이 필요합니다.

### 4.4 Balance / workbook / validator 후보

밸런스 자료는 최종 수치 확정이 아니라 검증 기준과 근거 분리 관점에서 다룹니다. workbook, validator, simulator, CSV/JSON 계약, pacing dashboard는 후보 자료지만, 현재 제출본 기준으로 원본 workbook과 실행 로그는 추가 확인이 필요합니다.

사용 가능한 표현:

- 밸런스 수치 확정이 아니라 검증 기준과 근거 분리를 관리했습니다.
- workbook과 validator는 보강 필요 자료로 분리했습니다.
- CSV/JSON 계약은 실제 자료 확보 전까지 후보로 둡니다.

외부 제출 시 피해야 할 표현:

- 전체 게임 밸런스를 확정했습니다.
- 상용 밸런싱을 완료했습니다.
- 모든 검증을 완료했습니다.

### 4.5 UI / Art pipeline 경계

UI/아트 파이프라인은 생성물 자체보다 적용 기준과 검수 경계가 중요합니다. AI 이미지 산출물, 팀원 아트, 본인 지시/검수/적용 범위를 섞으면 과장 위험이 생깁니다.

설명 가능한 기준:

- 투명 배경, padding, naming convention, sprite 기준을 분리합니다.
- prompt, 산출물, Unity 적용 여부를 분리합니다.
- AI 산출물을 본인 직접 제작 그래픽처럼 표현하지 않습니다.

추가 확인이 필요한 항목:

- 실제 지시문.
- 산출물 원본.
- Unity 적용 로그.
- 팀원/AI 산출물과 본인 기여 범위.

### 4.6 Codex/AI 사용 기준

Codex/AI는 구현 주장이 아니라 검토와 검증 대기 목록 관리 보조로 설명합니다.

사용 기준:

- read-only scan.
- 영향 범위 제한.
- snippet append 금지.
- 전체 원본 기준 통합 후보 생성.
- 현재 기준과 검증 대기 목록 정리.
- 공개 범위 경계 관리.

외부 제출 시 사용하지 않을 표현:

- AI가 전부 구현했습니다.
- AI가 만든 결과를 본인 직접 제작물처럼 사용했습니다.
- AI/Codex 없이 전부 직접 작성했습니다.

### 4.7 검증 수준과 한계

Project3 Fisher는 보조 소재로 사용 가능하지만, 직접 구현 확정이나 완성작 주장으로 올리지 않습니다.

현재 사용 가능:

- 검증 수준을 분리한 작업 기준.
- 공개 범위 경계 관리.
- AI/Codex를 검토 보조로 제한한 기준.
- PlayFab 문제를 Unity 요청, 서버 응답, 라이브 반영 근거로 나누어 보는 진단 기준.

보강이 필요한 자료:

- Fisher/CSH 담당 범위.
- 실제 `.cs` 코드 또는 sanitized excerpt.
- CloudScript handler와 Unity caller.
- balance workbook과 validator log.
- Play Mode / build / 라이브 반영 근거 로그.
- 팀 공개 승인.

## 5. 개인프로젝트: EscapeRoom

### 5.1 개인 프로젝트로서의 위치

EscapeRoom은 개인 프로젝트이며, Unity/C# 기본 구현 역량을 코드로 설명하는 근거입니다. 현재 repo에는 공개 가능한 핵심 C# 코드가 있으며, 상태 관리, 감지, 실패 처리, 체크포인트, Treasure 퍼즐 흐름을 파일 단위로 설명할 수 있습니다.

근거 경로:

- `projects/project1-escape-room/summary.md`
- `projects/project1-escape-room/technical-evidence.md`
- `projects/project1-escape-room/claim-evidence-map.md`
- `projects/project1-escape-room/source-file-map.md`
- `projects/project1-escape-room/interview-points.md`
- `portfolio/01-escape-room/code/`

표현 제한:

- 상용 수준 스텔스 AI로 표현하지 않습니다.
- 모든 런타임 검증 완료로 표현하지 않습니다.
- scene/prefab/Play Mode/영상은 추가 확인이 필요한 항목으로 둡니다.

### 5.2 GameState / ProgressState 분리

EscapeRoom에서는 현재 행동 가능 상태와 퍼즐 진행도를 분리합니다. `GameManager`는 현재 게임 상태와 행동 가능 여부를 다루고, `ProgressState`는 퍼즐 클리어, Phase2, Exit unlock 같은 진행 플래그를 다룹니다.

근거 경로:

- `portfolio/01-escape-room/code/Core/GameManager.cs`
- `portfolio/01-escape-room/code/Core/ProgressState.cs`
- `projects/project1-escape-room/claim-evidence-map.md`

추가 확인이 필요한 항목:

- enum 정의.
- scene 연결.
- Play Mode 영상.

### 5.3 EnemyVision 거리·각도·Raycast 감지

`EnemyVision`은 적 감지를 거리, 각도, Raycast line-of-sight 순서로 나누어 판단합니다. 단순 거리 판정만 쓰면 벽, 방향, 시야각을 설명하기 어렵기 때문에 조건을 단계별로 분리합니다.

설명 가능한 흐름:

1. 플레이어와 적 사이의 거리를 확인합니다.
2. 적의 전방 기준으로 플레이어가 시야각 안에 있는지 확인합니다.
3. Raycast로 line-of-sight를 확인해 장애물 여부를 봅니다.
4. `PlayerDetectionTarget`을 통해 감지 대상 Transform을 분리합니다.

근거 경로:

- `portfolio/01-escape-room/code/Enemy/EnemyVision.cs`
- `portfolio/01-escape-room/code/Enemy/DetectionController.cs`
- `portfolio/01-escape-room/code/Player/PlayerDetectionTarget.cs`
- `projects/project1-escape-room/technical-evidence.md`

추가 확인이 필요한 항목:

- layer mask.
- 장애물 배치.
- Play Mode 검증.

### 5.4 FailureHandler와 Checkpoint 복귀

감지 성공 또는 퍼즐 실패는 실패 처리와 복귀 흐름으로 이어집니다. 실패 처리가 중복 실행되거나 복귀 위치가 꼬이면 재시도 흐름이 깨질 수 있으므로 감지, 실패 처리, 체크포인트 복귀 책임을 나누어 설명합니다.

설명 가능한 흐름:

- `DetectionController`: 감지 결과를 보고합니다.
- `FailureHandler`: 실패 중복 실행을 막고 실패 처리를 담당합니다.
- `CheckpointManager` / `CheckpointTrigger`: 복귀 위치와 트리거 흐름을 담당합니다.

근거 경로:

- `portfolio/01-escape-room/code/Enemy/DetectionController.cs`
- `portfolio/01-escape-room/code/Core/FailureHandler.cs`
- `portfolio/01-escape-room/code/Core/CheckpointManager.cs`
- `portfolio/01-escape-room/code/World/CheckpointTrigger.cs`

추가 확인이 필요한 항목:

- `InputLockController`.
- FailureReason / FailureRecoveryType enum 정의.
- scene trigger 배치.
- Play Mode 검증.

### 5.5 Treasure Puzzle 상태 관리

Treasure Puzzle은 path, reset, phase unlock, 퍼즐 내부 추적 적 흐름이 연결됩니다. `TreasureGridManager`는 node 등록, path 생성, reset, puzzle solved, phase unlock 흐름을 관리하고, `TreasureEnemy`는 퍼즐 내부 추적 적과 실패 조건을 담당합니다.

근거 경로:

- `portfolio/01-escape-room/code/Puzzle/TreasureGridManager.cs`
- `portfolio/01-escape-room/code/Puzzle/TreasureEnemy.cs`
- `portfolio/01-escape-room/code/Core/ProgressState.cs`
- `projects/project1-escape-room/claim-evidence-map.md`

추가 확인이 필요한 항목:

- `TreasureNode`.
- `TreasurePlayerMovement`.
- `TreasureTrigger`.
- 실제 node 연결.
- 시연 영상.

### 5.6 검증 수준과 한계

EscapeRoom은 세 프로젝트 중 코드 근거 방어력이 가장 높습니다. 상태 관리, 감지, 실패 처리, 체크포인트, Treasure 퍼즐 흐름을 공개 코드 기준으로 설명할 수 있습니다.

한계:

- scene/prefab/Inspector 연결은 현재 repo에 없습니다.
- Play Mode, 빌드, 시연 영상은 추가 확인이 필요합니다.
- HideZone, PuzzleSafeZone, Player 이동 구현 파일은 현재 repo 기준 추가 확인이 필요합니다.
- 일부 enum과 지원 타입은 현재 repo에 없습니다.

자소서/PPT 사용 수위:

- 사용 가능: 공개 코드 기준 구조 설명.
- 보류: 모든 런타임 검증 완료, 상용 수준 스텔스 AI, 모든 퍼즐 완성 주장.

## 6. 프로젝트를 통해 정리한 개발 방식

세 프로젝트에서 공통적으로 정리한 기준은 기능 이름이 아니라 책임 분리와 검증 수준 분리입니다.

- UI preview / commit 분리.
- spend / receive / refund 분리.
- Unity request / server response / 라이브 반영 근거 분리.
- code 확인 / Play Mode / build / 라이브 반영 근거 분리.
- detection / failure / checkpoint 분리.
- puzzle reset / phase unlock 분리.

이 기준은 자소서에서는 작업 서사로, PPT에서는 장표 구조로, 검토 자료에서는 확인 수준과 근거 경로를 맞추는 기준으로 사용합니다.

## 7. 검증 기준

| 프로젝트 | 표현 | 현재 검증 수준 | 근거 경로 | 보강 필요 자료 | 자소서/PPT 사용 가능 수위 |
| --- | --- | --- | --- | --- | --- |
| Coin Laundry | Inventory preview/commit 분리 | 문서 확인 | `projects/project2-coin-laundry/technical-evidence.md`, `claim-evidence-map.md`, `source-file-map.md` | 원본 코드, 작성자/커밋, Play Mode 로그 | 담당 범위 후보와 설명 가능한 구조 |
| Coin Laundry | Shop spend/receive/refund 흐름 | 문서 확인 | `technical-evidence.md`, `claim-evidence-map.md`, `portfolio/02-coin-laundry/evidence-source-map.md` | 실패 재현 로그, 재화 처리 코드, 호출 순서 | 구매 실패 복구 경로를 고려한 구조 |
| Coin Laundry | Merge 판정/실행 책임 분리 | 문서 확인 | `technical-evidence.md`, `source-file-map.md` | 원본 코드, 담당 범위, merge 검증 자료 | UI/서비스 책임 분리 설명 |
| Project3 Fisher | 검증 수준 분리 | 문서 확인 | `projects/project3-fisher/technical-evidence.md`, `portfolio/03-project3-fisher/tools-and-verification.md` | 실제 build/Play Mode/라이브 반영 로그 | 검증/문서화 보조 근거 |
| Project3 Fisher | PlayFab 요청/응답/라이브 반영 근거 분리 | 문서 확인 | `projects/project3-fisher/claim-evidence-map.md`, `portfolio/03-project3-fisher/evidence-source-map.md` | handler, caller, failure log, 라이브 반영 근거 | 서버 구현이 아닌 진단 기준 |
| Project3 Fisher | AI/Codex 검증 대기 목록 관리 | 문서 확인 | `portfolio/03-project3-fisher/ai-assisted-workflow.md` | 실제 반영 사례 로그 | 검토/문서화/검증 대기 목록 관리 방식 |
| EscapeRoom | GameState / ProgressState 분리 | 코드 확인 | `portfolio/01-escape-room/code/Core/GameManager.cs`, `ProgressState.cs` | enum, scene 연결, Play Mode | 개인 프로젝트 코드 구조 설명 |
| EscapeRoom | EnemyVision 감지 | 코드 확인 | `EnemyVision.cs`, `DetectionController.cs`, `PlayerDetectionTarget.cs` | layer/obstacle 설정, Play Mode | 거리/각도/Raycast 감지 구조 |
| EscapeRoom | Failure / Checkpoint 복귀 | 코드 확인 | `FailureHandler.cs`, `CheckpointManager.cs`, `CheckpointTrigger.cs` | 지원 타입, scene trigger, Play Mode | 실패 처리와 복귀 책임 분리 |
| EscapeRoom | Treasure Puzzle reset / phase unlock | 코드 확인 | `TreasureGridManager.cs`, `TreasureEnemy.cs`, `ProgressState.cs` | 누락 타입, node 연결, 시연 영상 | 퍼즐 상태/reset/phase unlock 구조 |

## 8. 한계와 보강 예정

### Coin Laundry

- 작성자/커밋/팀 change log 확인이 필요합니다.
- Play Mode 원본 검증 로그 확보가 필요합니다.
- 팀 공개 승인 또는 비공개 검토용 사용 기준 확인이 필요합니다.
- EventBus 또는 이벤트 연결 코드 확인이 필요합니다.
- 시연 영상 또는 발표자료 연결이 필요합니다.

### Project3 Fisher

- Fisher/CSH 실제 담당 범위 확인이 필요합니다.
- 실제 `.cs` 코드 또는 sanitized excerpt 확보가 필요합니다.
- CloudScript handler, Unity caller, failure/라이브 반영 근거 확보가 필요합니다.
- balance workbook과 validator 실행 로그 확보가 필요합니다.
- UI/아트 파이프라인 산출물과 Unity 적용 근거 확보가 필요합니다.

### EscapeRoom

- scene/prefab/Inspector 연결 확인이 필요합니다.
- Play Mode 또는 빌드 검증 로그 확보가 필요합니다.
- 시연 영상, 스크린샷, 발표자료 연결이 필요합니다.
- HideZone, PuzzleSafeZone, Player 이동 코드 확인이 필요합니다.
- 누락 enum과 지원 타입 확인이 필요합니다.

## 9. 제출 전 확인 사항

### Drive 원본 자료

- 원본 PPT, PDF, 이미지, 영상, 압축파일은 Drive `center`에 보관합니다.
- GitHub에는 원본을 복사하지 않고 요약, 링크, 공개 가능한 근거만 둡니다.

### 시연 영상

- Coin Laundry: Inventory/Shop preview, commit, 구매 성공/실패, refund, merge 시연.
- EscapeRoom: EnemyVision, FailureHandler, Checkpoint, Treasure Puzzle 시연.
- Project3 Fisher: 검증 흐름 또는 관련 설명 영상 후보.

### 코드 캡처

- Project2: 팀 승인 범위 내에서만 Inventory/Shop 관련 코드 캡처를 사용합니다.
- Project3: 실제 코드 또는 sanitized excerpt 확보 전까지 문서/요약 중심으로 사용합니다.
- EscapeRoom: 공개 가능한 C# 코드 캡처를 사용할 수 있습니다.

### 팀 공개 승인

- Project2와 Project3의 팀 원본 코드, 팀 내부 로그, PlayFab 설정, 원본 피드백은 공개 승인 전 GitHub에 올리지 않습니다.
- 비공개 검토용으로만 사용할 자료와 public repo에 둘 자료를 분리합니다.

### 민감정보 제거

- API Key, Secret, Token, PlayFab Secret Key, Firebase 설정, `.env` 파일을 제거합니다.
- 팀원 개인정보, 유료 에셋 원본, 원본 Unity log, 로컬 절대경로를 제거합니다.
- `.docx`, `.pptx`, `.pdf`, 이미지, 영상, 압축파일 원본은 GitHub에 넣지 않습니다.

### 강사님께 확인받을 질문

- Coin Laundry의 Inventory/Shop 표현을 어느 수준까지 담당 범위로 말해도 되는가?
- Project2 직접 구현 확정은 보류하고 제한 표현으로 쓰는 현재 기준이 안전한가?
- Project3 Fisher를 보조 근거로 배치한 흐름이 자연스러운가?
- EscapeRoom을 코드 방어 근거로 사용하는 구성이 설득력 있는가?
- 제출 전 반드시 보강해야 할 영상, 코드 캡처, 검증 로그는 무엇인가?
