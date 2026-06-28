# Project 2 - Implemented By Me

## 목적

팀 프로젝트 1에서 직접 구현한 항목만 분리한다.

## 현재 확정된 사실

- 사용자 제공 담당 키워드: 인벤토리, 상점.
- 기존 공개 근거는 `portfolio/02-coin-laundry/`의 sanitized summary다.
- 원본 팀 프로젝트 `.cs` 파일은 현재 repo에 포함되어 있지 않다.

## 1. 직접 구현으로 볼 수 있는 항목

현재 repo 기준으로는 `직접 구현 확정`이 아니라 `직접 구현 후보`로 둔다.

- 인벤토리 UI preview와 실제 데이터 commit 시점 분리
  - 근거: `portfolio/02-coin-laundry/core-file-index.md`, `portfolio/02-coin-laundry/evidence-source-map.md`
  - 관련 파일명: `InventoryUIController.cs`, `InventoryRuntimeService.cs`, `InventoryMergeService.cs`
  - 확인 필요: 원본 코드, 작성자/담당 범위, Play Mode 검증 로그
- 상점 구매 실패 시 재화 환불 경로
  - 근거: `portfolio/02-coin-laundry/core-file-index.md`, `portfolio/02-coin-laundry/evidence-source-map.md`
  - 관련 파일명: `ShopPurchaseService.cs`, `InventoryRuntimeService.cs`
  - 확인 필요: 원본 코드, 실패 케이스 재현/검증 로그
- merge 판정과 실행 책임 분리
  - 근거: `portfolio/02-coin-laundry/core-file-index.md`, `portfolio/02-coin-laundry/evidence-source-map.md`
  - 관련 파일명: `InventoryMergeService.cs`
  - 확인 필요: 실제 담당 범위, 호출 흐름, 검증 자료

## 2. 팀 결과물이나 협업 기여로 볼 항목

- 팀 프로젝트 1의 인벤토리/상점 시스템 중 담당 범위 설명
- 팀 소스 공개 허가 전까지 원본 코드 대신 sanitized summary와 면접 설명용 파일 인덱스를 사용한 정리
- 코드 확인, 빌드 확인, Play Mode 확인을 구분하는 검증 기준 사용
- 팀 공용 시스템과 개인 담당 범위를 분리해 설명하려는 claim boundary

## 3. 확인 필요 항목

- 본인 작성 코드와 팀 공용 코드 경계
- 원본 코드 위치와 커밋/작성자 근거
- EventBus 또는 이벤트 연결 코드의 실제 존재 여부
- Play Mode A-K 기록과 실제 검증 완료 범위
- 발표 PPT, 영상, 강사/팀 피드백 자료
- 공개 가능한 코드 excerpt 범위

## 4. 자소서에 쓰면 과장 위험인 항목

- 팀 프로젝트 전체 인벤토리 시스템을 혼자 전부 만들었다.
- 상점 시스템 전체를 완성했다.
- 모든 버그를 해결했다.
- Play Mode에서 모든 케이스를 검증 완료했다.
- 팀 원본 소스를 공개 저장소에 포함했다.

## 자소서 활용 가능 포인트

- TODO: 직접 구현 후보를 원본 코드/검증 로그로 확인한 뒤 문장화한다.
- 현재 단계에서는 `담당 범위`, `설명 가능`, `확인 필요`를 분리한 소재로만 둔다.

## 면접 예상 질문

- 상점 구매/판매 로직과 인벤토리 반영 흐름을 어떻게 설명할 수 있는가?
- preview와 commit을 분리한 이유는 무엇인가?
- 실패 시 환불 경로는 어떤 순서로 동작하는가?

## 과장 위험 / 금지 표현

- 팀 공용 시스템을 본인 단독 설계/구현처럼 표현하지 않는다.
