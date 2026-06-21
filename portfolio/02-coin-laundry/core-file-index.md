# Coin Laundry Core File Index

## Files To Explain In Interview

| File | Evidence Level | What To Explain | Public Status |
| --- | --- | --- | --- |
| `ShopPurchaseService.cs` | Code Evidence | 구매 트랜잭션, 골드 차감 후 인벤토리 수령 실패 시 환불 | Interview only until team approval |
| `InventoryUIController.cs` | Code Evidence | held item, rotation, preview, placement confirm 분리 | Interview only until team approval |
| `InventoryRuntimeService.cs` | Code Evidence | 구매 아이템 수령, runtime inventory 반영 | Interview only until team approval |
| `InventoryMergeService.cs` | Code Evidence | merge 판정과 실행 책임 분리 | Interview only until team approval |
| Project2 AI work rules | Document Evidence | GPT/Codex 역할 분리, Play Mode와 build 검증 분리 | Sanitized summary only |
| Inventory/Shop baseline docs | Document/Log Evidence | 담당 범위와 Play Mode A-K 기록 | Sanitized summary only |

## Safe Claims

- 상점 구매 과정에서 재화 차감 후 인벤토리 수령 실패 시 환불하는 실패 경로를 고려했습니다.
- 인벤토리 UI preview와 실제 데이터 확정 시점을 분리했습니다.
- Codex/GPT 작업 규칙을 통해 코드 확인, 빌드 확인, Play Mode 확인을 구분했습니다.

## Unsafe Claims

- 팀 프로젝트 전체 인벤토리 시스템을 혼자 전부 만들었다.
- Codex가 Play Mode를 직접 검증했다.
- 팀 소스 전체를 공개해도 된다.

## GitHub Strategy

공개 저장소에는 원본 팀 소스 대신 이 인덱스와 면접 설명 포인트를 둡니다.
팀 공개 허가가 확인되면 핵심 메서드 일부만 별도 excerpt로 추가합니다.
