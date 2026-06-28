# Project 2 - Intake Checklist

## 목적

Project2 자료를 투입하기 전에 공개 가능 여부, 직접 구현 여부, 검증 수준을 확인한다.

## 명칭 기준

- 현재 repo 기준 canonical name: `Coin Laundry`.
- 현재 문서 위치: `projects/project2-coin-laundry/`.
- 외부 공개 포트폴리오 근거는 `portfolio/02-coin-laundry/`에 둔다.

## 사용자가 제공해야 할 자료

- 직접 구현한 핵심 `.cs` 파일
- Inventory 관련 코드
- Shop 관련 코드
- UI 관련 코드
- EventBus 또는 이벤트 연결 코드
- 디버깅/버그 수정 근거
- 검증 로그 요약
- 발표 PPT 또는 영상 링크
- 포트폴리오 문서
- 강사/팀 피드백 자료

## 남은 자료 요청 목록

### 반드시 필요한 코드 근거

- `InventoryUIController.cs`
- `InventoryRuntimeService.cs`
- `InventoryMergeService.cs`
- `ShopPurchaseService.cs`
- 각 파일의 원본 위치, 작성자/담당 범위, 공개 가능 여부

### 있으면 좋은 코드 근거

- EventBus 또는 이벤트 연결 코드
- UI preview renderer 관련 코드
- 실패 케이스 재현 또는 테스트 코드

### 반드시 필요한 문서 근거

- 프로젝트 기간, 팀 규모, 담당 역할
- 기능 변경 로그
- 버그 수정 전후 기록
- 본인 담당 범위와 팀 공용 코드 경계 자료

### 있으면 좋은 영상/이미지 근거

- 인벤토리 drag/rotate/place 시연
- 상점 구매 성공/실패 시연
- preview와 commit 차이를 보여주는 화면

### 발표자료/피드백 근거

- 발표 PPT 또는 영상 링크
- 발표 대본
- 강사/팀 피드백

### 면접 전에 확인해야 할 기술 사항

- Inventory preview와 commit 호출 순서
- Shop refund 실패 조건
- EventBus 사용 여부
- Play Mode 확인 범위

### 공개 전에 제거해야 할 민감정보

- API Key, Secret, Token
- 개인정보와 팀원 개인정보
- 유료 에셋 원본
- 팀 프로젝트 전체 원본 코드
- Unity `Library`, `Temp`, `Obj`, `Build`, `Logs` 폴더

## GitHub에 넣기 전 확인

- TODO: 파일별 공개 가능 여부 확인.
- TODO: 본인 직접 구현 범위와 팀 코드 범위 분리.
- TODO: 민감정보, 팀원 개인정보, 유료 에셋 원본 포함 여부 확인.
- TODO: 원본 PPT, 영상, 이미지, 압축파일은 Drive에 보관하고 GitHub에는 링크와 요약만 남긴다.

## 과장 위험 / 금지 표현

- 팀 프로젝트 전체를 혼자 구현했다고 쓰지 않는다.
- 팀 전체 QA를 담당했다고 쓰지 않는다.
- Play Mode에서 모든 케이스를 검증 완료했다고 쓰지 않는다.
