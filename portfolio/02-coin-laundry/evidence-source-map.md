# Coin Laundry Evidence Source Map

이 문서는 팀 프로젝트 1에서 자기소개서/PPT에 사용할 수 있는 인벤토리, 상점, 재화 흐름 근거를 공개 가능한 수준으로 정리합니다.

팀 프로젝트 원본 C# 코드는 팀 공개 허가 전까지 저장소에 복사하지 않습니다. 이 문서는 면접에서 어떤 파일을 열어 설명할지 정리하는 source map입니다.

## Claims

- 인벤토리 드래그 중 preview 상태와 실제 데이터 확정 시점을 분리했습니다.
- 상점 구매 중 재화를 먼저 차감한 뒤 아이템 수령에 실패하면 환불하는 실패 경로를 고려했습니다.

## Interview Evidence

| Source File Name | Main Evidence | Use In Portfolio | Public Status |
| --- | --- | --- | --- |
| `InventoryUIController.cs` | held item, origin point, preview renderer, placement confirm | preview와 실제 데이터 commit 시점 분리 설명 | Interview only |
| `InventoryRuntimeService.cs` | purchased item receive, inventory add failure handling | 구매 아이템이 실제 inventory에 들어가는 경로 설명 | Interview only |
| `InventoryMergeService.cs` | merge 판정과 실행 책임 분리 | UI preview가 merge service를 직접 대체하지 않는 구조 설명 | Interview only |
| `ShopPurchaseService.cs` | spend gold, receive item, refund on receive failure | 구매 실패 시 재화 복구 경로 설명 | Interview only |

## STAR Mapping

| STAR Case | Situation | Task | Action | Result |
| --- | --- | --- | --- | --- |
| Inventory preview/commit split | 격자형 인벤토리에서 드래그, 회전, 배치, 합치기, 교체가 동시에 필요 | 드래그 중 화면 표시와 실제 데이터 변경 시점을 분리 | held state와 origin point를 유지하고, 배치 가능 확인 후 commit | 배치 실패 시 원래 상태로 되돌리는 설명이 가능 |
| Shop refund on purchase failure | 상점 구매가 재화와 인벤토리를 동시에 변경 | 구매 실패 시 재화만 빠지는 문제 방지 | 재화 차감, 인벤토리 수령, 실패 시 환불 순서로 처리 | 실패 경로에서 사용자 재화 상태가 깨질 위험 감소 |

## Safe Claims

- 담당한 인벤토리 UI와 상점 구매 흐름에서 preview, commit, rollback 성격의 처리를 구분했습니다.
- 구매 처리에서 재화 차감 뒤 아이템 수령 실패 시 환불하는 예외 흐름을 설명할 수 있습니다.

## Unsafe Claims

- 팀 프로젝트 인벤토리 전체를 혼자 설계/구현했다.
- 원본 팀 소스를 공개 저장소에 포함했다.
- Play Mode에서 모든 케이스를 검증 완료했다.

## Verification Boundary

이 저장소에는 공개 허가 전 팀 소스가 포함되지 않았습니다. 실제 면접에서는 로컬 Unity 프로젝트 또는 허가된 코드 화면 공유로 설명하는 방식이 안전합니다.
