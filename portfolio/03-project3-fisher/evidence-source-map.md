# Project3 Fisher Evidence Source Map

이 문서는 팀 프로젝트 2 Project3/Fisher에서 자기소개서, PPT, GitHub README에 사용할 수 있는 코드/문서/검증 근거를 공개 가능한 수준으로 정리합니다.

팀 원본 소스, 내부 current-truth 원문, 회의 원문, raw transcript, PlayFab 설정은 공개 저장소에 복사하지 않습니다.

## Claims

- PlayFab 관련 클라이언트 요청, 서버 응답 반영, 거절/타임아웃 복구, live proof 대기를 구분했습니다.
- 코드상 구현, 문서상 설계, Build Evidence, Play Mode Evidence, Live Evidence를 섞지 않도록 관리했습니다.
- BM/gacha/package는 후보와 보류 조건을 분리했고, 구현 완료로 표현하지 않습니다.
- AI/Codex를 코드베이스 분석, 영향 범위 제한, current-truth, verification queue, evidence 관리에 사용했습니다.

## Code Evidence For Interview

| Source File Name | Main Evidence | Portfolio Use | Public Status |
| --- | --- | --- | --- |
| `InventoryService.cs` | snapshot, stack count, capacity/overflow, currency validation | 인벤토리 데이터 변경과 실패 조건 설명 | Interview only |
| `ShopService.cs` | purchase validation, reward apply, refund on reward failure | 상점 구매 실패 처리 설명 | Interview only |
| `FisherPlayerDataBridge.cs` | request gateway, PlayFab mutation request, result handling, rejected mutation refresh | PlayFab 요청/응답/검증 상태 분리 설명 | Interview only |
| `ShopPanelAdapter.cs` | UI request, pending state, rejected handler, timeout handling | 화면에서 결과를 먼저 확정하지 않는 흐름 설명 | Interview only |
| `BagPanelAdapter.cs` | sell/use-box request and pending-state flow | 가방 기능의 서버 요청 경계 설명 | Interview only |
| `CookingPanelAdapter.cs` | cooking/speed-up request and UI recovery | 서버 응답 전후 UI 복구 흐름 설명 | Interview only |

## Document Evidence For Portfolio

| Document Type | Main Evidence | Public Use | Public Status |
| --- | --- | --- | --- |
| Current-truth docs | live PlayFab proof, Play Mode proof, server/team blockers 분리 | 검증 상태 분리 사례 | Sanitized summary only |
| Completion bundle docs | 코드상 구현과 live 검증 미완료 항목 분리 | "완료" 표현의 기준 설명 | Sanitized summary only |
| Gacha/package decision packet | enabled=false, server-blocked, execution hold | BM을 구현 완료가 아닌 후보/보류 상태로 표현 | Sanitized summary only |
| AGENTS / start-here workflow | rough instruction intake, safety gate, logging, evidence management | AI-assisted workflow 설명 | Sanitized summary only |
| Operating/current docs | logs as evidence, current-truth first, build vs Play Mode separation | Obsidian/Markdown evidence 관리 설명 | Sanitized summary only |
| AI review intake | GPT/Gemini/Codex 결과를 sensor로 보고 반영/보류 분류 | 외부 AI 상호검토 설명 | Sanitized summary only |

## STAR Mapping

| STAR Case | Situation | Task | Action | Result |
| --- | --- | --- | --- | --- |
| PlayFab request/response/verification split | 팀 프로젝트 2에서 클라이언트 UI와 PlayFab 서버 요청 경계가 생김 | 화면 상태를 서버 결과보다 먼저 확정하지 않도록 흐름 분리 | gateway, adapter, service, rejected refresh, timeout 경로를 나눠 확인 | 코드상 경로와 live proof 미완료 상태를 구분해서 설명 가능 |
| AI/Codex + evidence workflow | 프로젝트 문서, 코드, 회의, 외부 AI 검토가 함께 쌓임 | 현재 기준과 과거 로그, 반영/보류 판단을 분리 | current-truth, evidence logs, verification queue, tool/checker 흐름으로 관리 | 자기소개서/PPT/GitHub에서 같은 주장을 같은 근거로 연결 가능 |

## BM And Gacha Boundary

| Topic | Safe Status |
| --- | --- |
| BM/gacha/package | 후보, decision packet, 비활성/보류 조건으로만 설명 |
| Live purchase/gacha execution | 공개 자기소개서에서 완료 표현 금지 |
| Server/CloudScript/TitleData | 팀/서버 검증 전까지 본인 완료 업무로 표현 금지 |

## Verification Boundary

- 코드상 요청/응답 경로가 존재해도 live PlayFab 검증 완료와 동일하지 않습니다.
- build/self-test 통과는 Unity Play Mode 또는 live server proof와 다릅니다.
- GitHub에는 공개 가능한 요약과 설명 구조만 둡니다.
- 면접에서는 허가된 범위에서 로컬 코드 화면을 열어 메서드 흐름을 설명하는 방식이 안전합니다.
