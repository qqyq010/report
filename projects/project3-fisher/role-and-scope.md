# Project 3 - Role And Scope

## 목적

Project3에서 개인 역할과 팀 협업 범위를 분리한다.
확정되지 않은 항목을 개인 구현으로 올리지 않고, Fisher / CSH / Balance / CloudScript / UI art pipeline / Verification workflow를 각각 나눠 기록한다.

## 현재 확정된 사실

- Project3 Fisher는 팀 프로젝트 2의 보조 근거다.
- 현재 repo에는 실제 코드 원본이나 팀 역할 확정 자료가 없다.
- `portfolio/03-project3-fisher/`에는 공개 가능한 요약과 검증 기준이 있다.

## 1. 개인 담당 후보

| 축 | 현재 분류 | 근거 | 확인 필요 |
| --- | --- | --- | --- |
| Fisher / CSH | 확인 필요 | `portfolio/03-project3-fisher/core-file-index.md`에 관련 파일 후보가 있음 | 실제 담당 파일, 작성자/수정 이력, 검증 로그 |
| Balance | 확인 필요 | `tools-and-verification.md`에 balance validator, economy simulator가 언급됨 | workbook 원본, 실행 로그, 런타임 반영 여부 |
| CloudScript / PlayFab | 확인 필요 | `evidence-source-map.md`에 request/response/live proof 분리 기준이 있음 | CloudScript handler, Unity 호출부, live proof |
| UI / Art pipeline | 확인 필요 | 현재 working doc 틀만 있음 | 지시문, 산출물, Unity 적용 여부 |
| Verification workflow | 보조 소재 후보 | verification label, current-truth, verification queue 문서 근거 | 실제 검증 로그와 적용 사례 |
| AI-assisted workflow | 보조 소재 후보 | `ai-assisted-workflow.md` | AI 결과와 본인 검토/반영 범위 |

## 2. 팀 결과물/협업 기여 후보

- Fisher/CSH 인벤토리, 상점, 가방, 요리, 도감 흐름은 팀 결과물이다.
- PlayFab/CloudScript/server contract는 팀 공용 경계다.
- 밸런스 수치, workbook, CSV/JSON 계약은 팀 기준과 개인 검토 범위를 분리해야 한다.
- UI/아트 리소스는 팀원 작업물, AI 산출물, 본인 지시/검수/적용 범위를 분리해야 한다.
- public evidence repo 정리는 협업 근거를 공개 가능 범위로 제한하는 보조 소재로 사용할 수 있다.

## 3. 확인 필요 항목

- Fisher/CSH에서 실제 본인 담당 범위.
- 실제 `.cs` 코드 근거 또는 sanitized excerpt.
- balance workbook, validator 실행 로그, CSV/JSON 계약 근거.
- CloudScript handler, Unity 호출부, 실패/복구 로그.
- UI/아트 파이프라인 지시문, 산출물, Unity 적용 여부.
- Play Mode, build, live proof.
- 팀 공개 승인과 민감정보 제거 기준.

## 자소서 활용 가능 포인트

- 책임 경계가 있는 팀 작업에서 확인한 것과 미확인 상태를 분리한 경험.
- live proof와 code evidence를 섞지 않고 검증 수준을 관리한 경험.
- AI/Codex를 보조 도구로 사용하면서 팀 코드와 공개 범위를 보호한 경험.

## 면접 예상 질문

- 본인이 직접 구현한 범위와 팀원/팀 시스템 범위의 차이는 무엇인가?
- CloudScript나 PlayFab 관련 문제를 CSH-only 문제로 보지 않고 어떻게 경계를 나눴는가?
- 검증 수준을 code/build/Play Mode/live로 왜 분리했는가?

## 4. 자소서에 쓰면 과장 위험인 항목

- 팀 공용 계약 변경을 개인 단독 판단으로 처리한 것처럼 쓰지 않는다.
- Fisher/CSH 전체를 단독 구현했다고 쓰지 않는다.
- 서버 전체 구현, PlayFab 전체 설계, 라이브 서비스 운영으로 쓰지 않는다.
- 전체 밸런스 확정, 전체 UI 아트 제작, QA 전체 담당으로 쓰지 않는다.
- AI가 만든 결과를 직접 제작물처럼 표현하지 않는다.
