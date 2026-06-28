# Project 2 - Technical Evidence

## 목적

인벤토리, 상점, 팀 프로젝트 구조에 대한 기술 근거를 정리한다.

## 현재 확정된 사실

- 기존 요약 근거 위치: `portfolio/02-coin-laundry/`.
- 현재 repo에는 `portfolio/02-coin-laundry/code/` 원본 코드 폴더가 없다.
- 공개 근거는 `README.md`, `core-file-index.md`, `evidence-source-map.md`, `_shared` 문서의 sanitized summary다.

## 직접 구현 근거

- 직접 구현으로 확정하지 않고, 현재는 직접 구현 후보와 면접 설명 가능 근거로 분리한다.

| 주제 | 문제 상황 | 구현 또는 개선한 구조 | 관련 코드 | 검증 방식 | 한계 | 면접에서 설명 가능한 수준 | 추가 보강 필요 자료 |
| --- | --- | --- | --- | --- | --- | --- | --- |
| Inventory preview/commit 분리 | 격자형 인벤토리에서 드래그, 회전, 배치, 합치기, 교체가 동시에 필요 | 드래그 중 preview와 실제 데이터 변경 시점을 분리 | `InventoryUIController.cs`, `InventoryRuntimeService.cs`, `InventoryMergeService.cs` | `evidence-source-map.md`의 STAR mapping과 core file index 기준 | 원본 코드와 Play Mode 로그는 repo에 없음 | held item, origin point, preview renderer, placement confirm의 역할을 설명 | 원본 코드, 작성자, Play Mode 검증 로그 |
| Shop refund on purchase failure | 구매가 재화와 인벤토리를 동시에 변경해 실패 시 재화만 빠질 위험 | 재화 차감, 인벤토리 수령, 실패 시 환불 순서로 설명 | `ShopPurchaseService.cs`, `InventoryRuntimeService.cs` | `core-file-index.md`, `evidence-source-map.md`, sanitized matrix 기준 | 실패 케이스 실제 재현 로그는 repo에 없음 | spend gold, receive item, refund on receive failure 흐름을 설명 | 원본 코드, 실패 재현/검증 로그 |
| Merge 책임 분리 | UI preview가 merge 판정과 실행 책임까지 떠안을 위험 | merge 판정/실행 책임을 service로 분리한 구조로 설명 | `InventoryMergeService.cs`, `InventoryUIController.cs` | core file index와 source map 기준 | 세부 메서드와 호출 흐름은 원본 코드 확인 필요 | UI와 service 책임 분리를 질문 단위로 설명 | 원본 코드, sequence 또는 call flow |
| 검증 수준 분리 | 코드 확인, 빌드 확인, Play Mode 확인이 섞이면 과장 위험 발생 | 검증 수준을 분리해서 기록하는 기준 사용 | Project2 AI work rules, Inventory/Shop baseline docs | `core-file-index.md`, `_shared/sanitized-evidence-matrix.md` 기준 | 원본 검증 로그는 repo에 없음 | 검증한 수준과 확인 필요한 수준을 구분해 답변 | Play Mode A-K 로그, 빌드 기록, 피드백 자료 |

## 팀 결과물 / 협업 근거

- 팀 프로젝트 원본 전체 소스는 공개 허가 전까지 GitHub에 복사하지 않는다.
- 현재 문서는 팀 결과물 중 본인 담당 범위로 설명 가능한 후보를 정리하는 단계다.
- 팀 공용 시스템 전체를 개인 구현으로 표현하지 않는다.

## 확인 필요

- TODO: 원본 코드 위치와 작성자/담당 범위.
- TODO: 코드 공개 가능 범위.
- TODO: 실제 실행 검증 또는 시연 자료 위치.
- TODO: Play Mode A-K 기록 또는 해당 검증 로그.
- TODO: 발표 PPT/영상에서 사용할 수 있는 장면.

## 자소서 활용 가능 포인트

- Inventory preview/commit 분리: 데이터 변경 시점을 늦춰 실패 시 복구 가능한 구조로 설명 가능.
- Shop refund 처리: 재화와 인벤토리 변경이 엮이는 실패 경로를 고려한 사례로 사용 가능.
- 검증 수준 분리: 확인한 범위와 아직 확인할 범위를 구분한 작업 태도로 사용 가능.

## 면접 예상 질문

- 인벤토리 드래그 중 preview와 실제 commit은 어떻게 나뉘는가?
- 구매 실패 시 재화 복구는 어떤 순서로 처리되는가?
- UI가 merge service를 직접 대체하지 않게 한 이유는 무엇인가?
- Play Mode 검증과 코드 확인을 어떻게 구분했는가?

## 과장 위험 / 금지 표현

- 설계서에만 있는 기능을 구현 완료처럼 표현하지 않는다.
- 팀 프로젝트 전체 인벤토리 시스템을 혼자 전부 만들었다고 말하지 않는다.
- 상점 시스템 전체를 완성했다고 말하지 않는다.
- Play Mode에서 모든 케이스를 검증 완료했다고 말하지 않는다.
