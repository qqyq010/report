# Project3 Fisher

팀 프로젝트 2에서 Fisher/CSH 영역과 AI-assisted workflow를 정리한 공개용 문서입니다.

## One Line

인벤토리, 상점, PlayFab 연동 경계, 검증 큐, AI/Codex 기반 작업 운영 흐름을 문서와 로그로 관리했습니다.

## Public Scope

이 폴더에는 원본 팀 소스나 PlayFab 설정을 넣지 않습니다.
대신 핵심 파일 인덱스, 검증 기준, AI/Codex workflow, tools/checker 활용 방식을 정리합니다.

## Main Topics

- 클라이언트 요청과 서버 결과 반영 분리
- 실패 시 UI lock 회복과 서버 데이터 refresh
- current-truth 문서와 historical log 분리
- Play Mode, build, code evidence, live proof 구분
- Codex를 코드 생성보다 코드베이스 분석과 검증 관리에 활용
- GPT/Gemini/Codex 외부 AI 결과를 즉시 반영, 위험 경고, 보류로 분류

## Caveat

PlayFab live 성공, BM 실행, 실제 과금 구현은 이 폴더에서 완료 주장으로 사용하지 않습니다.
