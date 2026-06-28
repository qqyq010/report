# Application Source Packet

## 1. 현재 포지셔닝

- 지원 방향: Unity/C# 주니어 클라이언트 개발.
- 핵심 서술 기준: "내가 어떤 문제를 어떻게 만들고, 어떻게 나누고, 어떤 근거로 확인했는가"를 중심으로 쓴다.
- Project1 EscapeRoom은 개인 프로젝트 기반 메인 소재 후보로 사용한다.
- Project2 Coin Laundry는 팀 프로젝트의 기술/협업 보조 소재로 사용하되, 직접 구현 확정 표현은 보류한다.
- Project3 Fisher는 완성 게임 포트폴리오가 아니라 검증, 문서화, 툴링, 협업 경계 관리 보조 소재로만 사용한다.
- 모든 문장은 직접 구현, 팀 결과물/협업 기여, 확인 필요, 과장 위험을 분리한 뒤 작성한다.

## 2. 프로젝트별 사용 위치

### Project1 EscapeRoom

- 사용 위치: 자소서 메인 소재, 기술문서 핵심 사례, 면접 코드 설명.
- 근거: `projects/project1-escape-room/summary.md`, `implemented-by-me.md`, `claim-evidence-map.md`, `portfolio/01-escape-room/code/`.
- 안전한 표현:
  - Unity/C# 개인 프로젝트에서 잠입/퍼즐 탈출 흐름을 구현한 경험.
  - `GameState`와 `ProgressState`를 나눠 행동 가능 상태와 퍼즐 진행도를 분리한 경험.
  - `EnemyVision`에서 거리, 각도, Raycast line-of-sight를 순서대로 확인하는 감지 구조를 구현한 경험.
  - 감지 실패를 실패 처리와 체크포인트 복귀 흐름으로 연결한 경험.
  - Treasure 퍼즐의 path, reset, phase unlock 흐름을 코드로 관리한 경험.
- 금지 표현:
  - 상용 수준 스텔스 AI.
  - 모든 AI 로직 직접 구현.
  - 모든 런타임 검증 완료.
  - 모든 퍼즐 완벽 구현.
  - repo에 없는 HideZone, PuzzleSafeZone, Player 이동을 구현 완료로 표현.

### Project2 Coin Laundry

- 사용 위치: 제한 표현 기반 기술 보조 소재, 팀 프로젝트 협업 소재, 면접에서 구조 설명 후보.
- 근거: `projects/project2-coin-laundry/implemented-by-me.md`, `claim-evidence-map.md`, `code-evidence/`, `portfolio/02-coin-laundry/`.
- 안전한 표현:
  - 팀 프로젝트에서 인벤토리/상점 관련 담당 범위 후보를 근거별로 분리했다.
  - 인벤토리 preview와 commit 시점 분리 구조를 sanitized excerpt 기준으로 설명할 수 있다.
  - 상점 구매 실패 시 refund 흐름 후보를 코드 조각 기준으로 설명할 수 있다.
  - runtime inventory receive 흐름과 merge 판정/실행 책임 분리 후보를 면접 질문 대비용으로 정리했다.
  - 팀 원본 코드와 공개 가능한 sanitized evidence를 분리했다.
- 금지 표현:
  - 전체 인벤토리/상점 시스템 단독 구현.
  - 모든 버그 해결.
  - QA 전체 담당.
  - 팀 전체 코드 주도.
  - sanitized excerpt만으로 직접 구현이 확정됐다고 표현.

### Project3 Fisher

- 사용 위치: 검증/문서화/툴링/협업 경계 관리 보조 소재.
- 근거: `projects/project3-fisher/role-and-scope.md`, `claim-evidence-map.md`, `technical-evidence.md`, `portfolio/03-project3-fisher/`.
- 안전한 표현:
  - Project3는 완성 게임 포트폴리오가 아니라 검증, 문서화, 툴링 태도 보조 근거로 제한했다.
  - code 확인, build/self-test, Play Mode, live proof를 섞지 않고 분리해 기록했다.
  - AI/Codex를 구현 성과 대체가 아니라 분석, 검토, 검증 큐 관리 보조로 활용했다.
  - 팀 원본 코드, PlayFab 설정, 원본 로그를 public repo에 복사하지 않는 기준을 정리했다.
- 금지 표현:
  - 완성 게임 포트폴리오.
  - 서버/PlayFab 전체 설계.
  - 전체 밸런스 확정.
  - 모든 검증 완료.
  - 팀 전체 코드 주도.
  - AI 이미지 산출물을 직접 제작 그래픽처럼 표현.

## 3. 바로 사용 가능한 자소서 소재

- Project1: 개인 프로젝트에서 게임 진행 상태와 퍼즐 진행도를 분리한 경험.
  - 근거: `projects/project1-escape-room/claim-evidence-map.md`.
  - 표현 기준: 코드 구조 설명은 가능하나 scene/prefab/Play Mode 검증은 확인 필요로 분리한다.
- Project1: EnemyVision 기반 거리/각도/Raycast 감지 구조.
  - 근거: `portfolio/01-escape-room/code/Enemy/EnemyVision.cs`.
  - 표현 기준: 잠입 요소 감지 구조로 제한한다.
- Project1: 감지 실패, 실패 처리, 체크포인트 복귀 책임 분리.
  - 근거: `DetectionController.cs`, `FailureHandler.cs`, `CheckpointManager.cs`, `CheckpointTrigger.cs`.
  - 표현 기준: 실패 복구 흐름을 역할별 코드로 나눴다고 설명한다.
- Project1: Treasure 퍼즐의 reset과 phase unlock 관리.
  - 근거: `TreasureGridManager.cs`, `TreasureEnemy.cs`, `ProgressState.cs`.
  - 표현 기준: 모든 퍼즐 완성이 아니라 해당 퍼즐 흐름 관리로 제한한다.
- Project3: 검증 수준과 공개 범위를 분리한 작업 태도.
  - 근거: `projects/project3-fisher/claim-evidence-map.md`, `portfolio/03-project3-fisher/tools-and-verification.md`.
  - 표현 기준: 구현 성과가 아니라 협업/검증 태도 보조 소재로만 사용한다.

## 4. 제한 표현으로 사용 가능한 자소서 소재

- Project2: Inventory preview와 commit 분리.
  - 근거: `projects/project2-coin-laundry/code-evidence/`, `claim-evidence-map.md`.
  - 제한: 직접 구현 확정은 작성자/커밋/팀 승인 확인 전까지 금지.
- Project2: Shop 구매 실패 시 refund 흐름.
  - 근거: `ShopPurchaseService.purchase-refund.excerpt.cs`, `claim-evidence-map.md`.
  - 제한: 실제 실패 재현/검증 로그 확보 전까지 "후보" 또는 "설명 가능 구조"로 사용.
- Project2: Runtime inventory receive 흐름.
  - 근거: `InventoryRuntimeService.receive-flow.excerpt.cs`, `technical-evidence.md`.
  - 제한: 전체 런타임 인벤토리 설계 claim 금지.
- Project2: Merge 판정과 실행 책임 분리.
  - 근거: `InventoryMergeService.merge-responsibility.excerpt.cs`.
  - 제한: merge/swap/restore 전체 단독 완성 claim 금지.
- Project3: PlayFab 요청, 응답, 실패 복구, live proof 분리.
  - 근거: `projects/project3-fisher/cloudscript-evidence.md`, `portfolio/03-project3-fisher/evidence-source-map.md`.
  - 제한: 서버 구현, live 배포 완료, PlayFab 전체 설계 claim 금지.

## 5. 근거 보강 후 사용 가능한 소재

- Project1:
  - scene/prefab/Inspector 연결.
  - Play Mode 또는 빌드 검증.
  - HideZone, PuzzleSafeZone, Player 이동 구현 파일.
  - 시연 영상, 스크린샷, 발표자료.
- Project2:
  - 4개 핵심 파일의 작성자/커밋/팀 change log.
  - 팀 공개 승인 또는 면접 전용 사용 기준.
  - 구매 실패, refund, merge, preview/commit Play Mode 검증 로그.
  - EventBus 또는 이벤트 연결 코드.
- Project3:
  - Fisher/CSH 실제 담당 범위.
  - 실제 `.cs` 코드 또는 sanitized excerpt.
  - balance workbook, validator 실행 로그, CSV/JSON 계약 근거.
  - CloudScript handler, Unity caller, failure log, live proof.
  - UI/아트 파이프라인 지시문, 산출물, Unity 적용 근거.

## 6. 사용 금지 / 과장 위험 소재

- Project1:
  - 상용 수준 스텔스 AI.
  - 모든 AI 로직 직접 구현.
  - 모든 런타임 검증 완료.
  - 모든 퍼즐 완벽 구현.
- Project2:
  - 전체 인벤토리/상점 시스템 단독 구현.
  - 팀 전체 코드 주도.
  - 모든 버그 해결.
  - QA 전체 담당.
  - 직접 구현 확정 전 단독 구현 표현.
- Project3:
  - 완성 게임 포트폴리오.
  - 서버/PlayFab 전체 설계.
  - 전체 밸런스 확정.
  - 모든 검증 완료.
  - 팀 전체 코드 주도.
  - AI 산출물을 본인 직접 제작물처럼 표현.

## 7. 이력서 키워드 후보

### 사용 가능 후보

- Unity
- C#
- Game state management
- Progress state
- Raycast line-of-sight
- Enemy detection
- Checkpoint
- Puzzle reset / phase unlock
- Failure handling
- Portfolio evidence documentation
- Verification level separation

### 제한 표현 후보

- Unity UI
- Inventory
- Shop
- Runtime inventory state
- Merge responsibility
- Sanitized code evidence
- Team project evidence boundary
- AI-assisted workflow
- Public evidence boundary

### 확인 필요 후보

- EventBus
- Play Mode verification
- Build verification
- CloudScript
- PlayFab
- Balance workbook
- UI/Art pipeline
- Fisher / CSH 담당 기능

## 8. 면접 예상 질문 후보

- Project1:
  - `GameManager`와 `ProgressState`를 왜 나눴는가?
  - 감지는 거리, 각도, Raycast를 어떤 순서로 판정하는가?
  - 감지 성공 후 실패 처리와 체크포인트 복귀는 어떻게 이어지는가?
  - Treasure 퍼즐의 reset과 phase unlock은 어디서 관리하는가?
  - AI/Codex는 구현에 어떤 방식으로 보조 역할을 했는가?
- Project2:
  - preview와 commit을 분리한 이유는 무엇인가?
  - 구매 실패 시 refund는 어떤 순서로 동작하는가?
  - runtime inventory receive 실패는 어떻게 처리되는가?
  - merge 판정과 실행 책임은 왜 분리했는가?
  - 이 구조를 본인이 직접 구현했다고 말할 수 있는 근거는 무엇인가?
- Project3:
  - Project3를 왜 메인 완성작이 아니라 보조 근거로 두는가?
  - code/build/Play Mode/live proof를 왜 분리했는가?
  - PlayFab 문제를 Unity 요청, 서버 응답, live proof로 어떻게 나누어 봤는가?
  - AI/Codex 활용과 본인 판단/검수의 경계는 무엇인가?
  - 팀 원본 코드와 공개 evidence 경계는 어떻게 관리했는가?

## 9. 추가로 받아야 할 자료

- Project1:
  - 프로젝트 기간, Unity 버전.
  - 시연 영상, 스크린샷, 발표자료.
  - scene/prefab/Inspector 연결 근거.
  - Play Mode 또는 빌드 검증 로그.
  - HideZone, PuzzleSafeZone, Player 이동 코드.
- Project2:
  - 4개 핵심 파일의 작성자/커밋/팀 change log.
  - 팀 공개 승인 또는 면접 전용 사용 기준.
  - Play Mode 검증 로그.
  - EventBus, UI 연결, 재화 처리 관련 추가 코드.
  - 발표 PPT, 영상, 강사/팀 피드백.
- Project3:
  - Fisher/CSH 담당 범위 문서.
  - 실제 코드 또는 sanitized excerpt.
  - balance workbook과 validator 실행 로그.
  - CloudScript handler, Unity caller, failure/live proof 로그.
  - UI/아트 파이프라인 지시문과 적용 근거.

## 10. 자소서 작성 시 표현 규칙

- 먼저 Project1에서 문제, 구현, 검증 한계를 중심으로 메인 서사를 만든다.
- Project2는 팀 프로젝트 기술 소재로 쓰되 "담당 범위 후보", "설명 가능한 구조", "확인 필요"를 분리한다.
- Project3는 구현 성과가 아니라 검증 수준 관리, 공개 범위 관리, AI/Codex 운용 태도 보조 소재로만 쓴다.
- 직접 구현이 확정되지 않은 항목은 "직접 구현했다"가 아니라 "담당 범위 후보", "구조를 설명할 수 있다", "근거를 분리했다"로 낮춘다.
- 코드 확인, 문서 확인, Play Mode 확인, 빌드 확인, live proof를 한 문장 안에서 섞지 않는다.
- 팀 결과물은 개인 단독 성과처럼 쓰지 않는다.
- Drive 원본, 대용량 파일, 민감정보, 팀 원본 코드는 GitHub에 복사하지 않는다.
- 자소서 본문을 작성할 때는 각 문장마다 근거 경로와 금지 표현을 대조한다.
