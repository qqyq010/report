# Security Redaction Checklist

## 목적

공개 repo에 올라가면 안 되는 항목을 배포 전 확인한다.

## 공개 전 제거해야 할 항목

- API Key
- Secret
- PlayFab Secret Key
- Firebase 설정
- `.env`
- 개인정보
- 팀원 개인정보
- 유료 에셋 원본
- Unity `Library` 폴더
- Unity `Temp` 폴더
- Unity `Obj` 폴더
- Unity `Build` 폴더
- Unity `Logs` 폴더
- 팀 프로젝트 전체 원본 코드
- 자소서 원문 전체
- 이력서 원본 전체

## 확인 필요

- TODO: 각 프로젝트별 공개 가능한 코드 파일 목록 확정.
- TODO: 공개 전 파일명 기준 민감정보 재검사.
- TODO: 공개 전 파일 내용 기준 키워드 재검사.

## 과장 위험 / 금지 표현

- 공개 가능한 근거가 없는 구현을 직접 구현으로 표현하지 않는다.
- 팀 전체 결과물을 개인 단독 구현처럼 표현하지 않는다.
- 검증하지 않은 실행 결과를 완료된 검증처럼 표현하지 않는다.
