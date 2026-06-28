# Claim Boundary

## 목적

이력서, 자소서, 포트폴리오, 면접에서 말할 수 있는 범위와 금지 범위를 분리한다.
근거가 없는 내용을 매력적인 문장으로 먼저 만들지 않기 위한 기준 문서다.

## 현재 확정된 사실

- GitHub에는 공개 가능한 근거와 요약만 둔다.
- 원본 문서와 대용량 자료는 Google Drive `center` 폴더에 둔다.
- 직접 구현 / 팀 결과물 / 확인 필요 / 과장 위험을 분리해서 기록한다.
- Project3는 완성 게임 포트폴리오가 아니라 작업 방식, 검증, 문서화, 툴링 태도의 보조 근거로 다룬다.
- `portfolio/`는 외부 공개 가능한 정제 설명과 sanitized evidence를 둔다.
- `projects/`는 자소서/면접용 claim working area로 둔다.
- `career/`는 프로젝트별 근거를 이력서, 자소서, 면접 소재로 변환하는 상위 정리 공간으로 둔다.

## 문서 위치 기준

- 공개 가능한 정제 설명은 `portfolio/`에 둔다.
- 직접 구현 / 팀 결과물 / 확인 필요 / 과장 위험 분류는 `projects/`에 둔다.
- 전체 취업 포지셔닝과 주장 경계는 `career/`에 둔다.
- 원본 파일은 Drive `center`에 둔다.
- GitHub에는 링크와 요약만 둔다.
- 상세 기준은 [portfolio-projects-role-map.md](../portfolio-projects-role-map.md)를 따른다.

## 직접 구현 근거

- 사용할 수 있는 표현: 담당 범위 내 구현, 특정 기능의 구조 개선, 코드/문서/테스트 근거 기반 개선.
- Project1: 개인 프로젝트 EscapeRoom은 공개 코드 10개가 있으므로 자소서 메인 소재 후보로 사용할 수 있다.
- Project1에서 사용할 수 있는 제한 표현 후보:
  - 단일 씬 기반 잠입/퍼즐 탈출 흐름에서 GameState와 ProgressState를 분리했다.
  - EnemyVision에서 거리, 각도, Raycast line-of-sight를 순서대로 확인하는 감지 구조를 구현했다.
  - 감지 실패, 실패 처리, 체크포인트 복귀를 역할별 스크립트로 나눴다.
  - Treasure 퍼즐의 grid/path/reset/phase unlock 흐름을 코드로 관리했다.
- Project2: `projects/project2-coin-laundry/code-evidence/`에 sanitized excerpt가 있으나, 작성자/커밋/팀 승인 전까지 직접 구현 확정 표현은 금지한다.
- Project2에서 사용할 수 있는 제한 표현 후보:
  - 담당 범위 후보인 인벤토리 UI에서 preview와 commit 시점을 분리한 구조를 설명할 수 있다.
  - 담당 범위 후보인 상점 구매 흐름에서 spend, receive, refund 순서를 설명할 수 있다.
  - merge 판정과 실행 책임을 분리한 구조를 코드 조각 기준으로 설명할 수 있다.
- Project2 3/3 점검 판정: 4개 claim은 자소서/면접 소재로 제한 사용 가능하지만, 직접 구현 확정은 작성자/커밋/팀 change log 확인 전까지 보류한다.
- TODO: Project3 Fisher / CSH / 밸런스 / CloudScript / UI 아트 파이프라인 중 직접 작업 범위 연결.

## 팀 결과물 / 협업 근거

- 사용할 수 있는 표현: 팀 결과물 중 본인 기여 범위 명시, 협업 과정에서 담당한 검증/문서화/정리.
- TODO: Project2와 Project3의 팀 공용 코드, 팀원 구현분, 본인 담당분을 분리한다.
- TODO: 팀 전체 결과물은 본인 담당 범위가 확인된 경우에만 제한적으로 사용한다.
- Project2 원본 팀 코드는 공개 허가 전까지 원본 전체를 GitHub에 두지 않고, sanitized excerpt와 요약만 사용한다.

## 확인 필요

- TODO: 팀 프로젝트 원본 코드 공개 가능 범위 확인.
- TODO: Project2 sanitized excerpt 공개 승인 또는 면접 전용 범위 확인.
- TODO: Project2 UVCS/Plastic 서버 이력 또는 팀 change log로 작성자/수정 이력 확인.
- TODO: 팀원 개인정보와 유료 에셋 포함 여부 확인.
- TODO: 문서상 설계, 코드 존재, 빌드 확인, 런타임 검증을 각각 분리.
- TODO: Project1의 scene/prefab/Inspector 연결, Play Mode/빌드 검증, 누락 타입 확인.
- TODO: Project2 canonical name은 `Coin Laundry`로 둔다. 내부 working area는 `projects/project2-coin-laundry/`를 사용한다.
- TODO: Project3 관련 근거 중 공개 가능한 범위 확인.

## 자소서 활용 가능 포인트

- 개인의 판단, 구현, 디버깅, 검증 과정을 근거 중심으로 정리한다.
- Project3는 포트폴리오 보조 근거로 사용하고, 검증/문서화/툴링 태도 설명에 제한한다.

## 면접 예상 질문

- TODO: "이 부분을 본인이 직접 했나요?" 질문에 답할 근거 준비.
- TODO: "팀원이 한 일과 본인이 한 일의 차이는 무엇인가?" 질문에 답할 근거 준비.
- TODO: "실제로 실행 검증했나요?" 질문에 답할 근거 준비.

## 과장 위험 / 금지 표현

- 전부 직접 구현
- 전체 시스템 설계
- 서버 전체 구현
- 라이브 서비스 운영
- 상용 수준 완성
- 모든 버그 해결
- 팀 전체 코드 주도
- QA 전체 담당
- 밸런스 전체 확정
- "전체 시스템을 혼자 구현"처럼 책임 범위가 불명확한 표현을 쓰지 않는다.
- 팀원이 구현한 기능을 개인 구현처럼 말하지 않는다.
- 확인되지 않은 수치, 성능 개선, 버그 해결을 확정처럼 말하지 않는다.
- sanitized excerpt가 존재한다는 이유만으로 직접 구현 확정, 전체 구조 설계, 전체 QA 담당으로 표현하지 않는다.
- Unity batch log 후보 중 실패/return code가 있는 자료를 성공 근거처럼 사용하지 않는다.
- Project1에서 repo에 없는 HideZone, PuzzleSafeZone, Player 이동을 구현 완료로 표현하지 않는다.
- Project1을 상용 수준 스텔스 AI 또는 모든 런타임 검증 완료로 표현하지 않는다.
