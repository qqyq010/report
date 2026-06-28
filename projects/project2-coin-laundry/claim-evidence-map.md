# Project 2 - Claim Evidence Map

## 목적

자소서와 면접에서 말할 수 있는 Project2 주장을 근거와 연결한다.

## 명칭 기준

- 현재 repo 기준 canonical name: `Coin Laundry`.
- 현재 문서 위치: `projects/project2-coin-laundry/`.
- 외부 공개 포트폴리오 근거는 `portfolio/02-coin-laundry/`에 둔다.

## Claim Evidence Map

| claim 후보 | 근거 파일 | 근거 문서 | 관련 코드 경로 | 직접 구현 여부 | 팀 결과물 여부 | 과장 위험 | 안전한 표현 | 금지 표현 | 추가 검증 필요 여부 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| 인벤토리 드래그 중 preview와 실제 데이터 확정 시점을 분리했다 | `InventoryUIController.cs`, `InventoryRuntimeService.cs`, `InventoryMergeService.cs` | `portfolio/02-coin-laundry/core-file-index.md`, `portfolio/02-coin-laundry/evidence-source-map.md`, `portfolio/_shared/sanitized-evidence-matrix.md` | 원본 코드 미포함. 면접 설명 대상 파일명만 repo 문서에 있음 | 직접 구현 후보. 원본 코드/커밋 확인 필요 | 팀 프로젝트 결과물 포함 | 중간 | 담당 범위인 인벤토리 UI 상호작용에서 preview와 commit 시점을 분리했다고 설명 가능 | 팀 인벤토리 전체를 혼자 설계/구현했다 | 원본 코드, 작성자, Play Mode 검증 로그 |
| 상점 구매 중 재화 차감 후 아이템 수령 실패 시 환불 경로를 고려했다 | `ShopPurchaseService.cs`, `InventoryRuntimeService.cs` | `portfolio/02-coin-laundry/core-file-index.md`, `portfolio/02-coin-laundry/evidence-source-map.md`, `portfolio/_shared/sanitized-evidence-matrix.md` | 원본 코드 미포함. 면접 설명 대상 파일명만 repo 문서에 있음 | 직접 구현 후보. 원본 코드/커밋 확인 필요 | 팀 프로젝트 결과물 포함 | 중간 | 담당 구매 흐름에서 실패 시 재화 복구 경로를 구현/설명할 수 있다 | 상점 시스템 전체를 완성했다 | 원본 코드, 실패 케이스 재현/검증 로그 |
| 인벤토리 merge 판정과 실행 책임을 UI preview와 분리했다 | `InventoryMergeService.cs`, `InventoryUIController.cs` | `portfolio/02-coin-laundry/core-file-index.md`, `portfolio/02-coin-laundry/evidence-source-map.md` | 원본 코드 미포함. 면접 설명 대상 파일명만 repo 문서에 있음 | 직접 구현 후보. 원본 코드/커밋 확인 필요 | 팀 프로젝트 결과물 포함 | 중간 | UI preview가 merge service를 직접 대체하지 않는 구조를 설명할 수 있다 | merge/swap/restore 전체를 혼자 완성했다 | 원본 코드, 팀 경계, 검증 자료 |
| 구매 아이템이 runtime inventory에 들어가는 경로와 실패 처리를 설명할 수 있다 | `InventoryRuntimeService.cs`, `ShopPurchaseService.cs` | `portfolio/02-coin-laundry/core-file-index.md`, `portfolio/02-coin-laundry/evidence-source-map.md` | 원본 코드 미포함. 면접 설명 대상 파일명만 repo 문서에 있음 | 확인 필요 | 팀 프로젝트 결과물 포함 | 중간 | 구매 아이템 수령과 inventory add failure handling 흐름을 근거 문서 기준으로 설명 가능 | 런타임 인벤토리 전체 구조를 직접 설계했다 | 원본 코드, 담당 범위, 실패 처리 검증 |
| 코드 확인, 빌드 확인, Play Mode 확인을 구분했다 | Project2 AI work rules, Inventory/Shop baseline docs | `portfolio/02-coin-laundry/core-file-index.md`, `portfolio/_shared/sanitized-evidence-matrix.md` | 원본 문서 미포함. sanitized summary만 있음 | 확인 필요 | 작업 규칙/검증 문서 기여 가능성 있음 | 낮음 | 코드 확인, 빌드 확인, Play Mode 확인을 구분해 기록하는 기준을 사용했다 | Codex가 Play Mode를 직접 검증했다 | 실제 로그 원본, 검증 항목 A-K 자료 |
| 팀 프로젝트 원본 코드는 공개하지 않고 sanitized summary로 관리했다 | `publication-policy.md`, `sanitized-evidence-matrix.md` | `portfolio/_shared/publication-policy.md`, `portfolio/_shared/sanitized-evidence-matrix.md` | 해당 없음 | 구현 claim 아님 | repo 운영/공개 정책 | 낮음 | 팀 소스는 공개 허가 전까지 면접 전용으로 두고 GitHub에는 요약과 인덱스만 둔다 | 팀 소스 전체를 공개해도 된다 | 팀 공개 허가 상태 |

## 작성 기준

- 주장은 코드, 문서, 검증 로그 중 최소 하나와 연결한다.
- 직접 구현과 팀 결과물을 분리한다.
- 과장 위험이 있으면 안전한 표현으로 낮춘다.
- 검증되지 않은 항목은 자소서 완성 문장으로 옮기지 않는다.
