# EscapeRoom 기능별 코드 발췌

주요 기능의 처리 흐름을 짧게 살펴볼 수 있도록 정리한 코드 예시입니다.

| 기능 | 코드 |
|---|---|
| 게임 상태와 행동 가능 여부 | [GameManager](GameManager_sample.cs) |
| 퍼즐 진행도와 탈출 조건 | [ProgressState](ProgressState_sample.cs) |
| 실패 원인과 복구 흐름 | [FailureHandler](FailureHandler_sample.cs) |
| 체크포인트 복귀 | [CheckpointManager](CheckpointManager_sample.cs) |
| 거리·시야각·벽 가림에 따른 감지 | [EnemyVision](EnemyVision_sample.cs) |
| 조준·마우스 위치 기반 상호작용 | [PlayerInteraction](PlayerInteraction_sample.cs) |
| 입력과 카메라 방향에 따른 이동 | [PlayerMove](PlayerMove_sample.cs) |

[EscapeRoom 소개와 주요 코드](../../../../portfolio/01-escape-room/README.md)
