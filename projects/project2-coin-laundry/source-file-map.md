# Project 2 - Source File Map

## 목적

Project2 코드 파일별 공개 가능 여부와 자소서/면접 활용 가능성을 정리한다.

## 명칭 기준

- 현재 repo 기준 canonical name: `Coin Laundry`.
- 현재 문서 위치: `projects/project2-coin-laundry/`.
- 외부 공개 포트폴리오 근거는 `portfolio/02-coin-laundry/`에 둔다.

## Source File Map

| 파일명 | repo 내 경로 | 역할 | 관련 기능 | 본인 직접 구현 여부 | 팀 코드 포함 여부 | 공개 가능 여부 | 민감정보 포함 여부 | 자소서 활용 가능 여부 | 면접 질문 가능성 | 확인 필요 사항 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| `InventoryUIController.cs` | 원본 코드 미포함. 근거: `portfolio/02-coin-laundry/core-file-index.md`, `portfolio/02-coin-laundry/evidence-source-map.md` | 인벤토리 UI 상호작용 설명 대상 | held item, rotation, preview, placement confirm | 직접 구현 후보. 원본 코드/커밋 확인 필요 | 팀 코드 포함 가능성 있음 | Interview only until team approval | 현재 repo 문서 기준 민감정보 없음. 원본 코드 확인 필요 | 가능. preview와 commit 분리 소재 | 높음 | 원본 위치, 작성자, 공개 가능 범위, 실제 Play Mode 검증 여부 |
| `InventoryRuntimeService.cs` | 원본 코드 미포함. 근거: `portfolio/02-coin-laundry/core-file-index.md`, `portfolio/02-coin-laundry/evidence-source-map.md` | 런타임 인벤토리 반영 설명 대상 | purchased item receive, inventory add failure handling | 직접 구현 후보. 원본 코드/커밋 확인 필요 | 팀 코드 포함 가능성 있음 | Interview only until team approval | 현재 repo 문서 기준 민감정보 없음. 원본 코드 확인 필요 | 가능. 구매 아이템 수령 흐름 소재 | 높음 | 원본 위치, 작성자, 실패 처리 검증 로그 |
| `InventoryMergeService.cs` | 원본 코드 미포함. 근거: `portfolio/02-coin-laundry/core-file-index.md`, `portfolio/02-coin-laundry/evidence-source-map.md` | merge 책임 분리 설명 대상 | merge 판정과 실행 책임 분리 | 직접 구현 후보. 원본 코드/커밋 확인 필요 | 팀 코드 포함 가능성 있음 | Interview only until team approval | 현재 repo 문서 기준 민감정보 없음. 원본 코드 확인 필요 | 가능. UI와 service 책임 분리 소재 | 중간 | 실제 담당 범위, merge/swap/restore 검증 범위 |
| `ShopPurchaseService.cs` | 원본 코드 미포함. 근거: `portfolio/02-coin-laundry/core-file-index.md`, `portfolio/02-coin-laundry/evidence-source-map.md` | 상점 구매 트랜잭션 설명 대상 | spend gold, receive item, refund on receive failure | 직접 구현 후보. 원본 코드/커밋 확인 필요 | 팀 코드 포함 가능성 있음 | Interview only until team approval | 현재 repo 문서 기준 민감정보 없음. 원본 코드 확인 필요 | 가능. 구매 실패 시 환불 경로 소재 | 높음 | 원본 위치, 작성자, 환불 경로 검증 로그 |
| `portfolio/02-coin-laundry/README.md` | `portfolio/02-coin-laundry/README.md` | 공개용 Project2 요약 | 담당 범위, public scope, core responsibilities | 문서 근거. 구현 직접성은 별도 확인 필요 | 팀 프로젝트 설명 포함 | Public sanitized summary | 민감정보 없음으로 보임 | 가능. 전체 맥락 요약 | 중간 | 문서 작성 근거와 최신성 |
| `portfolio/02-coin-laundry/core-file-index.md` | `portfolio/02-coin-laundry/core-file-index.md` | 면접 설명 파일 인덱스 | 핵심 파일명, safe/unsafe claims | 문서 근거. 구현 직접성은 별도 확인 필요 | 팀 프로젝트 설명 포함 | Sanitized summary only | 민감정보 없음으로 보임 | 가능. claim boundary 근거 | 높음 | 원본 코드 접근 가능 여부, 팀 공개 허가 |
| `portfolio/02-coin-laundry/evidence-source-map.md` | `portfolio/02-coin-laundry/evidence-source-map.md` | claim과 source file 연결 | preview/commit, refund, STAR mapping | 문서 근거. 구현 직접성은 별도 확인 필요 | 팀 프로젝트 설명 포함 | Sanitized summary only | 민감정보 없음으로 보임 | 가능. 자소서/면접 claim 후보 근거 | 높음 | STAR mapping의 실제 검증 자료 |
| `portfolio/_shared/publication-policy.md` | `portfolio/_shared/publication-policy.md` | 공개/비공개 기준 | 팀 소스, 인터뷰 전용, private 범위 | 구현 근거 아님 | repo 전체 정책 | Public | 민감정보 없음으로 보임 | 간접 활용. 공개 범위 방어 | 중간 | 팀 허가 기준의 최신성 |
| `portfolio/_shared/sanitized-evidence-matrix.md` | `portfolio/_shared/sanitized-evidence-matrix.md` | 공개 가능한 주장과 위험 표현 매트릭스 | Coin Laundry preview/commit, shop refund | 문서 근거. 구현 직접성은 별도 확인 필요 | 팀 프로젝트 설명 포함 | Sanitized summary only | 민감정보 없음으로 보임 | 가능. 안전 표현 근거 | 높음 | private/interview proof와 실제 원본 자료 연결 |

## 작성 기준

- 원본 팀 코드 전체를 GitHub에 복사하지 않는다.
- 공개 가능한 일부 코드 또는 요약만 선별한다.
- 확인되지 않은 구현 여부는 `확인 필요`로 남긴다.
- 현재 repo에는 `portfolio/02-coin-laundry/code/`가 없으므로, 코드 파일명은 공개 문서에 언급된 면접 설명 대상 기준으로만 사용한다.
