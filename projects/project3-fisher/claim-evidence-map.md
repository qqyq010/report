# Project 3 - Claim Evidence Map

## 목적

Project3 Fisher를 자소서/면접에서 보조 근거로 사용할 때 claim 후보와 근거 문서를 연결한다.
현재 repo 기준 실제 코드와 원본 자료가 부족하므로 직접 구현 claim은 확정하지 않는다.

## Claim Evidence Map

| claim 후보 | 근거 문서 | 관련 자료 | 직접 구현 여부 | 팀 결과물 여부 | 검증 수준 | 과장 위험 | 안전한 표현 | 금지 표현 | 추가 검증 필요 여부 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| Project3를 완성작이 아니라 검증/문서화/툴링 보조 근거로 제한했다 | `career/claim-boundary.md`, `portfolio/03-project3-fisher/README.md` | public scope, caveat | 구현 claim 아님 | 팀 프로젝트 포함 | 문서 확인 | 낮음 | Project3는 완성 게임 포트폴리오가 아니라 검증/문서화/툴링 태도 보조 근거로 사용 | 완성 게임 포트폴리오 | 실제 제출용 표현 검수 |
| 검증 수준을 code/build/Play Mode/live proof로 분리했다 | `portfolio/03-project3-fisher/tools-and-verification.md`, `technical-evidence.md` | verification labels | 구현 claim 아님 | 협업 운영 방식 | 문서 확인 | 낮음~중간 | code 확인과 Play Mode/live proof를 분리해 기록했다 | 모든 검증 완료 | 실제 build/Play Mode/live 로그 |
| AI/Codex를 current-truth, verification queue, 영향 범위 제한에 활용했다 | `portfolio/03-project3-fisher/ai-assisted-workflow.md` | AI-assisted workflow | 구현 claim 아님 | 작업 방식 | 문서 확인 | 낮음 | AI/Codex를 분석/검토/검증 큐 관리 보조로 활용했다 | AI가 전부 구현했다 | 실제 반영 사례 로그 |
| 팀 원본 소스와 PlayFab 설정을 공개 repo에 복사하지 않는 공개 범위를 관리했다 | `drive-links.md`, `code-evidence/README.md`, `source-file-map.md` | public evidence boundary | 구현 claim 아님 | 협업/보안 기준 | 문서 확인 | 낮음 | GitHub에는 요약과 근거 연결만 두고 원본은 Drive/비공개 보관 대상으로 분리했다 | 팀 원본 소스를 공개 repo에 포함했다 | 팀 공개 승인 기준 |
| PlayFab 연동 경계에서 요청, 응답, 실패 복구, live proof 대기를 구분했다 | `portfolio/03-project3-fisher/evidence-source-map.md`, `cloudscript-evidence.md` | request/response/live proof | 확인 필요 | 팀 서버 계약 포함 | 문서 확인 | 중간 | PlayFab 관련 문제를 진단할 때 Unity 요청, 서버 응답, live proof를 분리해 보려 했다 | PlayFab 연동 완료 | handler, Unity caller, live proof |
| Fisher/CSH 관련 문제를 문서, 검증 큐, 공개 가능 범위로 나누어 관리했다 | `summary.md`, `role-and-scope.md`, `technical-evidence.md` | Fisher/CSH working docs | 확인 필요 | 팀 결과물 포함 | 문서 확인 | 중간 | Fisher/CSH 문제를 담당 범위, 검증 수준, 공개 가능 범위로 나누어 정리했다 | Fisher 전체를 단독 구현했다 | 담당 범위, 코드 근거 |
| Balance workbook과 검증 문서화를 취업 보조 근거로 정리했다 | `balance-evidence.md`, `tools-and-verification.md` | validator, simulator, workbook 후보 | 확인 필요 | 팀 기준 포함 가능 | 문서 확인 | 중간 | 밸런스 수치 확정이 아니라 검증 기준과 근거 분리를 관리했다 | 전체 게임 밸런스 확정 | workbook, validator log |
| CloudScript 문제 진단 후보를 Unity 호출부, 서버 응답, live proof로 분리했다 | `cloudscript-evidence.md`, `evidence-source-map.md` | UseBox, request count, TitleData 후보 | 확인 필요 | 팀 서버 계약 포함 | 문서 확인 | 높음 | 서버 전체 구현이 아니라 문제 진단과 근거 분리 경험으로 제한한다 | 서버 전체 구현 / live 배포 완료 | handler, caller, failure log |
| UI/아트 파이프라인에서 산출물, 지시문, Unity 적용 여부를 분리했다 | `ui-art-pipeline-evidence.md`, `ai-assisted-workflow.md` | sprite, icon, 9-slice 후보 | 확인 필요 | 팀/AI 산출물 포함 | 문서 확인 | 중간 | UI 리소스 기준과 검수 지시문을 산출물/적용 여부와 분리했다 | 전체 UI 아트 제작 | 산출물, prompt, 적용 로그 |

## 바로 사용 가능 후보

- Project3를 완성작으로 과장하지 않고 보조 근거로 제한한 태도.
- code/build/Play Mode/live proof 검증 수준 분리.
- AI/Codex를 분석/검토/검증 큐 관리 보조로 사용한 기준.
- 팀 원본 소스와 PlayFab 설정을 GitHub에 복사하지 않는 공개 범위 관리.

## 제한 표현으로 사용 가능 후보

- PlayFab 연동 경계에서 요청, 응답, 실패 복구, live proof 대기를 구분했다.
- Fisher/CSH 관련 문제를 문서, 검증 큐, 공개 가능 범위로 나누어 관리했다.

## 근거 보강 후 사용 가능 후보

- Fisher/CSH 인벤토리, 상점, 요리, 도감, 밸런스 담당 경험.
- CloudScript 문제 진단 사례.
- UI/아트 파이프라인 정리 사례.
- balance workbook, validator, CSV/JSON 계약 정리 사례.

## 사용 금지 / 과장 위험

- 완성 게임 포트폴리오.
- 서버/PlayFab 전체 설계.
- 전체 밸런스 확정.
- 모든 검증 완료.
- 팀 전체 코드 주도.
- AI 이미지 산출물을 직접 제작 그래픽처럼 표현.
