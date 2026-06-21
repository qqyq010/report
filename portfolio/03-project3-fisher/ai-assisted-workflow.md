# AI-Assisted Workflow

## Positioning

AI/Codex를 코드 생성기가 아니라 다음 작업의 보조 도구로 사용했습니다.

- 로컬 코드베이스 경로 추적
- 영향 범위 제한
- current-truth 유지
- verification queue 정리
- 회의 전사/요약 기반 action item 추출
- 외부 AI 답변 intake와 반박 검토
- 즉시 반영, 위험 경고, 보류 분류

## Workflow

1. Rough instruction 또는 회의 내용을 받습니다.
2. Codex가 로컬 파일 기준으로 관련 코드와 문서를 찾습니다.
3. 작업 범위, 팀원 영역, Unity 위험 영역, 서버/live 검증 여부를 나눕니다.
4. 바로 반영할 것과 보류할 것을 분류합니다.
5. 코드상 확인, build/self-test, Play Mode, live proof를 다른 라벨로 기록합니다.
6. 다음 작업자는 current-truth 문서와 verification queue를 먼저 봅니다.

## Safe Interview Sentence

AI가 코드를 대신 작성했다는 의미가 아니라, 문제를 정의하고 검증 기준을 세운 뒤
AI 결과를 로컬 코드와 문서에 맞게 검토하는 방식으로 사용했습니다.

## Risky Sentence

AI로 프로젝트 운영을 자동화했습니다.

## Safer Sentence

로컬 로그, current-truth, checker, verification queue를 이용해 AI-assisted workflow를 반복 적용했습니다.
