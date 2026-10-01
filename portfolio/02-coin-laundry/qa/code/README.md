# 관련 코드 발췌

사례와 연결되는 현재 Unity C# 구현을 발췌했습니다.

| 코드 | 연결되는 사례 | 내용 |
|---|---|---|
| [무기 판매 처리](weapon-sale.cs.txt) | [판매 후 공격 잔존](../cases/04-weapon-sale.md) | 판매한 아이템의 ID·레벨을 실제 무기 제거 이벤트에 전달 |
| [획득 반경 계산](magnet-range.cs.txt) | [자석 체감 개선](../cases/01-magnet.md) | 기본 반경에 로비 업그레이드 비율 적용 |
| [상점 진입 판단](shop-entry.cs.txt) | [구매·성장 흐름](../cases/03-economy.md) | 진행 목표·진입 비용·진입 후 잔여 골드 확인 |

판매 처리는 2026년 10월 1일 `InventoryUiService.cs`에서, 나머지 두 발췌는 9월 30일 `PlayerStatManager.cs`와 `PlayerLevelManager.cs`에서 가져왔습니다. 현재 구현을 보여주는 자료이며 당시 수정 전후 diff는 아닙니다.
