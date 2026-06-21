# Sanitized Evidence Matrix

이 문서는 자기소개서, PPT, GitHub README에서 사용할 수 있는 주장을 공개 가능한 근거와 비공개 검토 근거로 나눈 표입니다.

원본 팀 프로젝트 소스, 내부 회의 원문, raw transcript, PlayFab 설정, 팀원 정보는 공개 저장소에 올리지 않습니다. 공개 저장소에는 개인 프로젝트 코드, 공개 가능한 요약, 면접에서 열어 설명할 파일 인덱스만 둡니다.

## Evidence Matrix

| STAR Case | Claim | Evidence Level | Public Proof | Private Or Interview Proof | Public Status | Risky Wording | Safer Wording |
| --- | --- | --- | --- | --- | --- | --- | --- |
| EscapeRoom 상태/감지/실패 복귀 | 감지, 실패 처리, 체크포인트 복귀, 퍼즐 진행도를 분리해서 구현했다. | Code Evidence | `portfolio/01-escape-room/code` and `portfolio/01-escape-room/evidence-source-map.md` | 개인 프로젝트 원본 Unity 백업 | Public | 모든 런타임 상황을 검증했다. | 코드상 상태/감지/실패 복귀 구조를 분리했고, 공개 코드로 설명 가능하다. |
| Coin Laundry 인벤토리 preview/확정 분리 | 드래그 중 preview와 실제 인벤토리 데이터 확정 시점을 분리했다. | Code Evidence | `portfolio/02-coin-laundry/core-file-index.md` and `portfolio/02-coin-laundry/evidence-source-map.md` | `InventoryUIController.cs`, `InventoryRuntimeService.cs`, `InventoryMergeService.cs` | Sanitized summary only | 팀 인벤토리 전체를 혼자 만들었다. | 담당 범위인 인벤토리 UI 상호작용에서 preview와 commit 시점을 분리했다. |
| Coin Laundry 상점 환불 처리 | 구매 중 재화 차감 후 아이템 수령 실패 시 환불 경로를 고려했다. | Code Evidence | `portfolio/02-coin-laundry/core-file-index.md` and `portfolio/02-coin-laundry/evidence-source-map.md` | `ShopPurchaseService.cs`, `InventoryRuntimeService.cs` | Sanitized summary only | 상점 시스템 전체를 완성했다. | 담당 구매 흐름에서 실패 시 재화 복구 경로를 구현/설명할 수 있다. |
| Project3/Fisher PlayFab 요청/응답/검증 상태 분리 | 클라이언트 요청, 서버 응답 반영, 거절/타임아웃 복구, live proof 대기를 분리했다. | Code + Document Evidence | `portfolio/03-project3-fisher/core-file-index.md`, `portfolio/03-project3-fisher/tools-and-verification.md`, `portfolio/03-project3-fisher/evidence-source-map.md` | Fisher CSH runtime source and current-truth docs | Sanitized summary only | PlayFab 연동을 완료했다. | 코드상 요청/응답 경로와 검증 큐를 분리했고, live Play Mode 검증은 별도 상태로 남겼다. |
| AI/Codex + Obsidian evidence workflow | AI를 코드 생성보다 코드베이스 분석, 영향 범위 제한, 검증 큐, evidence 관리에 사용했다. | Document + Tool Evidence | `portfolio/03-project3-fisher/ai-assisted-workflow.md`, `portfolio/03-project3-fisher/tools-and-verification.md` | Project3 AGENTS, current-truth, handoff, evidence logs, tool outputs | Public summary / sanitized docs | AI로 프로젝트 운영을 자동화했다. | Codex와 Markdown evidence 관리 방식을 반복 적용해 작업 기준과 검증 상태를 분리했다. |

## Publication Rules

- 개인 프로젝트 코드는 공개 가능 범위로 복사해 둡니다.
- 팀 프로젝트 1, 2의 원본 코드는 팀 공개 허가 전까지 공개하지 않습니다.
- 내부 문서는 공개용 요약으로만 변환합니다.
- 로컬 절대 경로, 계정명, API 키, PlayFab 설정, raw transcript는 공개하지 않습니다.
- 코드 존재, 문서상 설계, 빌드 확인, Unity Play Mode 확인, live 서버 확인을 같은 표현으로 섞지 않습니다.

## Resume/PPT Safe Core

- 상태와 데이터 흐름을 분리해서 문제를 확인했다.
- 실패했을 때 재화, 인벤토리, UI 상태가 어떻게 남는지 확인했다.
- AI/Codex를 로컬 코드 추적, 영향 범위 제한, 검증 상태 정리에 사용했다.
- 팀원 담당 영역, 서버/live 검증, 민감 정보는 공개/수정 범위에서 분리했다.
