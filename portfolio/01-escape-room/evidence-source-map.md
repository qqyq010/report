# EscapeRoom 코드별 설명

## 감지와 실패 후 복귀

1. [EnemyVision](code/Enemy/EnemyVision.cs)은 플레이어와의 거리, 시야각, 벽 가림을 확인합니다.
2. [DetectionController](code/Enemy/DetectionController.cs)는 감지 결과를 실패 처리로 전달합니다.
3. [FailureHandler](code/Core/FailureHandler.cs)는 실패 처리가 중복되지 않도록 하고 입력 잠금과 복구 순서를 다룹니다.
4. [CheckpointManager](code/Core/CheckpointManager.cs)는 저장된 위치로 플레이어를 복귀시킵니다.

## 상태와 퍼즐 진행

- [GameManager](code/Core/GameManager.cs): 현재 상태에 따라 이동·상호작용·감지 처리를 허용할지 판단합니다.
- [ProgressState](code/Core/ProgressState.cs): 퍼즐 클리어와 탈출 조건을 관리합니다.
- [TreasureGridManager](code/Puzzle/TreasureGridManager.cs): 퍼즐의 진행, 초기화와 다음 단계 전환을 다룹니다.

[프로젝트 소개](README.md)
