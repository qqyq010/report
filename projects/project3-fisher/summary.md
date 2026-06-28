# Project 3 - Fisher Summary

## 목적

팀 프로젝트 2 / Project3 Fisher 관련 역할, 구현 범위, 검증 기준, 보조 근거를 정리한다.
이 문서는 완성 게임 포트폴리오가 아니라 자소서/면접에서 작업 방식과 책임 경계를 설명하기 위한 working area다.

## 현재 확정된 사실

- 팀 프로젝트 2.
- 사용자 제공 키워드: 인벤토리, 상점, 요리, 도감, 밸런스.
- 기존 공개 근거 위치: `portfolio/03-project3-fisher/`.
- canonical name은 `Project3 Fisher`.
- 현재 repo에는 Project3 원본 팀 소스, PlayFab 설정, CloudScript 원본, 밸런스 workbook 원본, UI/아트 원본이 없다.
- 공개 포트폴리오 문서는 code evidence, document evidence, verification label, AI-assisted workflow를 요약한다.
- Project3는 Project1처럼 메인 완성작으로 쓰지 않고 검증/문서화/툴링/협업 경계의 보조 근거로 다룬다.

## 직접 구현 근거

- 현재 repo 기준 직접 구현 확정 항목은 없다.
- 직접 구현 후보로 올리려면 실제 `.cs` 코드 근거, 작성자/담당 범위, 검증 로그, 공개 가능 여부를 추가 확인해야 한다.
- 현재 안전하게 말할 수 있는 것은 구현 완료가 아니라 다음 기준을 분리했다는 점이다.
  - code 확인, build/self-test, Play Mode, live proof 분리.
  - 팀 원본 소스와 PlayFab 설정을 GitHub에 복사하지 않는 공개 범위 관리.
  - AI/Codex를 구현 claim이 아니라 분석/검토/검증 큐 관리 보조로 분리.

## 팀 결과물 / 협업 근거

- Project3 Fisher/CSH는 팀 프로젝트 결과물이다.
- `portfolio/03-project3-fisher/core-file-index.md`와 `evidence-source-map.md`에는 인벤토리, 상점, 가방, 요리, PlayFab 요청/응답 경계 후보가 정리되어 있다.
- 팀 결과물 중 본인 담당 범위는 아직 확인 필요다.
- 팀 서버 계약, CloudScript, PlayFab live 검증, 전체 밸런스, 전체 UI 아트는 개인 단독 구현으로 쓰지 않는다.

## 확인 필요

- Fisher/CSH에서 본인 담당 범위.
- 실제 `.cs` 코드 근거 또는 sanitized excerpt.
- balance workbook 원본과 validator 실행 로그.
- CSV/JSON 계약 근거.
- CloudScript handler와 Unity 호출부.
- 실패/복구 로그, Play Mode 검증, build 검증, live proof.
- UI/아트 파이프라인 실제 지시문, 산출물, Unity 적용 여부.
- 팀 공개 승인과 민감정보 제거 기준.

## 자소서 활용 가능 포인트

- 완성작 성과가 아니라 작업 기준을 세운 보조 소재로 사용한다.
- 검증 수준을 code 확인, build/self-test, Play Mode, live proof로 분리한 태도.
- 팀 원본 소스와 PlayFab 설정을 공개 repo에 복사하지 않는 공개 범위 관리.
- AI/Codex를 current-truth, verification queue, 영향 범위 제한에 활용한 방식.

## 면접 예상 질문

- Project3에서 본인이 직접 한 범위와 팀 결과물 범위는 어디까지인가?
- Project3를 왜 메인 완성작이 아니라 보조 근거로 두는가?
- PlayFab 요청/응답/live proof를 왜 분리했는가?
- AI/Codex를 코드 작성 도구가 아니라 분석/검토/문서화 보조로 쓴 범위는 무엇인가?

## 과장 위험 / 금지 표현

- 팀 서버 계약이나 팀 공용 시스템을 개인 단독 구현으로 표현하지 않는다.
- 완성 게임 포트폴리오로 표현하지 않는다.
- 서버 전체 구현, PlayFab 전체 설계, 라이브 서비스 운영이라고 쓰지 않는다.
- 전체 밸런스 확정, 전체 UI 아트 제작, QA 전체 담당, 모든 검증 완료라고 쓰지 않는다.
