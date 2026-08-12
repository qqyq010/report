# Project3 Fisher

팀 프로젝트 2에서 Fisher/CSH 영역과 AI-assisted workflow를 정리한 공개용 문서입니다.

## One Line

인벤토리, 상점, PlayFab 연동 경계, 검증 큐, AI/Codex 기반 작업 운영 흐름을 문서와 로그로 관리했습니다.

## Evidence Layers

- **Public GitHub**: 구조, 검증 기준, 공개 범위, 핵심 파일 인덱스
- **Local interview evidence**: `FisherServerMutationGate.cs`,
  `FisherPlayerDataBridge.cs`, 4개 Panel Adapter, 밸런스 워크북과 생성 CSV
- **Execution evidence**: 최종 빌드의 Shop, Cooking, Bag, Collection 흐름

이 폴더에는 원본 팀 소스나 PlayFab 설정을 넣지 않습니다.
대신 핵심 파일 인덱스와 검증 범위를 정리합니다.

## Main Topics

- 클라이언트 요청과 서버 결과 반영 분리
- 실패 시 UI lock 회복과 서버 데이터 refresh
- current-truth 문서와 historical log 분리
- Play Mode, build, code evidence, live proof 구분
- AI 도구의 제안과 실제 코드·실행 근거를 구분

## Caveat

정적 검사와 최종 빌드 확인을 PlayFab live 성공과 같은 말로 사용하지 않습니다.
BM 실행과 실제 과금 구현도 이 폴더에서 완료 주장으로 사용하지 않습니다.
