# Project 3 - Technical Evidence

## 목적

Project3의 보조 기술 근거를 기능별로 정리한다.
이 문서는 기술 구현 확정 문서가 아니라 검증, 문서화, 툴링, 협업 경계 설명을 위한 근거 문서다.

## 현재 확정된 사실

- 기존 공개 근거 위치: `portfolio/03-project3-fisher/`.
- 현재 repo에는 Project3 실제 코드 excerpt가 없다.
- 공개 문서에는 PlayFab 요청/응답/live proof 분리, AI-assisted workflow, verification label, public evidence boundary가 정리되어 있다.

## 직접 구현 근거

| 축 | 문제 상황 | 접근 방식 | 관련 근거 | 검증 수준 | 한계 | 면접에서 설명 가능한 수준 | 추가 보강 필요 자료 |
| --- | --- | --- | --- | --- | --- | --- | --- |
| Balance / data validation | 밸런스 후보와 실제 반영 수치가 섞일 위험 | workbook, validator, simulator, CSV/JSON 계약을 분리해 기록 | `portfolio/03-project3-fisher/tools-and-verification.md`, `balance-evidence.md` | 문서 확인 | workbook 원본과 실행 로그 없음 | 최종 수치 확정이 아니라 검증 기준 분리로 설명 | workbook, validator log, CSV/JSON 계약 |
| CloudScript / request-response debugging | UI 증상, Unity 호출부, 서버 응답, live proof가 섞일 위험 | Unity 요청, CloudScript handler, FunctionResult, live proof를 분리 | `evidence-source-map.md`, `cloudscript-evidence.md` | 문서 확인 | handler 원본, 호출부, live proof 없음 | 서버 전체 구현이 아닌 문제 진단 기준으로 설명 | handler excerpt, Unity caller, failure log |
| UI art pipeline / asset handoff | AI 산출물, 팀원 아트, Unity 적용 여부가 섞일 위험 | 리소스 기준, 명명/여백/투명 배경, 검수 지시문과 적용 근거를 분리 | `ui-art-pipeline-evidence.md`, `ai-assisted-workflow.md` | 문서 확인 | 실제 산출물과 적용 검증 없음 | 제작 claim이 아니라 기준/검수/경계 관리로 설명 | handoff doc, prompt, 적용 로그 |
| Verification workflow | code 확인을 Play Mode/live 성공처럼 과장할 위험 | code, build/self-test, Play Mode, live proof label 분리 | `portfolio/03-project3-fisher/tools-and-verification.md` | 문서 확인 | 실제 실행 로그 필요 | 검증 수준 분리 기준 설명 가능 | build log, Play Mode log, live proof |
| AI-assisted workflow | AI 결과를 구현 claim으로 오해할 위험 | Codex/AI를 read-only scan, 영향 범위 제한, verification queue 보조로 분리 | `portfolio/03-project3-fisher/ai-assisted-workflow.md` | 문서 확인 | 실제 반영 사례 연결 필요 | AI 사용 경계와 검토 방식 설명 가능 | 외부 AI intake, 검토 로그 |
| Public evidence boundary | 팀 원본 소스와 PlayFab 설정이 공개 repo에 섞일 위험 | GitHub에는 요약/인덱스, Drive에는 원본/대용량 자료 보관 | `drive-links.md`, `code-evidence/README.md` | 문서 확인 | 자료별 공개 승인 필요 | 공개 가능 범위 관리 설명 가능 | 팀 승인, sanitized excerpt |

## 팀 결과물 / 협업 근거

- 팀 공용 시스템, PlayFab/CloudScript, 밸런스 기준, UI/아트 산출물은 개인 claim과 분리한다.
- 직접 구현 여부가 확인되기 전까지는 팀 결과물/협업 후보 또는 확인 필요로 둔다.

## 확인 필요

- 실제 실행 검증 완료 항목과 문서상 설계 항목.
- 공개 가능한 코드와 비공개 코드.
- 원본 자료의 Drive 위치.
- 팀 공개 승인과 민감정보 제거 여부.

## 자소서 활용 가능 포인트

- 검증 수준을 분리한 문제 추적 태도.
- 팀 결과물과 개인 claim을 분리하는 문서화 태도.
- AI/Codex를 구현 자동화가 아니라 코드베이스 분석과 검증 관리에 활용한 방식.

## 면접 예상 질문

- PlayFab 요청/응답/live proof를 왜 분리했는가?
- build/self-test와 Play Mode/live 검증은 어떻게 다르게 관리했는가?
- AI/Codex를 사용한 범위가 코드 작성인지, 분석/검토/문서화인지?

## 과장 위험 / 금지 표현

- 문서 확인, 빌드 확인, 런타임 확인을 섞어서 표현하지 않는다.
- 구현 완료, live 배포 완료, 전체 밸런스 확정, 전체 UI 적용 완료로 표현하지 않는다.
