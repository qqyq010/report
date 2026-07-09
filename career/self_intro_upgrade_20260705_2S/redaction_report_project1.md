# Project1 Redaction Report

## 목적

Project1 개인프로젝트의 공개 가능한 C# 코드 근거를 만들기 위해, 원본 스크립트에서 대표 흐름만 추출한 sanitized sample을 생성했다.

## 생성한 파일 목록

| 생성 파일 | 원본 후보 파일명 | 원본 존재 여부 |
| --- | --- | --- |
| `scripts/project1/GameManager_sample.cs` | `Core/GameManager.cs` | 존재 |
| `scripts/project1/ProgressState_sample.cs` | `Core/ProgressState.cs` | 존재 |
| `scripts/project1/FailureHandler_sample.cs` | `Core/FailureHandler.cs` | 존재 |
| `scripts/project1/CheckpointManager_sample.cs` | `Core/CheckpointManager.cs` | 존재 |
| `scripts/project1/EnemyVision_sample.cs` | `Enemy/EnemyVision.cs` | 존재 |
| `scripts/project1/PlayerInteraction_sample.cs` | `Player/PlayerInteraction.cs` | 존재 |
| `scripts/project1/PlayerMove_sample.cs` | `Player/PlayerMove.cs` | 존재 |
| `scripts/project1/README.md` | 새 검수 문서 | 해당 없음 |

## 제거한 정보 유형

- 원본 프로젝트 전용 씬/Inspector 참조 세부
- 로컬 환경이나 외부 에셋에 묶일 수 있는 참조
- 디버그 로그, 디버그 ray, debug override, editor migration 세부
- 사운드, 애니메이터, 하이라이트 표시 등 핵심 주장과 직접 관련 없는 코드
- 불필요하게 긴 주석과 내부 설명
- 원본 전체 파일을 유추하게 만드는 부수 구현

## 남긴 핵심 메서드와 흐름

- `GameManager_sample.cs`
  - `SetState`
  - `RestoreNormalState`
  - `IsPuzzleCleared`
  - `MarkPuzzleCleared`

- `ProgressState_sample.cs`
  - `MarkPuzzleCleared`
  - `IsPuzzleCleared`
  - `UnlockPhase2AndExit`

- `FailureHandler_sample.cs`
  - `HandleFailure`
  - `HandleFailureRoutine`
  - `FindProfile`
  - `ApplyRecovery`

- `CheckpointManager_sample.cs`
  - `SetCheckpoint`
  - `RestorePlayerToCheckpoint`

- `EnemyVision_sample.cs`
  - `Update`
  - `IsInRange`
  - `IsInsideViewAngle`
  - `HasLineOfSight`

- `PlayerInteraction_sample.cs`
  - `SetInteractionEnabled`
  - `SetRayMode`
  - `TryInteract`
  - `TryGetInteractableHit`
  - `IsWithinInteractDistance`

- `PlayerMove_sample.cs`
  - `Update`
  - `FixedUpdate`
  - `SetMovementEnabled`
  - `ResolveMoveDirection`

## 공개 전 추가 검수 필요 항목

- sample 코드가 PPT의 설명 문장과 정확히 대응하는지 확인 필요
- GitHub 업로드 전에 전체 공개 폴더에서 개인 경로, 팀 코드, 민감 로그가 섞이지 않았는지 재검색 필요
- README 링크를 실제 GitHub 경로에 맞게 갱신 필요
- sample 코드가 원본 전체 구현이 아니라는 문구가 GitHub README 상단에도 보이게 해야 함

## 1차 검증 결과

- 모든 `*_sample.cs` 파일의 첫 줄에 필수 sanitized 주석이 있음을 확인했다.
- `*_sample.cs` 파일에서 로컬 절대 경로, 사용자 폴더, 원본 프로젝트 경로, `Assets` 경로 패턴이 검색되지 않았다.
- 모든 `*_sample.cs` 파일의 중괄호 개수가 균형을 이루는지 확인했다.
- 원본 후보 7개 파일은 읽기만 했고, 작업 후 수정 시간과 해시를 다시 확인했다.
- GitHub 공개 저장소에는 `git status --short`만 실행했고, add, commit, push는 수행하지 않았다.

## 2026-07-09 소형 보정 내역

- `FailureHandler_sample.cs`에 `Project1GameManagerSample` 참조를 추가했다.
- `FailureHandler_sample.cs`의 `ApplyRecovery`에서 체크포인트 복구 후 `RestoreState`를 `SetState`로 적용하도록 보강했다.
- `PlayerInteraction_sample.cs`의 공개용 인터페이스 이름을 C# 관례에 맞춰 `IProject1InteractableSample`로 변경했다.
- `README.md`의 `FailureHandler_sample.cs` 설명을 "실패 원인, 복구 액션, 복귀 상태를 분리했다"로 보강했다.

## 2026-07-09 소형 보정 검증 결과

- 모든 `*_sample.cs` 파일의 첫 줄에 필수 sanitized 주석이 유지됨을 확인했다.
- 공개 draft의 Project1 sample과 redaction report에서 지정된 민감/경로 키워드가 검색되지 않았다.
- 모든 `*_sample.cs` 파일의 중괄호 개수가 균형을 이루는지 확인했다.
- `FailureHandler_sample.cs`에서 `RestoreState`가 `SetState(profile.RestoreState)` 호출로 실제 사용됨을 확인했다.
- GitHub 공개 저장소에는 `git status --short --branch`만 실행했고, add, commit, push는 수행하지 않았다.

## 수정하지 않은 파일 목록

- 원본 `Core/GameManager.cs`
- 원본 `Core/ProgressState.cs`
- 원본 `Core/FailureHandler.cs`
- 원본 `Core/CheckpointManager.cs`
- 원본 `Enemy/EnemyVision.cs`
- 원본 `Player/PlayerInteraction.cs`
- 원본 `Player/PlayerMove.cs`
- 기존 PPT 파일
- 기존 DOCX 파일
- GitHub 공개 저장소 파일
- Project2 코드
- Project3 코드

## 수행하지 않은 검증

- Unity Editor 열기
- Play Mode 실행
- sample 코드 단독 컴파일
- GitHub 업로드
- Git add, commit, push
- PPT/DOCX 링크 반영
