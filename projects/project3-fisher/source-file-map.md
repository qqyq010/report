# Project 3 - Source File Map

## 목적

Project3 Fisher 보조 근거로 사용할 수 있는 문서/파일 후보를 공개 가능 범위와 확인 필요 항목으로 나눈다.
현재 repo 기준 실제 `.cs` 코드 근거는 없으며, 원본 팀 소스와 PlayFab 설정은 GitHub에 복사하지 않는다.

## 기준

- Canonical name: `Project3 Fisher`
- 프로젝트 유형: 팀 프로젝트 2
- 사용 위치: 자소서/면접용 보조 근거
- 공개 포트폴리오 근거: `portfolio/03-project3-fisher/`
- working area: `projects/project3-fisher/`

## Source File Map

| 문서/파일명 | repo 내 경로 | 관련 소재 | 자료 유형 | 활용 가능성 | 직접 구현 여부 | 팀 결과물 여부 | 공개 가능 여부 | 민감정보 가능성 | 자소서 활용 가능성 | 면접 질문 가능성 | 확인 필요 사항 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| `README.md` | `portfolio/03-project3-fisher/README.md` | Fisher/CSH, PlayFab 경계, verification queue | 공개 요약 문서 | 보조 근거 가능 | 직접 구현 근거 아님 | 팀 프로젝트 설명 포함 | 공개 가능 | 낮음 | 가능. 보조 근거 포지셔닝 | 높음 | 실제 담당 범위 |
| `ai-assisted-workflow.md` | `portfolio/03-project3-fisher/ai-assisted-workflow.md` | AI/Codex workflow, current-truth, 검증 큐 | 공개 요약 문서 | 바로 사용 가능 후보 | 구현 claim 아님 | 협업/운영 방식 | 공개 가능 | 낮음 | 가능. 작업 방식 소재 | 높음 | 실제 반영 사례 |
| `core-file-index.md` | `portfolio/03-project3-fisher/core-file-index.md` | Inventory, Shop, Bridge, Adapter 후보 | 파일 인덱스 | 면접 준비 후보 | 확인 필요 | 팀 코드 포함 | 요약 공개 가능, 코드 원본은 제한 | 중간 | 제한 표현으로 가능 | 높음 | 팀 승인, sanitized excerpt |
| `evidence-source-map.md` | `portfolio/03-project3-fisher/evidence-source-map.md` | request/response/live proof 분리 | 공개 요약 문서 | 바로 사용 가능 후보 | 구현 claim 아님 | 팀 결과물 설명 포함 | 공개 가능 | 낮음 | 가능. 검증 분리 소재 | 높음 | 실제 로그/코드 연결 |
| `tools-and-verification.md` | `portfolio/03-project3-fisher/tools-and-verification.md` | verification labels, local tools | 공개 요약 문서 | 바로 사용 가능 후보 | 구현 claim 아님 | 운영 방식 | 공개 가능 | 낮음 | 가능. 검증 태도 소재 | 높음 | 실제 실행 로그 |
| `balance-evidence.md` | `projects/project3-fisher/balance-evidence.md` | workbook, validator, simulator, CSV/JSON | working doc | 근거 보강 후 사용 | 확인 필요 | 팀 기준 포함 가능 | 공개 가능 요약 | 중간 | 제한 표현 가능 | 중간 | workbook, validator log |
| `cloudscript-evidence.md` | `projects/project3-fisher/cloudscript-evidence.md` | CloudScript, PlayFab, request/response | working doc | 근거 보강 후 사용 | 확인 필요 | 팀 서버 계약 포함 | 공개 가능 요약 | 높음 | 제한 표현 가능 | 높음 | handler, caller, live proof |
| `ui-art-pipeline-evidence.md` | `projects/project3-fisher/ui-art-pipeline-evidence.md` | UI 리소스, sprite, AI image, handoff | working doc | 근거 보강 후 사용 | 확인 필요 | 팀/AI 산출물 포함 | 공개 가능 요약 | 중간 | 제한 표현 가능 | 중간 | 산출물, 적용 로그 |
| `technical-evidence.md` | `projects/project3-fisher/technical-evidence.md` | Balance, CloudScript, UI, verification | working doc | 보조 기술 근거 가능 | 확인 필요 | 팀 결과물 포함 | 공개 가능 | 중간 | 가능. 보조 근거 | 높음 | 각 축별 원본 자료 |
| `code-evidence/README.md` | `projects/project3-fisher/code-evidence/README.md` | code evidence 대기 | 기준 문서 | 공개 범위 관리 | 직접 구현 근거 아님 | 팀 코드 포함 가능 | 공개 가능 | 낮음 | 가능. 공개 범위 소재 | 중간 | 실제 code excerpt |

## 실제 코드 근거

- 현재 repo 기준 실제 Project3 `.cs` code evidence는 없다.
- `InventoryService.cs`, `ShopService.cs`, `FisherPlayerDataBridge.cs`, `ShopPanelAdapter.cs`, `BagPanelAdapter.cs`, `CookingPanelAdapter.cs`는 `portfolio/03-project3-fisher/core-file-index.md`에 interview-only 후보로만 존재한다.
- 코드 원본 또는 sanitized excerpt가 제공되기 전까지 직접 구현 확정으로 쓰지 않는다.

## 확인 필요

- Fisher/CSH에서 본인 담당 범위.
- 실제 `.cs` 코드 근거 또는 sanitized excerpt.
- balance workbook, validator log, CSV/JSON 계약.
- CloudScript handler, Unity 호출부, 실패/복구 로그.
- UI/아트 파이프라인 산출물과 Unity 적용 여부.
- Play Mode, build, live proof.
- 팀 공개 승인과 민감정보 제거 기준.

## 공개 부적절 / Drive 보관 대상

- 팀 프로젝트 전체 원본 코드.
- PlayFab Secret Key, live 설정, 내부 API, 원본 로그.
- `.ppt`, `.pptx`, `.docx`, `.pdf`, 이미지, 영상, 압축파일 원본.
- 유료 에셋 원본과 팀원 개인정보.
