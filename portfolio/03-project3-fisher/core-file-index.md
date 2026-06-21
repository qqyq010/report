# Project3 Fisher Core File Index

## Files To Explain In Interview

| File | Evidence Level | What To Explain | Public Status |
| --- | --- | --- | --- |
| `InventoryService.cs` | Code Evidence | inventory snapshot, stack count, validation, capacity/overflow handling | Interview only until team approval |
| `ShopService.cs` | Code Evidence | shop item validation, reward apply, refund on reward failure | Interview only until team approval |
| `FisherPlayerDataBridge.cs` | Code Evidence | PlayFab gateway request, mutation result handling, rejected mutation refresh | Interview only until team approval |
| `ShopPanelAdapter.cs` | Code Evidence | server-authority purchase UI, pending state, timeout/failure recovery | Interview only until team approval |
| `BagPanelAdapter.cs` | Code Evidence | sell/use-box request and pending state handling | Interview only until team approval |
| `CookingPanelAdapter.cs` | Code Evidence | cooking request, speed-up request, UI recovery | Interview only until team approval |
| `docs/current` current-truth docs | Document Evidence | 현재 기준, 미검증 항목, team ownership 분리 | Sanitized summary only |
| `docs/handoff` verification queue | Document Evidence | Play Mode/live proof queue | Sanitized summary only |
| `tools/checker/validator` | Tool Evidence | markdown, token, balance, data contract local checks | Public summary or sanitized scripts |

## Safe Claims

- PlayFab 연동 경계에서 클라이언트 요청, 서버 결과 반영, 실패 복구 흐름을 분리했습니다.
- live PlayFab 성공 여부는 코드 구현과 별개로 검증 큐에 남겼습니다.
- BM/gacha/package는 후보와 보류 조건을 문서화했으며, 실행 완료로 말하지 않습니다.

## Unsafe Claims

- PlayFab 연동을 완료했다.
- BM을 구현했다.
- 서버/CloudScript/TitleData까지 모두 검증했다.
- 팀 전체 Fisher 시스템을 혼자 구현했다.
