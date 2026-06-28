# Project 3 - Interview Points

## 목적

면접에서 Project3를 설명할 때 사용할 질문과 답변 근거를 정리한다.

## 현재 확정된 사실

- Project3는 완성 게임 포트폴리오가 아니라 보조 근거다.
- 대표 설명 주제는 검증 수준 분리, PlayFab/CloudScript 경계 진단, AI-assisted workflow, public evidence boundary다.

## 직접 구현 근거

- 현재 repo 기준 실제 `.cs` 직접 구현 근거는 없다.
- 답변은 공개 문서, 검증 기준, working docs를 근거로 제한한다.

## 팀 결과물 / 협업 근거

- 팀 시스템과 본인 담당 범위를 섞지 않는다.
- Fisher/CSH, CloudScript, 밸런스, UI/아트는 담당 범위 확인 전까지 팀 결과물/확인 필요로 답한다.

## 면접 예상 질문

### 방어 가능한 질문

| 예상 질문 | 답변에 사용할 근거 | 설명 가능한 문서/코드 경로 | 답변 시 강조점 | 피해야 할 표현 | 추가 확인 필요 사항 |
| --- | --- | --- | --- | --- | --- |
| Project3를 왜 메인 완성작이 아니라 보조 근거로 두는가? | claim boundary와 portfolio caveat | `career/claim-boundary.md`, `portfolio/03-project3-fisher/README.md` | 완성 claim보다 검증/문서화/툴링 태도 설명 | 완성 게임 포트폴리오 | 실제 시연/완성도 근거 |
| PlayFab 요청/응답/live proof를 왜 분리했는가? | verification boundary | `portfolio/03-project3-fisher/evidence-source-map.md`, `tools-and-verification.md` | code 확인과 live 성공은 다른 증거 | PlayFab 연동 완료 | handler, caller, live proof |
| build/self-test와 Play Mode/live 검증은 어떻게 다르게 관리했는가? | verification labels | `tools-and-verification.md`, `technical-evidence.md` | 검증 label을 섞지 않음 | 모든 검증 완료 | 실제 build/Play Mode 로그 |
| AI/Codex를 어떤 범위로 사용했는가? | AI-assisted workflow | `portfolio/03-project3-fisher/ai-assisted-workflow.md` | 분석, 검토, verification queue 보조 | AI가 전부 구현했다 | 반영 사례 로그 |
| public repo에 팀 원본 코드나 PlayFab 설정을 올리지 않는 이유는 무엇인가? | public evidence boundary | `drive-links.md`, `code-evidence/README.md` | GitHub는 요약, Drive는 원본 보관 | 팀 원본 공개 가능 | 팀 승인 기준 |

### 추가 확인 필요한 질문

| 예상 질문 | 현재 상태 | 추가 확인 필요 |
| --- | --- | --- |
| Project3에서 본인이 직접 한 Fisher/CSH 범위는 어디까지인가? | 현재 repo 기준 직접 담당 범위 미확정 | 코드, 커밋/changeset, 팀 역할 자료 |
| CloudScript 문제를 실제로 어떻게 진단했는가? | 문서상 경계 기준만 있음 | handler, Unity 호출부, 실패/복구 로그 |
| Balance workbook은 어떤 기준으로 검증했는가? | validator/simulator 후보만 있음 | workbook, CSV/JSON, 실행 로그 |
| UI/Art pipeline에서 실제로 무엇을 맡았는가? | working doc 틀만 있음 | 지시문, 산출물, Unity 적용 근거 |

### 위험 질문

| 위험 질문 | 위험한 이유 | 안전한 대응 방향 |
| --- | --- | --- |
| Project3 Fisher 전체를 본인이 구현했나요? | 팀 프로젝트이며 직접 범위 미확정 | 담당 후보와 팀 결과물 범위를 분리 |
| 서버/CloudScript를 직접 구축했나요? | 서버 전체 구현 근거 없음 | 요청/응답/live proof 분리와 진단 기준으로 제한 |
| 모든 검증을 완료했나요? | Play Mode/live proof 근거 부족 | code/build/Play Mode/live 검증 수준 분리 |
| 전체 밸런스나 UI 아트를 담당했나요? | 원본 자료와 담당 범위 미확정 | workbook/리소스 기준 정리 후보로 제한 |

## 과장 위험 / 금지 표현

- 검증하지 않은 런타임 결과를 확인 완료처럼 말하지 않는다.
- 팀 전체 코드 주도, QA 전체 담당, 모든 버그 해결로 말하지 않는다.
