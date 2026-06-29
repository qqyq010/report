# Final Self Introduction

## 1. 제출용 자소서

부트캠프에서 Unity/C# 프로젝트를 진행하며 기능을 빨리 붙이는 것보다 먼저 확인해야 할 기준이 있다는 것을 체감했습니다. 팀 프로젝트에서는 하나의 기능처럼 보이는 작업도 UI 입력, 실제 상태 변경, 실패 복구, 검증 수준이 함께 얽혔습니다. 화면에서 정상처럼 보여도 runtime state가 맞지 않거나, 코드 확인과 Play Mode 확인을 같은 말로 섞으면 이후에 설명하기 어려운 문제가 됩니다. 그래서 프로젝트를 정리할 때도 무엇을 만들었는지보다 어떤 책임을 어디서 끊고, 어떤 근거로 확인했는지를 먼저 보았습니다.

팀프로젝트1 Coin Laundry에서는 Inventory와 Shop 흐름을 중심으로 이 문제를 다뤘습니다. 인벤토리는 아이템을 잡고 움직이는 preview 상태와 실제 데이터가 바뀌는 commit 상태가 섞이기 쉬웠고, 상점 구매는 골드 차감과 아이템 수령이 함께 일어나 receive 실패 시 refund 경로를 따로 보아야 했습니다. 특히 UI에 보이는 위치를 곧바로 확정 데이터처럼 다루면 배치 실패 뒤 복구 위치와 실제 인벤토리 반영 시점이 흐려질 수 있다고 보았습니다. merge도 UI가 모든 판단을 처리하면 판정과 실행 책임이 섞일 수 있어 service 기준으로 나누어 설명할 수 있게 정리했습니다. 다만 이 부분은 팀 프로젝트 자료이므로 전체 인벤토리/상점 시스템을 단독 구현했다고 쓰지 않고, 담당 범위 후보와 문서 근거 기준으로 설명 가능한 구조만 분리했습니다.

Project3 Fisher에서는 같은 인벤토리/상점/데이터 계열 문제가 더 큰 협업 구조와 서버 경계에서 나타났습니다. 이 프로젝트는 완성작으로 내세우기보다 검증, 문서화, 툴링, 협업 경계 관리의 보조 근거로 정리했습니다. Fisher/CSH, PlayFab, CloudScript, 밸런스, UI 리소스가 연결되면 코드만 수정해서는 원인을 확정하기 어렵습니다. 팀 규모가 커질수록 수정한 코드, 서버 응답, 실제 반영 여부가 서로 다른 속도로 확인되므로 검증 수준을 섞지 않는 기준이 필요했습니다. 그래서 current-truth, verification queue, live proof를 나누고, PlayFab 문제도 Unity 요청, 서버 응답, 실제 반영 근거를 분리해 보려 했습니다. Codex/AI는 구현 성과를 대신하는 도구가 아니라 read-only 검토, 영향 범위 제한, 근거 정리와 검증 큐 관리 보조로 제한해 사용했습니다.

개인 프로젝트 EscapeRoom은 팀 프로젝트에서 조심스럽게 표현해야 하는 부분을 Unity/C# 코드 근거로 보강하는 사례입니다. GameManager와 ProgressState를 나누어 현재 행동 가능 상태와 퍼즐 진행도를 분리했고, EnemyVision에서는 거리, 각도, Raycast line-of-sight 순서로 감지 조건을 나누었습니다. 감지 결과는 DetectionController에서 FailureHandler로 이어지고, 실패 후 복귀는 CheckpointManager와 CheckpointTrigger 흐름으로 분리했습니다. Treasure Puzzle에서는 grid, path, reset, phase unlock과 퍼즐 내부 추적 적의 실패 조건을 나누어 관리했습니다. 이 부분은 적 감지, 실패 처리, 복귀, 퍼즐 진행을 각각 다른 코드 경로로 설명할 수 있어 방어 근거가 됩니다. 다만 scene 연결, Play Mode, 영상 근거는 아직 확인이 필요하므로 코드 구조를 설명할 수 있는 범위로만 사용합니다.

세 프로젝트를 정리하며 기능 구현은 성공 경로만으로 끝나지 않는다는 기준을 세웠습니다. 구매 실패, 상태 불일치, 서버 응답과 실제 반영 차이, 근거 공개 범위까지 보아야 면접에서도 설명 가능한 작업이 됩니다. 그래서 제출 자료도 결과만 나열하기보다 확인한 것과 남은 것을 함께 적는 방식으로 정리했습니다. 앞으로도 Unity 클라이언트 개발자로 기능을 구현할 때 실패 경로와 검증 범위를 함께 정리하고, 팀 결과물과 제 담당 범위를 분리해 설명하겠습니다.

## 2. 검토 메모

### 글자 수

* 공백 포함: 1997
* 공백 제외: 1572

### 사용한 소재

* Coin Laundry: Inventory/Shop 흐름, preview/commit 분리, spend/receive/refund 흐름, merge 판정/실행 책임 분리.
* Project3 Fisher: current-truth, verification queue, live proof, public evidence boundary, Codex/AI 사용 경계.
* EscapeRoom: GameState/ProgressState, EnemyVision 거리/각도/Raycast, FailureHandler/Checkpoint, Treasure Puzzle.

### 제한 표현으로 낮춘 부분

* Coin Laundry는 직접 구현 확정이 아니라 담당 범위 후보와 설명 가능한 구조로 표현했다.
* Project3 Fisher는 완성작이 아니라 검증/문서화/툴링/협업 경계 보조 근거로 표현했다.
* EscapeRoom은 코드 구조 설명으로 제한하고 scene, Play Mode, 영상 검증 완료 표현은 쓰지 않았다.

### 제출 전 확인 필요

* Coin Laundry: 작성자/커밋, 팀 승인, Play Mode 원본 로그, EventBus 또는 이벤트 연결 코드, 시연 영상.
* Project3 Fisher: 실제 담당 범위, `.cs` 근거, CloudScript handler, Unity caller, live proof, balance workbook, UI 적용 근거.
* EscapeRoom: scene/prefab/Inspector 연결, Play Mode 또는 빌드 검증, 시연 영상, HideZone/PuzzleSafeZone/Player 이동 코드.
