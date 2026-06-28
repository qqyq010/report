# Project 1 - Source File Map

## 목적

EscapeRoom 공개 코드 파일을 자소서, 이력서, 면접 근거로 사용할 수 있는지 파일별로 정리한다.

## 기준

- Canonical name: `EscapeRoom`
- 프로젝트 유형: 개인 프로젝트
- 공개 포트폴리오 근거: `portfolio/01-escape-room/`
- 공개 코드 위치: `portfolio/01-escape-room/code/`
- Scene, prefab, Inspector binding, 실행 영상, 빌드 파일은 현재 repo에 없다.

## Source File Map

| 파일명 | repo 내 경로 | 관련 기능 | 핵심 역할 | 직접 구현 근거 가능성 | AI/Codex 보조 여부 | 공개 가능 여부 | 민감정보 포함 여부 | 자소서 활용 가능성 | 면접 질문 가능성 | 확인 필요 사항 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| `GameManager.cs` | `portfolio/01-escape-room/code/Core/GameManager.cs` | 게임 상태, 퍼즐 진행도 접근 | `GameState`와 `ProgressState`를 통해 이동, 회전, 상호작용, 감지 가능 상태를 분리 | 높음. 개인 프로젝트 공개 코드 근거 | AI/Codex 분석 대조 후보 | 공개 코드로 사용 가능 | 민감정보 없음 | 가능. 상태 관리 소재 | 높음 | enum 정의, scene 연결, Play Mode 검증 |
| `ProgressState.cs` | `portfolio/01-escape-room/code/Core/ProgressState.cs` | 퍼즐 클리어, Phase2, Exit unlock | 퍼즐 진행 플래그를 `GameManager`의 현재 상태와 분리 | 높음 | 코드 내 AI/Codex 흔적 없음 | 공개 코드로 사용 가능 | 민감정보 없음 | 가능. 진행도 관리 소재 | 높음 | 실제 unlock 조건과 scene 반영 |
| `FailureHandler.cs` | `portfolio/01-escape-room/code/Core/FailureHandler.cs` | 실패 처리, 입력 잠금, 복구 | 실패 중복 실행을 막고 실패 원인별 복구 profile 적용 | 높음 | AI/Codex 분석 대조 후보 | 공개 코드로 사용 가능 | `lockToken` 변수명 false positive 외 민감정보 없음 | 가능. 실패 복구 소재 | 높음 | `InputLockController`, enum 정의, 실패 연출 |
| `CheckpointManager.cs` | `portfolio/01-escape-room/code/Core/CheckpointManager.cs` | 체크포인트 저장/복귀 | 저장된 checkpoint로 player root 위치/회전 복구 | 높음 | 코드 내 AI/Codex 흔적 없음 | 공개 코드로 사용 가능 | 민감정보 없음 | 가능. 실패 후 복귀 소재 | 높음 | player root 연결, Rigidbody/physics sync 검증 |
| `EnemyVision.cs` | `portfolio/01-escape-room/code/Enemy/EnemyVision.cs` | 적 시야 감지 | 거리, 각도, Raycast line-of-sight 순서로 감지 판정 | 높음 | AI/Codex 분석 대조 후보 | 공개 코드로 사용 가능 | 민감정보 없음 | 가능. 잠입 요소 소재 | 높음 | layer mask, view origin, Play Mode 검증 |
| `DetectionController.cs` | `portfolio/01-escape-room/code/Enemy/DetectionController.cs` | 감지 결과 연결 | 감지 대상 player root 확인 후 `FailureHandler`로 실패 전달 | 높음 | 코드 내 AI/Codex 흔적 없음 | 공개 코드로 사용 가능 | 민감정보 없음 | 가능. 감지와 실패 연결 소재 | 높음 | 감지 누적/피드백 여부, debug ignore 사용 범위 |
| `PlayerDetectionTarget.cs` | `portfolio/01-escape-room/code/Player/PlayerDetectionTarget.cs` | 감지 target transform | 플레이어 root 대신 안정적인 target transform을 제공 | 중간 | 코드 내 AI/Codex 흔적 없음 | 공개 코드로 사용 가능 | 민감정보 없음 | 보조 소재 가능 | 중간 | 실제 player hierarchy, Player 이동 구현 파일 |
| `TreasureGridManager.cs` | `portfolio/01-escape-room/code/Puzzle/TreasureGridManager.cs` | Treasure 퍼즐, path, reset, phase unlock | 노드 등록, path 생성, reset, puzzle solved, Phase unlock 연결 | 높음 | AI/Codex 분석 대조 후보 | 공개 코드로 사용 가능 | 민감정보 없음 | 가능. 퍼즐 상태 관리 소재 | 높음 | `TreasureNode`, `TreasurePlayerMovement`, `TreasureTrigger`, scene 연결 |
| `TreasureEnemy.cs` | `portfolio/01-escape-room/code/Puzzle/TreasureEnemy.cs` | 퍼즐 내부 추적 적 | 플레이어 이전 노드 기록을 지연 추적하고 충돌 시 puzzle reset | 높음 | 코드 내 AI/Codex 흔적 없음 | 공개 코드로 사용 가능 | 민감정보 없음 | 가능. 퍼즐 실패 조건 소재 | 높음 | `TreasurePlayerMovement`, node 연결, 충돌 검증 |
| `CheckpointTrigger.cs` | `portfolio/01-escape-room/code/World/CheckpointTrigger.cs` | 체크포인트 trigger | Player tag/root 기준으로 checkpoint 갱신 | 중간 | 코드 내 AI/Codex 흔적 없음 | 공개 코드로 사용 가능 | 민감정보 없음 | 보조 소재 가능 | 중간 | trigger 배치, Player tag, scene 연결 |

## 확인 필요

- 프로젝트 기간과 Unity 버전.
- 실제 scene/prefab/Inspector 연결.
- Play Mode 또는 빌드 검증 근거.
- 시연 영상, 발표 자료, 스크린샷 위치.
- `HideZone`, `PuzzleSafeZone`, Player 이동 구현 파일.
- `InputLockController`, `TreasureNode`, `TreasurePlayerMovement`, `TreasureTrigger`, enum 정의.

## 과장 위험 / 금지 표현

- 공개 코드만으로 모든 런타임 검증 완료라고 쓰지 않는다.
- 상용 수준 스텔스 AI라고 쓰지 않는다.
- repo에 없는 `HideZone`, `PuzzleSafeZone`, Player 이동을 구현 완료로 쓰지 않는다.
