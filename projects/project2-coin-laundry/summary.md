# Project 2 - Coin Laundry Summary

## 목적

팀 프로젝트 1의 핵심 목표, 개인 담당 범위, 설명 가능한 근거를 정리한다.

## 현재 확정된 사실

- 팀 프로젝트 1.
- 사용자 제공 키워드: 뱀파이어 서바이벌, 인벤토리, 상점.
- 기존 공개 근거 위치: `portfolio/02-coin-laundry/`.
- 현재 repo 기준 canonical name: `Coin Laundry`.
- 내부 working area 위치: `projects/project2-coin-laundry/`.
- 공개 포트폴리오 근거는 sanitized summary이며, 원본 팀 `.cs` 파일은 현재 repo에 포함되어 있지 않다.

## 직접 구현 근거

- 직접 구현 확정이 아니라 직접 구현 후보로 둔다.
- 인벤토리 UI preview와 실제 데이터 commit 시점 분리
  - 근거: `portfolio/02-coin-laundry/core-file-index.md`, `portfolio/02-coin-laundry/evidence-source-map.md`
  - 관련 파일명: `InventoryUIController.cs`, `InventoryRuntimeService.cs`, `InventoryMergeService.cs`
- 상점 구매 실패 시 재화 환불 경로
  - 근거: `portfolio/02-coin-laundry/core-file-index.md`, `portfolio/02-coin-laundry/evidence-source-map.md`
  - 관련 파일명: `ShopPurchaseService.cs`, `InventoryRuntimeService.cs`
- merge 판정과 실행 책임 분리
  - 근거: `portfolio/02-coin-laundry/core-file-index.md`, `portfolio/02-coin-laundry/evidence-source-map.md`
  - 관련 파일명: `InventoryMergeService.cs`

## 팀 결과물 / 협업 근거

- 팀 프로젝트 1의 인벤토리/상점 흐름 중 담당 범위로 설명 가능한 후보를 정리한다.
- 팀 원본 소스는 공개 허가 전까지 GitHub에 복사하지 않고, 면접 설명용 파일 인덱스와 sanitized summary를 사용한다.
- 팀 전체 결과물과 개인 담당 범위는 계속 분리한다.

## 확인 필요

- TODO: 프로젝트 정식명, 기간, 팀 규모, 담당 역할.
- TODO: survivor-like / 뱀파이어 서바이벌류 장르 설명이 필요한지 확인.
- TODO: 원본 코드 위치, 작성자/담당 범위, 커밋 근거.
- TODO: 실제 실행 검증 또는 시연 자료 위치.
- TODO: EventBus 또는 이벤트 연결 코드 근거.

## 자소서 활용 가능 포인트

- 담당 범위인 인벤토리 UI 상호작용에서 preview와 commit 시점을 분리한 사례.
- 담당 구매 흐름에서 재화 차감 후 아이템 수령 실패 시 환불 경로를 고려한 사례.
- 검증 수준을 코드 확인, 빌드 확인, Play Mode 확인으로 분리한 작업 태도.

## 면접 예상 질문

- 인벤토리와 상점의 데이터 흐름을 어떻게 설명할 수 있는가?
- preview와 실제 데이터 commit은 어떤 기준으로 나뉘는가?
- 구매 실패 시 재화 복구는 어떤 순서로 처리되는가?
- 공개 repo에 원본 팀 소스를 올리지 않은 이유는 무엇인가?

## 과장 위험 / 금지 표현

- 팀 전체 게임 완성도를 개인 단독 구현 성과로 표현하지 않는다.
- 팀 프로젝트 전체 인벤토리 시스템을 혼자 만들었다고 표현하지 않는다.
- 상점 시스템 전체를 완성했다고 표현하지 않는다.
- 모든 Play Mode 케이스를 검증 완료했다고 표현하지 않는다.
