# Project 3 - CloudScript Evidence

## 목적

Project3 CloudScript 또는 PlayFab 연동 근거를 공개 가능 범위 안에서 정리한다.
서버 전체 구현이 아니라 Fisher/CSH 범위의 문제 진단, Unity 호출부, 서버 응답, live proof 분리 기준을 기록한다.

## 현재 확정된 사실

- `portfolio/03-project3-fisher/evidence-source-map.md`는 PlayFab 요청/응답/live proof를 분리한다.
- `portfolio/03-project3-fisher/core-file-index.md`는 `FisherPlayerDataBridge.cs`, adapter/service 계열 파일을 interview-only 후보로 둔다.
- 현재 repo에는 CloudScript handler 원본이나 PlayFab 설정이 없다.

## 직접 구현 근거

- 현재 repo 기준 직접 구현 확정 CloudScript 코드는 없다.
- CloudScript 또는 PlayFab 관련 claim은 문제 진단과 검증 경계 분리 후보로 제한한다.

## 팀 결과물 / 협업 근거

- CloudScript, PlayFab 설정, server contract는 팀 공용 경계다.
- Fisher/CSH 증상에서 시작하더라도 CloudScript는 공유 계약으로 취급해야 한다.
- Unity 호출부, request args, server response, FunctionResult, live proof를 분리해서 봐야 한다.

## 확인 필요

- UseBox 문제 진단 자료.
- CloudScript request count 문제 자료.
- TitleData 조회 최적화 후보 근거.
- inventory item validation, box/ticket/fragment 검증 분기.
- CloudScript handler 원본 또는 sanitized excerpt.
- Unity 호출부, 실패/복구 로그, local simulation, Play Mode, live proof.
- PlayFab Secret Key, 설정값, 내부 API, 라이브 데이터 포함 여부.

## 자소서 활용 가능 포인트

- 안전한 표현:
  - CloudScript 문제를 진단할 때 Unity 요청, 서버 응답, live proof를 분리해서 보려 했다.
  - live 업로드 전 로컬 검증 후보를 정리했다.
  - 서버 전체 구현이 아니라 Fisher/CSH 범위의 문제 진단과 근거 분리 경험으로 제한한다.

## 면접 예상 질문

- Unity 호출부와 CloudScript handler를 어떤 순서로 확인하는가?
- code 확인과 live PlayFab 성공을 왜 분리하는가?
- 서버 contract 변경이 왜 CSH-only 수정이 아닌가?

## 과장 위험 / 금지 표현

- 서버 전체를 직접 구축했다고 표현하지 않는다.
- 비공개 키나 운영 설정을 공개하지 않는다.
- PlayFab 전체 설계.
- 라이브 서비스 운영.
- CloudScript live 배포 완료 단정.
- 모든 서버 오류 해결.

## 필요한 추가 자료

- 공개 가능한 handler excerpt.
- Unity 호출부 파일명과 경로 요약.
- 실패/복구 로그.
- local CloudScript simulation 또는 Play Mode/live 검증 결과.
- 팀 공개 승인 기준.
