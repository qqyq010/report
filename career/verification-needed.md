# Verification Needed

## 목적

아직 사실 확인이 끝나지 않은 항목을 분리해 과장 위험을 줄인다.
이 문서에 남아 있는 항목은 자소서, 이력서, 포트폴리오 본문에서 확정 표현으로 쓰지 않는다.

## 현재 확정된 사실

- 확인이 끝난 항목만 프로젝트별 문서로 이관한다.
- 확인되지 않은 항목은 `TODO`, `확인 필요`, `추가 설명 필요`로 둔다.
- 문서상 설계, 코드 존재, 빌드 확인, 런타임 검증은 서로 다른 상태로 기록한다.

## 직접 구현 근거

- Project1 EscapeRoom: 공개 코드 10개와 claim mapping은 확인됨. 시연 근거와 scene 연결은 확인 필요.
- TODO: Project2 Inventory / Shop / UI / EventBus / 디버깅 / 검증의 직접 담당 범위 확인.
- TODO: Project3 Fisher / CSH / 밸런스 / CloudScript / UI 아트 파이프라인의 직접 작업 범위 확인.
- TODO: 각 항목별 코드, 커밋, 문서, 시연 자료 연결.

## 팀 결과물 / 협업 근거

- TODO: Project2 팀 결과물 중 본인 담당 범위 확인.
- TODO: Project3 팀 결과물 중 협업/검증/문서화/툴링 기여 범위 확인.
- TODO: 팀 공용 시스템, 서버 계약, 전체 QA, 전체 밸런스와 개인 담당 범위 분리.

## 확인 필요

- TODO: 프로젝트별 기간, 팀 규모, 담당 파트.
- TODO: 공개 가능한 코드 파일 목록.
- TODO: 면접에서 설명 가능한 기술 깊이.
- TODO: Drive 원본 자료와 GitHub 요약 문서의 연결.
- TODO: 자소서 초안에서 근거가 필요한 문장 목록.
- TODO: 포트폴리오 PPT와 기술문서에 들어갈 스크린샷/영상 위치.
- TODO: 공개 repo에 올릴 수 없는 원본 자료 목록.

## Project1 - EscapeRoom 보강 필요 자료

### 현재 코드 근거가 있는 항목

- `GameManager.cs`, `ProgressState.cs`: 상태와 진행도 분리.
- `EnemyVision.cs`, `DetectionController.cs`, `PlayerDetectionTarget.cs`: 거리/각도/Raycast 감지와 실패 연결.
- `FailureHandler.cs`, `CheckpointManager.cs`, `CheckpointTrigger.cs`: 실패 처리와 체크포인트 복귀.
- `TreasureGridManager.cs`, `TreasureEnemy.cs`: Treasure 퍼즐 reset/phase unlock과 추적 적.

### 반드시 확인해야 할 항목

- 프로젝트 기간.
- Unity 버전.
- 실제 scene/prefab/Inspector 연결.
- 시연 영상 또는 빌드 위치.
- Play Mode 검증 근거.
- 빌드 검증 근거.

### 현재 repo 기준 근거 없는 항목

- HideZone 코드 근거.
- PuzzleSafeZone 코드 근거.
- Player 이동 구현 파일.
- `InputLockController`.
- `TreasureNode`.
- `TreasurePlayerMovement`.
- `TreasureTrigger`.
- `GameState`, `PuzzleType`, `FailureReason`, `FailureRecoveryType` enum 정의.

### 공개 전에 확인할 항목

- 원본 Unity scene/prefab을 GitHub에 올리지 않는지.
- 영상, 이미지, 빌드 파일은 Drive 보관 대상으로 분리했는지.
- AI/Codex 관련 표현이 보조 도구 범위에 머무르는지.

## Project2 - Coin Laundry 보강 필요 자료

### 반드시 필요한 코드 근거

- `InventoryUIController.cs`: 원본 위치 확인 완료, excerpt 생성 완료. 작성자/담당 범위/공개 승인 확인 필요.
- `InventoryRuntimeService.cs`: 원본 위치 확인 완료, excerpt 생성 완료. 작성자/담당 범위/fallback 검증 확인 필요.
- `InventoryMergeService.cs`: 원본 위치 확인 완료, excerpt 생성 완료. 작성자/담당 범위/merge 검증 확인 필요.
- `ShopPurchaseService.cs`: 원본 위치 확인 완료, excerpt 생성 완료. 작성자/담당 범위/환불 실패 케이스 검증 확인 필요.
- 각 파일의 커밋 기록, 작성자, 팀 공개 승인 여부.
- 3/3 점검 기준: 로컬 UVCS/Plastic workspace 흔적은 있으나 작성자/커밋 확정 근거는 아직 부족하다.

### 있으면 좋은 코드 근거

- EventBus 또는 이벤트 연결 코드
- UI preview renderer 관련 코드
- 구매 실패/환불 처리 테스트 또는 재현 코드
- PlayerCurrencyCore 또는 재화 차감/환불 연결 코드
- ShopSlotController 또는 상점 UI와 구매 service 연결 코드

### 반드시 필요한 문서 근거

- 프로젝트 기간, 팀 규모, 담당 역할 정리
- 인벤토리/상점 기능 변경 로그
- 본인 담당 범위와 팀 공용 코드 경계 자료
- sanitized excerpt 공개 가능 여부 또는 면접 전용 사용 기준

### 있으면 좋은 영상/이미지 근거

- 인벤토리 드래그/회전/배치 흐름 시연
- 상점 구매 성공/실패 흐름 시연
- UI preview와 실제 commit 차이를 보여주는 화면
- merge 성공/실패 또는 swap/restore 흐름 시연

### 발표자료/피드백 근거

- 발표 PPT 또는 발표 대본
- 강사 피드백
- 팀 피드백 또는 QA 기록
- 리뷰 시트, Notion export, 기능 명세서의 Drive 링크

### 면접 전에 확인해야 할 기술 사항

- preview와 commit의 실제 호출 순서
- 환불 경로의 실패 조건과 복구 순서
- Play Mode 확인 범위와 미검증 범위
- EventBus 사용 여부
- fallback merge의 조건과 의도
- 코드 확인, 문서 확인, 빌드 확인, Unity Play Mode 확인의 분리 기준
- 4개 핵심 claim을 직접 구현으로 확정할 수 있는지, 팀 결과물/협업 기여로 제한해야 하는지

### 공개 전에 제거해야 할 민감정보

- 팀원 개인정보
- 유료 에셋 원본
- 팀 프로젝트 전체 원본 코드
- API Key, Secret, Token
- Unity `Library`, `Temp`, `Obj`, `Build`, `Logs` 폴더
- 로컬 절대경로, 사용자명, 라이선스 로그, 원본 Unity log
- `.ppt`, `.pptx`, `.docx`, `.pdf`, 이미지, 영상, 압축파일 원본

## Project3 - Fisher 보강 필요 자료

### 현재 문서 근거가 있는 항목

- `portfolio/03-project3-fisher/README.md`: Project3 Fisher의 public scope와 caveat.
- `portfolio/03-project3-fisher/ai-assisted-workflow.md`: AI/Codex를 분석/검토/검증 큐 관리 보조로 쓰는 기준.
- `portfolio/03-project3-fisher/evidence-source-map.md`: PlayFab 요청/응답/live proof 분리.
- `portfolio/03-project3-fisher/tools-and-verification.md`: code 확인, build/self-test, Play Mode, live proof label.
- `projects/project3-fisher/source-file-map.md`, `claim-evidence-map.md`: Project3 보조 근거 working map.

### 반드시 확인해야 할 항목

- Fisher/CSH에서 본인 담당 범위.
- 실제 `.cs` 코드 근거 또는 sanitized excerpt.
- balance workbook 원본.
- validator 실행 로그.
- CSV/JSON 계약 근거.
- CloudScript handler.
- Unity 호출부.
- 실패/복구 로그.
- UI/아트 파이프라인 실제 지시문.
- UI 산출물과 Unity 적용 여부.
- Play Mode 검증.
- build 검증.
- live proof.
- 팀 공개 승인.
- 민감정보 제거 기준.

### 현재 repo 기준 근거 없는 항목

- 직접 구현 확정 가능한 Project3 `.cs` code evidence.
- CloudScript 원본 또는 sanitized handler.
- PlayFab live 성공 근거.
- balance workbook과 실제 tuning 결과.
- UI/아트 산출물 원본과 Unity 적용 검증.

### 공개 전에 확인할 항목

- 팀 프로젝트 전체 원본 코드가 GitHub에 포함되지 않는지.
- PlayFab Secret Key, 설정값, live 데이터, 내부 API가 제거되었는지.
- 유료 에셋 원본, 팀원 개인정보, 원본 로그가 제거되었는지.
- `.ppt`, `.pptx`, `.docx`, `.pdf`, 이미지, 영상, 압축파일 원본은 Drive 보관 대상으로 분리했는지.
- Project3가 완성 게임 포트폴리오처럼 표현되지 않는지.

## 자소서 활용 가능 포인트

- 확인된 항목만 자소서 소재 후보로 이동한다.
- 확인 전에는 감정적 문장이나 성과 문장으로 확장하지 않는다.

## 면접 예상 질문

- TODO: 확인되지 않은 항목에 대해 답변 보류 문구를 준비한다.
- TODO: 직접 구현 여부, 협업 범위, 검증 수준을 묻는 질문에 대한 근거 준비.

## 과장 위험 / 금지 표현

- 확인 필요 항목을 이력서나 자소서 본문에 확정 표현으로 쓰지 않는다.
- 전부 직접 구현, 전체 시스템 설계, 서버 전체 구현, 모든 버그 해결, QA 전체 담당, 밸런스 전체 확정은 확인 전 금지한다.
