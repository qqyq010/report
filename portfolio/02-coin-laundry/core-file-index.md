# 상점과 인벤토리의 주요 처리

| 처리 | 관련 파일 | 살펴본 내용 |
|---|---|---|
| 아이템 구매 | `ShopPurchaseService.cs` | 골드 차감, 아이템 수령, 수령 실패 시 환불 |
| 드래그·회전·배치 | `InventoryUIController.cs` | 이동 중 표시와 실제 배치 확정 시점 |
| 인벤토리 반영 | `InventoryRuntimeService.cs` | 구매한 아이템을 가방에 넣는 처리 |
| 합성 | `InventoryMergeService.cs` | 합성 조건과 실행 흐름 |

## 이번 QA 자료와 연결되는 코드

- [획득 반경 계산](qa/code/magnet-range.cs.txt): 자석 업그레이드 비율 적용
- [상점 진입 판단](qa/code/shop-entry.cs.txt): 누적 골드, 진입 비용과 남는 골드 확인
- [코드 설명](qa/code/README.md)

[프로젝트 소개](README.md)
