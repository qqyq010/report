# Project 1 - Implemented By Me

## 목적

개인 프로젝트에서 직접 구현한 항목만 분리한다.

## 현재 확정된 사실

- 개인 프로젝트이며, 공개 코드 근거가 `portfolio/01-escape-room/code/` 아래에 있다.
- 현재 repo 기준으로 직접 구현 후보를 코드 근거와 연결할 수 있다.
- 다만 scene/prefab/Inspector 연결, Play Mode/빌드 검증, 일부 지원 타입은 확인 필요로 남긴다.

## 1. 직접 구현으로 볼 수 있는 후보

- GameState와 ProgressState 분리
  - 근거: `portfolio/01-escape-room/code/Core/GameManager.cs`, `ProgressState.cs`
  - 설명 가능 포인트: 현재 행동 가능 상태와 퍼즐 진행도를 분리해 관리.
- EnemyVision 거리/각도/Raycast 감지
  - 근거: `portfolio/01-escape-room/code/Enemy/EnemyVision.cs`
  - 설명 가능 포인트: view distance, view angle, Raycast line-of-sight 순서.
- DetectionController와 FailureHandler 연결
  - 근거: `DetectionController.cs`, `FailureHandler.cs`
  - 설명 가능 포인트: 감지 성공을 실패 처리로 넘기고 중복 실패를 막음.
- 체크포인트 저장/복귀
  - 근거: `CheckpointManager.cs`, `CheckpointTrigger.cs`
  - 설명 가능 포인트: 실패 후 player root를 저장된 checkpoint로 복귀.
- Treasure 퍼즐 진행과 reset
  - 근거: `TreasureGridManager.cs`, `TreasureEnemy.cs`
  - 설명 가능 포인트: 노드/path/reset/phase unlock, 퍼즐 내부 추적 적.

## 2. 코드 근거는 있으나 추가 확인이 필요한 항목

- 입력 잠금 전체 구현
  - 근거: `FailureHandler.cs`가 `InputLockController`를 참조함.
  - 확인 필요: `InputLockController` 원본이 현재 repo에 없음.
- Treasure 퍼즐 전체 시스템
  - 근거: `TreasureGridManager.cs`, `TreasureEnemy.cs`
  - 확인 필요: `TreasureNode`, `TreasurePlayerMovement`, `TreasureTrigger`, scene 연결.
- Player 이동
  - 현재 repo에는 Player 이동 구현 파일이 없다.
- HideZone / PuzzleSafeZone
  - 현재 repo 코드에서 확인되지 않는다.

## 3. AI/Codex 보조 또는 문서화 보조로 분리할 항목

- `portfolio/01-escape-room/ai-codex-evidence.md` 기준, AI/Codex는 감지, 실패, 체크포인트, 퍼즐 진행 문제를 분석/검토/문서화하는 보조 근거로 사용한다.
- AI가 제안한 내용을 그대로 붙여 넣었다거나, 반대로 AI 도움 없이 전부 직접 작성했다는 표현은 쓰지 않는다.

## 확인 필요

- 프로젝트 기간과 Unity 버전.
- scene/prefab/Inspector binding.
- Play Mode 또는 빌드 검증 근거.
- 시연 영상, 발표 자료, 스크린샷 위치.

## 자소서 활용 가능 포인트

- 개인 프로젝트에서 상태 관리, 감지, 실패 복구, 퍼즐 진행을 역할별로 나눈 경험.
- 잠입 요소를 거리/각도/Raycast로 설명 가능한 구조로 구현한 경험.
- 실패 후 복귀와 퍼즐 reset을 분리해 재시도 흐름을 정리한 경험.

## 면접 예상 질문

- `GameManager`와 `ProgressState`를 왜 나눴는가?
- 감지 판정은 어떤 조건을 통과해야 하는가?
- 실패 처리 중복 실행은 어떻게 막는가?
- Treasure 퍼즐의 reset과 phase unlock은 어떻게 이어지는가?

## 4. 자소서에 쓰면 과장 위험인 항목

- 튜토리얼 또는 외부 예제를 그대로 사용한 부분은 직접 설계처럼 표현하지 않는다.
- 상용 수준 스텔스 AI를 구현했다.
- 모든 퍼즐을 완벽하게 구현했다.
- 모든 런타임 검증을 완료했다.
- AI/Codex 없이 전부 직접 작성했다.
- repo에 없는 `HideZone`, `PuzzleSafeZone`, Player 이동을 구현 완료로 쓴다.
