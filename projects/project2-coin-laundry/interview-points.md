# Project 2 - Interview Points

## 목적

면접에서 팀 프로젝트 1을 설명할 때 사용할 질문과 근거를 정리한다.

## 현재 확정된 사실

- Project2 canonical name은 `Coin Laundry`.
- 공개 근거는 `portfolio/02-coin-laundry/`의 sanitized summary와 `_shared` 문서다.
- 원본 `.cs` 파일은 현재 repo에 포함되어 있지 않다.

## 직접 구현 근거

- 직접 구현으로 확정하기 전, 아래 질문은 `직접 구현 후보` 또는 `면접 설명 가능 후보`로만 사용한다.

## 팀 결과물 / 협업 근거

- 팀 프로젝트 원본 전체, 팀 공용 시스템, 전체 QA는 개인 단독 성과로 말하지 않는다.
- 본인 담당 범위와 팀 결과물을 나눠 답변한다.

## 면접 예상 질문

### 방어 가능한 질문

| 축 | 예상 질문 | 답변에 사용할 근거 | 설명 가능한 코드/문서 경로 | 답변 시 강조점 | 답변 시 피해야 할 표현 | 추가로 확인해야 할 것 |
| --- | --- | --- | --- | --- | --- | --- |
| Inventory 구조 | 인벤토리 드래그 중 preview와 실제 데이터 commit은 어떤 기준으로 나뉘는가? | preview/commit 분리 claim | `portfolio/02-coin-laundry/evidence-source-map.md`, `projects/project2-coin-laundry/technical-evidence.md` | 화면 표시와 실제 데이터 변경 시점을 분리한 이유 | 인벤토리 전체를 혼자 설계했다 | 원본 코드와 Play Mode 검증 로그 |
| Shop 구조 | 구매 시 골드 차감, 인벤토리 수령, 실패 시 환불 순서는 어떻게 설명할 수 있는가? | Shop refund claim | `portfolio/_shared/sanitized-evidence-matrix.md`, `claim-evidence-map.md` | 실패 경로에서 재화 상태가 깨지지 않게 한 흐름 | 상점 시스템 전체를 완성했다 | 실패 케이스 재현/검증 로그 |
| UI 연동 | UI preview가 실제 runtime inventory를 언제 변경하는가? | `InventoryUIController.cs`, `InventoryRuntimeService.cs` 문서상 파일명 | `source-file-map.md`, `core-file-index.md` | UI 표시와 runtime 반영의 책임 분리 | UI 전체 구조를 다 구현했다 | 실제 호출 순서 |
| 검증 방식 | 코드 확인, 빌드 확인, Play Mode 확인을 어떻게 구분했는가? | Project2 AI work rules, baseline docs 언급 | `core-file-index.md`, `sanitized-evidence-matrix.md` | 확인한 수준과 미확인 수준을 분리해 말하기 | Codex가 Play Mode를 직접 검증했다 | Play Mode A-K 원본 기록 |
| 팀 협업 | 팀 소스 공개 허가 전까지 어떤 방식으로 면접에서 설명할 것인가? | publication policy | `portfolio/_shared/publication-policy.md`, `README.md` | 원본 팀 소스 대신 요약/인덱스/로컬 설명 사용 | 팀 소스를 공개해도 된다 | 팀 공개 허가 여부 |

### 추가 확인 필요 질문

| 축 | 예상 질문 | 현재 상태 | 추가 확인해야 할 것 |
| --- | --- | --- | --- |
| EventBus 또는 이벤트 흐름 | EventBus 구조를 어떻게 사용했는가? | 현재 repo 근거에는 EventBus 코드 파일명이 없음 | EventBus 관련 `.cs` 파일 또는 문서 |
| 디버깅/버그 수정 | 실제 어떤 버그를 어떻게 고쳤는가? | 환불/배치 실패 시나리오는 문서상 claim 후보 | 버그 수정 전후 로그, 커밋, 재현 절차 |
| 런타임 상태 관리 | 구매 아이템이 runtime inventory에 들어가는 경로는 무엇인가? | `InventoryRuntimeService.cs`가 문서상 언급됨 | 원본 코드, 호출 흐름, 실패 처리 검증 |

### 위험 질문

| 위험 질문 | 위험한 이유 | 안전한 대응 방향 |
| --- | --- | --- |
| 이 전체 구조를 혼자 설계했나요? | 팀 프로젝트 전체 성과를 개인 구현처럼 보이게 할 수 있음 | 담당 범위와 팀 공용 시스템을 분리해 답변 |
| 팀원의 코드는 어디까지 관여했나요? | 소유권 경계가 불명확하면 과장 위험 | 원본 코드/담당표 확인 전에는 확인 필요로 답변 |
| 실제 빌드에서 검증했나요? | 현재 repo에는 빌드/Play Mode 원본 로그가 없음 | 코드 확인, 문서 확인, Play Mode 확인을 분리 |
| 상용 수준으로 완성됐나요? | 근거 없는 완성도 주장 | 포트폴리오 근거와 면접 설명 가능한 범위로 제한 |
| QA를 담당한 건가요, 개발 검증을 한 건가요? | 전체 QA 담당으로 오해될 수 있음 | 개발 중 확인한 검증 범위로 제한 |

## 과장 위험 / 금지 표현

- 본인이 확인하지 못한 팀 전체 구조를 상세히 구현한 것처럼 말하지 않는다.
- 원본 코드가 repo에 없으므로 코드 세부 구현은 로컬/허가된 자료 확인 후 답변한다.
