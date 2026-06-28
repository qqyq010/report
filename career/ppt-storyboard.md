# PPT Storyboard

## 1. PPT 목적

- 강사님/멘토/면접관 검토용 발표 구조를 정리한다.
- 실제 PPTX를 만드는 단계가 아니라, 장표 흐름과 각 장에서 보여줄 메시지, 근거 자료 후보를 확정한다.
- PPT는 `career/technical-document-draft.md`의 흐름을 발표용으로 재구성한다.
- 자소서의 서사를 화면에서 방어 가능한 문제, 구조, 검증, 한계로 보여준다.
- 이미지, 영상, PDF, PPT 원본은 GitHub에 넣지 않고 Google Drive `center`에 보관한다.

## 2. 전체 발표 흐름

- 전체 흐름: Coin Laundry → Project3 Fisher → EscapeRoom
- 핵심 메시지: 기능 구현 자체보다 책임 분리와 검증 기준을 중요하게 보았다.
- Coin Laundry: Inventory/Shop의 상태 변경, 구매 실패, refund, merge 책임 분리 문제를 경험한 팀프로젝트1.
- Project3 Fisher: 같은 계열 문제를 더 큰 협업 구조와 검증 경계 문제로 확장한 팀프로젝트2 보조 근거.
- EscapeRoom: Unity/C# 기본 구현 역량과 코드 설명 근거를 보강하는 개인프로젝트.
- 발표 톤: 완성 성과 나열이 아니라 "어떤 문제를 어떻게 나누어 보았는가"를 설명한다.

## 3. 장표별 스토리보드

### Slide 1. 표지

* 핵심 메시지:
  - Unity/C# 부트캠프 프로젝트를 기술 기준으로 정리한 발표다.
* 들어갈 내용:
  - 제목: Unity/C# 부트캠프 프로젝트 기술 정리
  - 부제: Inventory/Shop 구조화, 검증 워크플로우, 감지/실패 처리 구현 경험
  - 이름
  - 지원 포지션: Unity 클라이언트 개발자
  - 프로젝트: Coin Laundry / Project3 Fisher / EscapeRoom
* 시각 자료 후보:
  - 세 프로젝트명을 같은 줄에 배치한 간단한 타이틀 구성
  - Unity/C# 키워드 태그
* 근거 경로:
  - `career/submission-doc-plan.md`
  - `career/technical-document-draft.md`
* 발표 시 말할 문장:
  - "이 발표는 세 프로젝트의 완성도를 과장하기보다, 기능을 다루며 책임과 검증 기준을 어떻게 나누었는지 정리한 자료입니다."
* 피해야 할 표현:
  - "세 프로젝트를 모두 완성도 높게 만들었습니다."
  - "전체 시스템을 설계했습니다."
* 보강 필요 자료:
  - 발표자 이름/지원 포지션 최종 표기
  - 제출용 표지 디자인 기준

### Slide 2. 전체 서사

* 핵심 메시지:
  - 팀프로젝트에서 상태 변경과 실패 처리 책임 분리를 경험하고, 이후 검증 경계와 코드 구현 근거로 확장했다.
* 들어갈 내용:
  - Coin Laundry: Inventory/Shop, UI 입력과 runtime state
  - Project3 Fisher: 검증 수준, 서버 경계, public evidence boundary
  - EscapeRoom: Unity/C# 상태/감지/실패/퍼즐 코드 근거
  - 근거 방어력: EscapeRoom > Coin Laundry > Project3 Fisher
* 시각 자료 후보:
  - 3단 흐름도: Coin Laundry → Project3 Fisher → EscapeRoom
  - 각 프로젝트 역할 태그
* 근거 경로:
  - `career/submission-doc-plan.md`
  - `career/technical-document-draft.md`
  - `career/self-introduction-draft.md`
* 발표 시 말할 문장:
  - "발표 순서는 팀프로젝트 중심으로 가지만, 직접 코드 근거가 필요한 부분은 EscapeRoom으로 보강하는 구조입니다."
* 피해야 할 표현:
  - "근거 강도와 발표 순서가 같다."
  - "Project3 Fisher를 메인 완성작으로 소개한다."
* 보강 필요 자료:
  - 프로젝트 기간, 팀 규모, 담당 역할 요약

### Slide 3. Coin Laundry - 맡은 범위와 문제

* 핵심 메시지:
  - Inventory/Shop은 단순 UI가 아니라 runtime state, 구매 실패, refund, merge 책임이 연결된 기능이었다.
* 들어갈 내용:
  - Inventory preview / commit
  - Shop spend / receive / refund
  - Merge 판정 / 실행
  - UI와 service 책임 분리
  - 현재 표현 기준: 담당 범위 후보와 설명 가능한 구조
* 시각 자료 후보:
  - Inventory/Shop 기능 영역을 UI, Runtime, Service로 나누는 블록 다이어그램
  - "UI에서 보이는 상태"와 "실제 데이터 상태" 비교 박스
* 근거 경로:
  - `projects/project2-coin-laundry/technical-evidence.md`
  - `projects/project2-coin-laundry/claim-evidence-map.md`
  - `projects/project2-coin-laundry/source-file-map.md`
* 발표 시 말할 문장:
  - "이 장에서는 전체 시스템 단독 구현이 아니라, Inventory/Shop에서 상태 변경 책임을 어떻게 나누어 보았는지를 설명합니다."
* 피해야 할 표현:
  - "전체 인벤토리/상점 시스템을 혼자 구현했습니다."
  - "모든 Play Mode 검증을 완료했습니다."
* 보강 필요 자료:
  - 작성자/커밋 근거
  - 팀 공개 승인
  - Play Mode 원본 로그
  - 시연 영상

### Slide 4. Coin Laundry - preview/commit, refund, merge 구조

* 핵심 메시지:
  - UI에서 보이는 상태와 실제 데이터 변경 시점을 분리하고, 실패 경로와 merge 책임을 따로 보았다.
* 들어갈 내용:
  - preview → commit
  - spend → receive → refund
  - CanMerge → TryMergeItems
  - UI는 입력/요청, service는 판정/실행
* 시각 자료 후보:
  - preview → commit 흐름도
  - spend → receive → refund 흐름도
  - CanMerge → TryMergeItems 책임 분리 도식
* 근거 경로:
  - `projects/project2-coin-laundry/technical-evidence.md`
  - `projects/project2-coin-laundry/source-file-map.md`
  - `projects/project2-coin-laundry/interview-points.md`
* 발표 시 말할 문장:
  - "성공 경로만 보면 단순 구매처럼 보이지만, receive 실패까지 보면 refund 경로와 상태 일관성을 같이 봐야 했습니다."
* 피해야 할 표현:
  - "상점 시스템 전체를 완성했습니다."
  - "merge/swap/restore 전체를 혼자 완성했습니다."
* 보강 필요 자료:
  - 실제 호출 순서
  - 실패 케이스 재현 로그
  - EventBus 또는 이벤트 연결 코드

### Slide 5. Coin Laundry - 검증과 한계

* 핵심 메시지:
  - 설명 가능한 구조는 정리했지만, 직접 구현 확정과 실행 검증은 분리했다.
* 들어갈 내용:
  - 문서 확인
  - sanitized evidence
  - 원본 코드/작성자/커밋 확인 필요
  - Play Mode 원본 로그 필요
  - 팀 승인 필요
* 시각 자료 후보:
  - 검증 수준 표: 문서 확인 / 코드 확인 / Play Mode / 빌드 / 확인 필요
  - "말할 수 있는 것"과 "보강 필요" 2열 표
* 근거 경로:
  - `career/claim-boundary.md`
  - `career/verification-needed.md`
  - `projects/project2-coin-laundry/interview-points.md`
* 발표 시 말할 문장:
  - "현재는 구조 설명과 근거 정리 단계까지 말하고, 직접 구현 확정은 작성자와 검증 로그 확인 후로 남겨 두었습니다."
* 피해야 할 표현:
  - "sanitized evidence가 있으니 직접 구현이 확정됐습니다."
  - "QA 전체를 담당했습니다."
* 보강 필요 자료:
  - 팀 담당표
  - 커밋/changeset
  - Play Mode A-K 로그

### Slide 6. Project3 Fisher - 더 큰 협업 구조에서 같은 문제를 다룸

* 핵심 메시지:
  - Project3 Fisher는 완성작이 아니라 검증/문서화/툴링/협업 경계 관리 사례다.
* 들어갈 내용:
  - Fisher/CSH
  - PlayFab / CloudScript
  - Balance workbook / validator 후보
  - UI resource pipeline
  - public evidence boundary
  - 팀 결과물과 개인 claim 분리
* 시각 자료 후보:
  - Fisher/CSH, PlayFab, Balance, UI Pipeline을 연결한 시스템 경계도
  - "기능 구현 claim"과 "검증/문서화 보조 근거" 구분 표
* 근거 경로:
  - `projects/project3-fisher/technical-evidence.md`
  - `projects/project3-fisher/claim-evidence-map.md`
  - `portfolio/03-project3-fisher/tools-and-verification.md`
* 발표 시 말할 문장:
  - "Project3는 완성작으로 내세우기보다, 팀 작업에서 검증 수준과 공개 범위를 먼저 나누는 방식의 근거로 사용합니다."
* 피해야 할 표현:
  - "완성 게임 포트폴리오입니다."
  - "서버 전체를 구현했습니다."
  - "PlayFab 전체를 설계했습니다."
* 보강 필요 자료:
  - 실제 담당 범위
  - `.cs` 근거 또는 sanitized excerpt
  - 팀 공개 승인

### Slide 7. Project3 Fisher - 검증 수준과 AI/Codex 사용 경계

* 핵심 메시지:
  - 코드 수정 전에 current-truth, verification queue, live proof를 분리하고, Codex/AI는 검토 보조로 제한했다.
* 들어갈 내용:
  - read-only scan
  - snippet append 금지
  - current-truth
  - verification queue
  - live proof
  - public evidence boundary
  - GitHub public summary / Drive original storage
* 시각 자료 후보:
  - current-truth → verification queue → live proof 흐름도
  - GitHub 요약 / Drive 원본 보관 분리도
* 근거 경로:
  - `projects/project3-fisher/interview-points.md`
  - `projects/project3-fisher/role-and-scope.md`
  - `projects/project3-fisher/technical-evidence.md`
  - `portfolio/03-project3-fisher/ai-assisted-workflow.md`
* 발표 시 말할 문장:
  - "AI 도구는 결과물을 대신 만든 근거가 아니라, 읽기 전용 확인과 검증 큐 정리에 제한해 사용했습니다."
* 피해야 할 표현:
  - "AI가 전부 구현했습니다."
  - "AI 결과를 제 직접 제작물로 사용했습니다."
  - "모든 검증을 완료했습니다."
* 보강 필요 자료:
  - 실제 반영 사례 로그
  - build/Play Mode/live proof 로그
  - CloudScript handler와 Unity caller

### Slide 8. EscapeRoom - Unity/C# 구현 근거

* 핵심 메시지:
  - 개인 프로젝트에서는 상태, 감지, 실패 처리, 체크포인트, 퍼즐 진행을 코드로 설명할 수 있다.
* 들어갈 내용:
  - GameState / ProgressState
  - EnemyVision
  - DetectionController / FailureHandler
  - CheckpointManager / CheckpointTrigger
  - TreasureGridManager / TreasureEnemy
* 시각 자료 후보:
  - 코드 파일 10개를 기능별로 묶은 맵
  - Core / Enemy / Player / Puzzle / World 영역 구분
* 근거 경로:
  - `projects/project1-escape-room/technical-evidence.md`
  - `projects/project1-escape-room/claim-evidence-map.md`
  - `projects/project1-escape-room/source-file-map.md`
  - `portfolio/01-escape-room/code/`
* 발표 시 말할 문장:
  - "EscapeRoom은 팀프로젝트에서 조심스럽게 표현해야 하는 부분을 개인 프로젝트 코드 근거로 보강하는 장입니다."
* 피해야 할 표현:
  - "모든 런타임 검증을 완료했습니다."
  - "전체 퍼즐 시스템을 완벽하게 구현했습니다."
* 보강 필요 자료:
  - Unity 버전
  - 프로젝트 기간
  - scene/prefab 연결

### Slide 9. EscapeRoom - 감지/실패/체크포인트/퍼즐 흐름

* 핵심 메시지:
  - EnemyVision은 거리, 각도, Raycast 순서로 감지 조건을 나누고, 실패 처리와 체크포인트 복귀를 분리했다.
* 들어갈 내용:
  - 거리 → 각도 → Raycast line-of-sight
  - DetectionController → FailureHandler
  - FailureHandler → CheckpointManager / CheckpointTrigger
  - TreasureGrid reset / phase unlock
* 시각 자료 후보:
  - EnemyVision 감지 순서 도식
  - Detection → FailureHandler → Checkpoint 복귀 흐름도
  - TreasureGrid reset / phase unlock 흐름도
* 근거 경로:
  - `projects/project1-escape-room/technical-evidence.md`
  - `projects/project1-escape-room/interview-points.md`
  - `portfolio/01-escape-room/code/Enemy/EnemyVision.cs`
  - `portfolio/01-escape-room/code/Core/FailureHandler.cs`
  - `portfolio/01-escape-room/code/Puzzle/TreasureGridManager.cs`
* 발표 시 말할 문장:
  - "감지, 실패 처리, 복귀를 한 스크립트에 몰지 않고 역할별로 나누어 설명할 수 있게 구성했습니다."
* 피해야 할 표현:
  - "상용 수준 스텔스 AI입니다."
  - "모든 적 AI를 직접 구현했습니다."
  - "scene 연결과 Play Mode까지 모두 확인했습니다."
* 보강 필요 자료:
  - layer/obstacle 설정
  - Play Mode 영상
  - Treasure 관련 누락 타입

### Slide 10. 세 프로젝트에서 정리한 개발 방식

* 핵심 메시지:
  - 세 프로젝트의 공통점은 책임 분리와 검증 수준 분리다.
* 들어갈 내용:
  - UI preview / commit 분리
  - spend / receive / refund 분리
  - Unity request / server response / live proof 분리
  - code 확인 / Play Mode / build / live proof 분리
  - detection / failure / checkpoint 분리
  - puzzle reset / phase unlock 분리
* 시각 자료 후보:
  - "분리한 책임" 6개를 카드 형태로 정리
  - 프로젝트별 책임 분리 매트릭스
* 근거 경로:
  - `career/technical-document-draft.md`
  - `career/self-introduction-draft.md`
* 발표 시 말할 문장:
  - "세 프로젝트를 관통하는 기준은 기능 이름이 아니라, 상태 변경과 실패 복구, 검증 수준을 어디서 나누는가였습니다."
* 피해야 할 표현:
  - "모든 문제를 해결했습니다."
  - "모든 검증을 완료했습니다."
* 보강 필요 자료:
  - 각 프로젝트별 실제 화면 캡처 후보
  - 대표 코드 캡처 후보

### Slide 11. 한계와 보강 예정

* 핵심 메시지:
  - 확인되지 않은 부분은 성과로 쓰지 않고, 보강 필요 자료로 분리한다.
* 들어갈 내용:
  - Coin Laundry: 작성자/커밋, Play Mode 로그, 팀 승인
  - Project3 Fisher: 실제 `.cs`, workbook, handler, live proof
  - EscapeRoom: scene/prefab, Play Mode, 시연 영상
  - GitHub에는 요약과 근거, Drive에는 원본/대용량 자료
* 시각 자료 후보:
  - 프로젝트별 보강 필요 표
  - GitHub / Drive 역할 분리 도식
* 근거 경로:
  - `career/verification-needed.md`
  - `career/claim-boundary.md`
  - `drive-links.md`
* 발표 시 말할 문장:
  - "확인되지 않은 내용은 억지로 성과로 쓰지 않고, 어떤 자료가 더 필요한지 분리해 두었습니다."
* 피해야 할 표현:
  - "확인 필요 항목도 제출용 성과로 말할 수 있습니다."
  - "원본 자료를 GitHub에 올리면 됩니다."
* 보강 필요 자료:
  - Drive 링크별 원본 자료 목록
  - 공개 전 민감정보 제거 체크

### Slide 12. 면접에서 방어할 핵심 질문

* 핵심 메시지:
  - 이 PPT는 성과 나열이 아니라 질문에 방어 가능한 근거를 정리한 자료다.
* 들어갈 내용:
  - preview와 commit을 왜 나눴는가?
  - 구매 실패 시 refund 흐름은 어떻게 잡았는가?
  - Project3를 왜 완성작이 아니라 보조 근거로 두는가?
  - PlayFab 요청/응답/live proof를 왜 나눴는가?
  - EnemyVision은 어떤 순서로 감지하는가?
  - FailureHandler와 Checkpoint는 어떻게 연결되는가?
* 시각 자료 후보:
  - 프로젝트별 면접 질문 카드
  - 질문 → 근거 경로 → 피해야 할 표현 표
* 근거 경로:
  - `projects/project2-coin-laundry/interview-points.md`
  - `projects/project3-fisher/interview-points.md`
  - `projects/project1-escape-room/interview-points.md`
  - `career/technical-document-draft.md`
* 발표 시 말할 문장:
  - "질문을 받으면 바로 완성 claim으로 답하지 않고, 제가 확인한 근거와 아직 확인 필요한 범위를 나누어 설명하겠습니다."
* 피해야 할 표현:
  - "제가 전부 했습니다."
  - "확인되지 않은 부분도 구현 완료입니다."
* 보강 필요 자료:
  - 면접용 1분 답변
  - 프로젝트별 코드 캡처
  - 시연 영상 타임스탬프

## 4. PPT에서 금지할 표현

- 전체 시스템을 설계했습니다.
- 전체 인벤토리/상점 시스템을 혼자 구현했습니다.
- 서버 전체를 구현했습니다.
- PlayFab 전체를 설계했습니다.
- 라이브 서비스를 운영했습니다.
- 전체 밸런스를 확정했습니다.
- 전체 UI 아트를 제작했습니다.
- 모든 검증을 완료했습니다.
- 모든 버그를 해결했습니다.
- QA 전체를 담당했습니다.
- 상용 수준으로 완성했습니다.
- 상용 수준 스텔스 AI를 구현했습니다.
- AI/Codex 없이 전부 직접 작성했습니다.
- AI가 만든 결과를 제 직접 제작물처럼 표현했습니다.
- Project3 Fisher를 완성 게임 포트폴리오로 표현합니다.
- Coin Laundry의 팀 결과물을 개인 단독 구현처럼 표현합니다.

## 5. Drive에 넣어야 할 원본 자료

- 이미지:
  - Coin Laundry 인벤토리/상점 화면 캡처
  - Project3 Fisher 검증/워크플로우 화면 캡처
  - EscapeRoom 감지/체크포인트/퍼즐 화면 캡처
- 영상:
  - Coin Laundry preview/commit, 구매 성공/실패, refund, merge 시연
  - EscapeRoom EnemyVision, FailureHandler, Checkpoint, Treasure Puzzle 시연
  - Project3 Fisher 관련 검증 흐름 또는 회의/설명 영상 후보
- PDF/PPT:
  - 발표 원본 PPT
  - 강사/팀 피드백 자료
  - 기존 포트폴리오 PDF 또는 기술문서 원본
- 코드 캡처:
  - `InventoryUIController.cs`, `InventoryRuntimeService.cs`, `InventoryMergeService.cs`, `ShopPurchaseService.cs` 공개 가능 범위
  - `GameManager.cs`, `ProgressState.cs`, `EnemyVision.cs`, `FailureHandler.cs`, `CheckpointManager.cs`, `TreasureGridManager.cs`
  - Project3 Fisher는 실제 `.cs` 또는 sanitized excerpt 확보 전까지 요약/문서 캡처 중심
- 기타:
  - Play Mode 로그
  - 빌드 로그
  - live proof
  - balance workbook / validator log
  - 팀 공개 승인 또는 면접 전용 사용 기준

## 6. 발표 전 확인할 질문

- Coin Laundry에서 Inventory/Shop을 어느 표현 수위까지 `담당 범위`로 말할 수 있는가?
- Coin Laundry 원본 코드, 작성자/커밋, Play Mode 로그를 발표 전에 확보할 수 있는가?
- Project3 Fisher를 보조 근거로 두는 흐름이 발표에서 자연스러운가?
- Project3 Fisher에서 PlayFab/CloudScript 관련 표현이 서버 구현 claim처럼 들리지 않는가?
- EscapeRoom의 scene/prefab/Play Mode/영상 근거를 발표 전에 확보할 수 있는가?
- PPT에 들어갈 화면 캡처와 영상은 Drive에 정리되어 있는가?
- 공개 repo에 올리면 안 되는 팀 원본 코드, PlayFab 설정, 개인정보, 유료 에셋이 섞이지 않았는가?
- 각 장표의 질문에 대해 근거 경로를 바로 열 수 있는가?
