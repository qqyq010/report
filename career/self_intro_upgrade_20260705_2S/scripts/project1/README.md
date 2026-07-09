# Project1 Sanitized Script Samples

이 폴더는 Project1 개인프로젝트의 공개 검수용 C# sample 모음이다. 원본 전체 코드가 아니라 포트폴리오에서 설명할 핵심 구조만 남긴 sanitized sample이다.

## Sample 목록

| Sample file | 원본 후보 파일명 | 포트폴리오 주장 |
| --- | --- | --- |
| `GameManager_sample.cs` | `Core/GameManager.cs` | 게임 상태와 플레이 흐름을 관리했다 |
| `ProgressState_sample.cs` | `Core/ProgressState.cs` | 퍼즐 클리어, Phase unlock, Exit unlock 같은 진행 상태를 분리했다 |
| `FailureHandler_sample.cs` | `Core/FailureHandler.cs` | 실패 원인, 복구 액션, 복귀 상태를 분리했다 |
| `CheckpointManager_sample.cs` | `Core/CheckpointManager.cs` | 실패 후 재도전 가능한 체크포인트 복구 흐름을 구성했다 |
| `EnemyVision_sample.cs` | `Enemy/EnemyVision.cs` | 감지 판정을 거리, 각도, line-of-sight 조건으로 나누었다 |
| `PlayerInteraction_sample.cs` | `Player/PlayerInteraction.cs` | 중심 조준/마우스 위치 기반 상호작용 흐름을 분리했다 |
| `PlayerMove_sample.cs` | `Player/PlayerMove.cs` | 기본 이동 입력과 카메라 기준 이동 방향 계산을 구성했다 |

## 공개용으로 제거한 항목 요약

- 원본 프로젝트의 전체 구현 세부
- Inspector 정리용 주석과 디버그 로그/시각화 관련 코드
- 외부 에셋, 씬 오브젝트, 로컬 환경에 묶인 참조
- 발표 주장과 직접 관련 없는 사운드, 애니메이터, step assist, validation 세부
- 원본 클래스의 singleton, scene persistence, editor-only migration 세부

## PPT 연결용 파일명

개인프로젝트 PPT에서는 다음 파일명을 코드 근거로 연결할 수 있다.

- `GameManager_sample.cs`
- `ProgressState_sample.cs`
- `FailureHandler_sample.cs`
- `CheckpointManager_sample.cs`
- `EnemyVision_sample.cs`
- `PlayerInteraction_sample.cs`
- `PlayerMove_sample.cs`

## 주의

이 폴더의 코드는 공개 검토용 sample이다. 원본 전체 소스, 전체 Unity 프로젝트 구조, 전체 런타임 검증 결과를 대체하지 않는다.
