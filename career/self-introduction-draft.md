# Self Introduction Draft

## 1. 자소서 초안

부트캠프에서 Unity/C# 프로젝트를 진행하며 먼저 잡은 기준은 기능을 빨리 붙이는 것보다 책임과 검증 범위를 나누는 일이었습니다. 팀 프로젝트에서는 하나의 기능처럼 보이는 작업도 UI 입력, 실제 상태 변경, 실패 복구, 검증 수준이 함께 얽혔습니다. 화면에서 정상처럼 보여도 runtime state가 맞지 않거나, 코드 확인과 Play Mode 확인을 같은 말로 섞으면 나중에 설명하기 어려운 문제가 됐습니다. 그래서 프로젝트를 정리할 때도 무엇을 만들었는지보다 어떤 책임을 어디서 끊고, 어떤 근거로 확인했는지를 먼저 기준으로 삼았습니다.

팀프로젝트1 Coin Laundry에서는 Inventory와 Shop 흐름을 다루며 이 문제를 처음 구체적으로 마주했습니다. 인벤토리는 아이템을 잡고 움직이는 preview 상태와 실제 데이터가 바뀌는 commit 상태가 섞이기 쉬웠고, 상점 구매는 골드 차감과 아이템 수령이 함께 일어나 실패 경로를 따로 보아야 했습니다. 담당 범위에서 preview와 commit, spend와 receive, 실패 시 refund 흐름을 나누어 정리했고, merge도 UI가 모든 판단을 처리하는 것이 아니라 판정과 실행 책임을 service 쪽으로 분리해 설명할 수 있도록 근거를 정리했습니다. 아직 작성자, 커밋, Play Mode 원본 로그 확인이 남아 있어 단독 구현처럼 말하지 않고, 설명 가능한 구조와 보강 필요 자료를 분리해 두었습니다.

Project3 Fisher에서는 같은 인벤토리/상점/데이터 계열 문제가 더 큰 협업 구조와 서버 경계에서 나타났습니다. 이 프로젝트는 완성작으로 내세우기보다 검증, 문서화, 툴링, 협업 경계 관리의 보조 근거로 정리했습니다. Fisher/CSH, PlayFab, CloudScript, 밸런스, UI 리소스가 함께 얽히면 코드만 고쳐서는 원인을 좁히기 어렵다고 보았습니다. 그래서 current-truth, verification queue, live proof를 나누고, PlayFab 문제도 Unity 요청, 서버 응답, 실제 반영 근거를 분리해 보려 했습니다. Codex/AI도 코드 작성 결과를 그대로 성과로 삼기보다 read-only 검토, 영향 범위 제한, 근거 정리와 검증 큐 관리에 제한해 사용했습니다. 팀 원본 코드와 PlayFab 설정, 원본 로그는 public repo에 복사하지 않는 기준도 함께 세웠습니다.

개인 프로젝트 EscapeRoom은 팀 프로젝트에서 조심스럽게 표현해야 하는 부분을 코드 근거로 보강하는 경험이었습니다. GameManager와 ProgressState를 나누어 현재 행동 가능 상태와 퍼즐 진행도를 분리했고, EnemyVision에서는 거리, 각도, Raycast line-of-sight 순서로 감지 조건을 나누었습니다. 감지 결과는 DetectionController에서 FailureHandler로 이어지고, 실패 후 복귀는 CheckpointManager와 CheckpointTrigger 흐름으로 분리했습니다. Treasure Puzzle에서는 grid, path, reset, phase unlock과 퍼즐 내부 추적 적의 실패 조건을 나누어 관리했습니다. 다만 scene 연결, Play Mode, 영상 근거는 아직 확인이 필요하므로 코드 구조를 설명할 수 있는 범위로만 사용하려 합니다.

세 프로젝트에서 반복해 확인한 것은 기능 구현을 성공 경로만 보고 끝내면 안 된다는 점이었습니다. 구매 실패, 상태 불일치, 서버 응답과 실제 반영 차이, 공개 가능한 근거의 경계까지 함께 보아야 이후에 설명할 수 있는 작업이 됩니다. 이 기준은 면접 답변을 준비할 때도 그대로 이어집니다. Unity 클라이언트 개발자로 지원할 때도 기능 구현에서 멈추지 않고, 실패 경로와 검증 범위를 같이 정리하며 팀 결과물과 제 담당 범위를 분리해 설명하겠습니다.

## 2. 검토 메모

### 사용한 핵심 소재

- Coin Laundry: Inventory preview/commit 분리, Shop spend/receive/refund 흐름, merge 판정/실행 책임 분리.
- Project3 Fisher: current-truth, verification queue, live proof, PlayFab 요청/응답 분리, public evidence boundary, Codex/AI 사용 경계.
- EscapeRoom: GameState/ProgressState, EnemyVision 거리/각도/Raycast, FailureHandler/Checkpoint, Treasure Puzzle reset/phase unlock.

### 제한 표현으로 낮춘 부분

- Coin Laundry는 `담당 범위`, `설명 가능한 구조`, `근거를 정리` 수준으로 표현했다.
- Project3 Fisher는 완성작이 아니라 검증/문서화/툴링/협업 경계 관리 보조 근거로 표현했다.
- EscapeRoom은 코드 구조 설명으로 제한하고 scene, Play Mode, 영상 검증 완료 표현은 쓰지 않았다.

### 보강 필요한 근거

- Coin Laundry: 작성자/커밋, 팀 승인, Play Mode 원본 로그, EventBus 또는 이벤트 연결 코드, 시연 영상.
- Project3 Fisher: 실제 담당 범위, `.cs` 근거, CloudScript handler, Unity caller, live proof, balance workbook, UI 적용 근거.
- EscapeRoom: scene/prefab/Inspector 연결, Play Mode 또는 빌드 검증, 시연 영상, HideZone/PuzzleSafeZone/Player 이동 코드.

### 강사님께 확인받을 질문

- Coin Laundry의 Inventory/Shop 표현을 어느 정도까지 `담당 범위`로 말해도 되는가?
- Project3 Fisher를 자소서에 넣을 때 보조 근거로 충분히 자연스러운가?
- EscapeRoom을 마지막에 배치해 코드 방어 근거로 쓰는 흐름이 설득력 있는가?
- 자소서 본문에서 기술 용어와 읽히는 문장의 균형이 맞는가?
