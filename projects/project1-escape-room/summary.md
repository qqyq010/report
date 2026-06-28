# Project 1 - Escape Room Summary

## 목적

개인 프로젝트의 핵심 목표, 구현 범위, 설명 가능한 근거를 정리한다.

## 현재 확정된 사실

- 개인 프로젝트.
- 사용자 제공 키워드: 퍼즐, 퍼즐 요소, 잠입 요소.
- 기존 공개 근거 위치: `portfolio/01-escape-room/`.
- canonical name은 `EscapeRoom`.
- 공개 가능한 핵심 C# 코드 10개가 `portfolio/01-escape-room/code/` 아래에 있다.
- Unity scene, prefab, Inspector binding, 최종 빌드 파일, 시연 영상은 현재 repo에 포함되어 있지 않다.

## 직접 구현 근거

- 게임 진행 상태 관리: `GameManager.cs`, `ProgressState.cs`
- 적 감지 구조: `EnemyVision.cs`, `DetectionController.cs`, `PlayerDetectionTarget.cs`
- 실패 처리와 체크포인트 복귀: `FailureHandler.cs`, `CheckpointManager.cs`, `CheckpointTrigger.cs`
- Treasure 퍼즐 구조: `TreasureGridManager.cs`, `TreasureEnemy.cs`
- 자세한 파일별 근거는 `source-file-map.md`와 `claim-evidence-map.md`를 따른다.

## 팀 결과물 / 협업 근거

- 개인 프로젝트 기준으로 팀 결과물/협업 기여 항목은 현재 없음.
- AI/Codex 사용 흔적은 `ai-codex-evidence.md`에 따라 분석/검토/문서화 보조로 분리한다.

## 확인 필요

- 프로젝트 기간, 사용 엔진/버전.
- 시연 가능한 빌드 또는 영상 위치.
- scene/prefab/Inspector 연결.
- `HideZone`, `PuzzleSafeZone`, Player 이동 구현 파일.
- `InputLockController`, `TreasureNode`, `TreasurePlayerMovement`, `TreasureTrigger`, enum 정의.
- Play Mode 또는 빌드 검증 근거.

## 자소서 활용 가능 포인트

- 개인 프로젝트에서 감지, 실패 처리, 체크포인트 복귀, 퍼즐 진행을 역할별 코드로 분리한 경험.
- 거리/각도/Raycast 기반 감지 구조를 잠입 요소 구현 사례로 설명 가능.
- 실패 후 복귀 흐름과 Treasure 퍼즐 reset/phase unlock을 문제 해결 사례로 사용 가능.

## 면접 예상 질문

- `GameManager`와 `ProgressState`를 왜 나눴는가?
- 감지는 거리, 각도, Raycast를 어떤 순서로 판정하는가?
- 감지 성공 후 실패 처리와 체크포인트 복귀는 어떻게 이어지는가?
- Treasure 퍼즐의 reset과 phase unlock은 어디서 관리하는가?

## 과장 위험 / 금지 표현

- 코드 근거가 없는 시스템을 구현했다고 표현하지 않는다.
- 모든 런타임 검증 완료, 상용 수준 스텔스 AI, 모든 퍼즐 완벽 구현이라고 표현하지 않는다.
