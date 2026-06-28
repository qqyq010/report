# Submission Package Index

## 1. 제출 전 검토용 문서

* 기술문서:
  * 경로: `career/technical-document-draft.md`
  * 역할: 자소서와 PPT의 기준 문서.
  * 사용 시점: claim 강도, 근거 경로, 검증 수준, 확인 필요 항목을 먼저 확인할 때 사용한다.

* 자소서:
  * 경로: `career/self-introduction-draft.md`
  * 역할: 기술문서의 서사를 1500~2000자 범위로 압축한 초안.
  * 사용 시점: 강사님/멘토에게 문장 흐름, 표현 수위, 제출 가능성을 검토받을 때 사용한다.

* PPT 스토리보드:
  * 경로: `career/ppt-storyboard.md`
  * 역할: 기술문서의 흐름을 10~12장 발표 구조로 재구성한 문서.
  * 사용 시점: 실제 PPTX 제작 전 장표 흐름, 시각 자료 후보, 피해야 할 표현을 확인할 때 사용한다.

## 2. 문서 간 관계

자소서 ← 기술문서 → PPT

- 기술문서는 기준 문서다.
- 자소서는 기술문서의 핵심 서사를 읽히는 글로 압축한다.
- PPT 스토리보드는 기술문서의 흐름을 발표 장표로 재구성한다.
- 세 문서는 모두 Coin Laundry -> Project3 Fisher -> EscapeRoom 순서를 유지한다.
- 단, 근거 방어력은 EscapeRoom > Coin Laundry > Project3 Fisher로 구분한다.

## 3. 프로젝트별 핵심 메시지

### Coin Laundry

- 사용 위치: 팀프로젝트1 기술 소재.
- 핵심 메시지: Inventory/Shop에서 UI 입력, runtime state, 구매 실패, refund, merge 책임이 섞일 수 있어 preview/commit, spend/receive/refund, 판정/실행 책임을 나누어 설명한다.
- 표현 수위: 담당 범위 후보, 설명 가능한 구조, 문서 근거 기준.
- 확인 필요: 작성자/커밋, 팀 승인, 원본 코드, Play Mode 로그, 시연 영상.

### Project3 Fisher

- 사용 위치: 팀프로젝트2 보조 소재.
- 핵심 메시지: 완성 게임 포트폴리오가 아니라 검증/문서화/툴링/협업 경계 관리 사례로 사용한다.
- 표현 수위: current-truth, verification queue, live proof, public evidence boundary를 분리한 작업 기준.
- 확인 필요: Fisher/CSH 담당 범위, 실제 `.cs` 근거, CloudScript handler, Unity caller, balance workbook, live proof.

### EscapeRoom

- 사용 위치: 개인 프로젝트 기반 코드 방어 소재.
- 핵심 메시지: 상태 관리, EnemyVision 감지, 실패 처리, 체크포인트, Treasure 퍼즐 흐름을 Unity/C# 코드 근거로 설명한다.
- 표현 수위: 코드 확인 기준의 직접 구현 후보.
- 확인 필요: scene/prefab/Inspector 연결, Play Mode, 빌드, 시연 영상, HideZone/PuzzleSafeZone/Player 이동 코드.

## 4. 제출 전 확인할 자료

- Coin Laundry:
  - 4개 핵심 파일의 작성자/커밋/팀 change log.
  - Inventory/Shop 시연 영상.
  - 구매 실패, refund, merge, preview/commit Play Mode 로그.
  - 팀 공개 승인 또는 면접 전용 사용 기준.

- Project3 Fisher:
  - Fisher/CSH 담당 범위 문서.
  - 실제 코드 또는 sanitized excerpt.
  - CloudScript handler, Unity caller, failure/live proof 로그.
  - balance workbook, validator log, UI/아트 파이프라인 적용 근거.

- EscapeRoom:
  - 프로젝트 기간과 Unity 버전.
  - scene/prefab/Inspector 연결 근거.
  - Play Mode 또는 빌드 검증 로그.
  - 시연 영상, 스크린샷, 발표자료.

- 공통:
  - Drive `center`에 원본 PPT, PDF, 이미지, 영상, 압축파일 보관.
  - GitHub에는 공개 가능한 요약, markdown, 코드 근거만 보관.
  - 공개 전 API Key, Secret, Token, PlayFab 설정, 개인정보, 팀원 개인정보, 유료 에셋 원본 제거 확인.

## 5. 강사님께 검토받을 질문

- Coin Laundry의 Inventory/Shop 표현을 어느 수준까지 `담당 범위`로 말해도 되는가?
- Project2 직접 구현 확정은 보류하고 제한 표현으로 쓰는 현재 기준이 안전한가?
- Project3 Fisher를 완성작이 아니라 검증/문서화/툴링 보조 근거로 배치한 흐름이 자연스러운가?
- EscapeRoom을 마지막에 배치해 코드 방어 근거로 쓰는 구성이 설득력 있는가?
- 자소서 본문이 사람됨보다 실제 구현, 책임 분리, 실패 경로, 검증 기준 중심으로 읽히는가?
- PPT 스토리보드에서 각 장표의 메시지와 근거 경로가 바로 연결되는가?
- 제출 전 반드시 Drive에 보강해야 할 원본 자료가 무엇인가?

## 6. 금지 표현 체크리스트

- 전체 시스템 설계.
- 전체 인벤토리/상점 시스템 단독 구현.
- 서버 전체 구현.
- PlayFab 전체 설계.
- 라이브 서비스 운영.
- 전체 밸런스 확정.
- 전체 UI 아트 제작.
- 모든 검증 완료.
- 모든 버그 해결.
- QA 전체 담당.
- 상용 수준 완성.
- 상용 수준 스텔스 AI.
- AI/Codex 없이 전부 직접 작성.
- AI가 만든 결과를 직접 제작물처럼 표현.
- Project3 Fisher를 완성 게임 포트폴리오로 표현.
- Coin Laundry 팀 결과물을 개인 단독 구현처럼 표현.
