# Submission Document Plan

## 1. 목표

- 취업 제출 전 강사님, 멘토, 면접관 검토를 받을 수 있는 수준의 기술문서, 자소서, PPT 작성 기준을 확정한다.
- 이번 문서는 완성본이 아니라 작성 기준 문서다.
- 중심 문서는 기술문서이며, 자소서와 PPT는 기술문서를 각각 글과 발표 화면으로 재구성한다.
- 모든 표현은 `직접 구현`, `팀 결과물/협업 기여`, `확인 필요`, `과장 위험`을 분리한 뒤 사용한다.
- 문서 서사는 팀프로젝트 중심으로 시작하되, 직접 구현 방어가 필요한 지점은 EscapeRoom 코드 근거로 보강한다.

## 2. 최종 산출물

* 기술문서
  - 자소서와 PPT의 기준 문서.
  - 프로젝트별 문제, 설계, 구현, 검증, 한계를 근거 경로와 함께 정리한다.
  - claim마다 코드/문서/검증 수준을 연결한다.
* 자소서
  - 기술문서의 핵심 서사를 1500~2000자 분량의 사람에게 읽히는 글로 압축한다.
  - 사람됨보다 "무엇을 만들었고 어떻게 해결했는가"를 중심으로 쓴다.
  - 감정 표현은 구현 과정과 판단을 설명하는 데 필요한 범위에서만 사용한다.
* PPT
  - 기술문서의 흐름을 10~12장 발표용 화면으로 재구성한다.
  - 코드 세부보다 문제, 구조, 검증, 한계를 시각적으로 보여준다.
  - 각 장마다 근거 경로, 스크린샷, 영상, 코드 발췌 후보를 연결한다.

## 3. 기술문서가 중심인 이유

- 기술문서는 모든 claim의 기준 문서다.
- 자소서는 기술문서의 서사를 읽히는 문장으로 압축한 결과물이다.
- PPT는 기술문서의 핵심 흐름을 발표용 화면으로 바꾼 결과물이다.
- 기술문서가 약하면 자소서는 감정문으로 흐르고, PPT는 화면 나열이 된다.
- 기술문서에서 먼저 문제, 설계, 구현, 검증, 한계를 분리해야 자소서와 PPT의 과장 위험을 줄일 수 있다.

## 4. 전체 서사

Coin Laundry → Project3 Fisher → EscapeRoom

- Coin Laundry에서 Inventory / Shop을 맡으며 UI 입력, runtime state 반영, 구매 실패, refund, merge 책임 분리 문제를 경험한 흐름으로 시작한다.
- Project3 Fisher에서는 같은 인벤토리/상점/데이터 계열 문제를 더 큰 협업 구조에서 다루며 검증 수준, 서버 요청/응답, 공개 가능 근거, Codex 활용 기준을 분리한 경험으로 확장한다.
- EscapeRoom은 개인 프로젝트로서 Unity/C# 기본 구현 역량과 상태, 감지, 실패 처리, 체크포인트, 퍼즐 구조를 코드로 설명할 수 있는 방어 근거로 배치한다.
- 주의: 서사 순서는 Coin Laundry → Project3 Fisher → EscapeRoom이지만, 근거 방어력은 EscapeRoom > Coin Laundry > Project3 Fisher다.

## 5. 프로젝트별 사용 위치

### Coin Laundry

* 문서 내 위치:
  - 기술문서의 첫 번째 핵심 장.
  - 팀프로젝트1의 인벤토리/상점 중심 기술 사례.
  - 자소서에서는 "팀 프로젝트에서 UI 입력과 상태 변경 책임을 분리하려 한 경험"으로 사용한다.
  - PPT에서는 문제 상황, 구조 분리, 실패 경로, 검증 한계를 먼저 보여준다.
* 강조할 내용:
  - Inventory preview / commit 분리.
  - Shop 구매 실패 시 refund 흐름.
  - Runtime receive 흐름.
  - Merge 판정과 실행 책임 분리.
  - UI 입력과 runtime state 반영 시점 분리.
  - 팀 프로젝트에서 공개 가능 근거와 원본 코드 경계 관리.
* 안전한 표현:
  - 담당 범위에서 인벤토리와 상점 흐름을 구조화했다.
  - UI preview와 실제 상태 반영 시점을 분리해 설명 가능한 구조로 정리했다.
  - 구매 실패 시 재화 복구 흐름까지 고려해 spend, receive, refund 순서를 나눠 보았다.
  - merge 판정과 실행 책임을 분리해 UI와 service 책임을 구분했다.
  - sanitized excerpt 기준으로 설명 가능한 구조를 정리했다.
* 금지 표현:
  - 전체 인벤토리/상점 시스템 단독 구현.
  - 팀 전체 시스템 설계.
  - 모든 버그 해결.
  - QA 전체 담당.
  - 모든 Play Mode 검증 완료.
  - 작성자/커밋/팀 승인 전 직접 구현 확정 표현.
* 보강 필요 자료:
  - `InventoryUIController.cs`, `InventoryRuntimeService.cs`, `InventoryMergeService.cs`, `ShopPurchaseService.cs`의 작성자/커밋/팀 change log.
  - Play Mode 검증 로그.
  - 구매 실패, refund, merge, preview/commit 시연 영상.
  - EventBus 또는 이벤트 연결 코드.
  - 팀 공개 승인 또는 면접 전용 사용 기준.

### Project3 Fisher

* 문서 내 위치:
  - 기술문서의 두 번째 장.
  - 완성 게임 포트폴리오가 아니라 검증/문서화/툴링/협업 경계 관리 사례.
  - Coin Laundry에서 다룬 인벤토리/상점/데이터 문제를 더 큰 팀 구조와 서버 경계로 확장한 장.
  - PPT에서는 "검증 수준을 섞지 않는 방식"과 "public evidence boundary"를 강조한다.
* 강조할 내용:
  - Project3 Fisher / Fisher / CSH.
  - 검증 수준 분리: code 확인, build/self-test, Play Mode, live proof.
  - PlayFab / CloudScript 요청, 응답, live proof 분리.
  - Balance workbook / validator / CSV/JSON 계약 후보.
  - UI art pipeline / prompt / sprite / Unity 적용 기준 분리.
  - Codex/AI를 코드 생성기가 아니라 분석, 검토, 검증 큐 관리 보조로 사용.
  - public evidence boundary 관리.
* 안전한 표현:
  - 같은 인벤토리/상점/데이터 계열 문제를 더 큰 협업 구조에서 다루며, 먼저 검증 수준과 책임 경계를 분리했다.
  - PlayFab 연동 문제를 볼 때 Unity 요청, 서버 응답, live proof를 나눠 진단 기준을 잡았다.
  - Codex/AI를 무작정 코드 작성에 쓰지 않고 current-truth, verification queue, 영향 범위 제한에 활용했다.
  - 팀 원본 코드, PlayFab 설정, 원본 로그, 대용량 자료를 public repo에 복사하지 않는 기준을 유지했다.
* 금지 표현:
  - 완성 게임 포트폴리오.
  - 서버 전체 구현.
  - PlayFab 전체 설계.
  - 라이브 서비스 운영.
  - 전체 밸런스 확정.
  - 전체 UI 아트 제작.
  - 모든 검증 완료.
  - 팀 전체 코드 주도.
* 보강 필요 자료:
  - Fisher/CSH 실제 담당 범위.
  - 실제 `.cs` 코드 또는 sanitized excerpt.
  - balance workbook 원본, validator 실행 로그, CSV/JSON 계약 근거.
  - CloudScript handler, Unity caller, failure log, live proof.
  - UI/아트 파이프라인 지시문, 산출물, Unity 적용 근거.
  - 팀 공개 승인과 민감정보 제거 기준.

### EscapeRoom

* 문서 내 위치:
  - 기술문서의 세 번째 장.
  - 개인프로젝트이자 Unity/C# 기본 구현 역량 보강 근거.
  - 팀프로젝트 서사에서 직접 구현 방어가 약한 부분을 코드 근거로 받쳐주는 장.
  - PPT에서는 코드 구조를 가장 선명하게 보여주는 방어용 장으로 사용한다.
* 강조할 내용:
  - GameState / ProgressState 분리.
  - EnemyVision 거리 / 각도 / Raycast 감지.
  - DetectionController / FailureHandler 실패 흐름.
  - CheckpointManager / CheckpointTrigger 복귀 흐름.
  - TreasureGridManager / TreasureEnemy 퍼즐 reset / phase unlock / 추적 적 흐름.
* 안전한 표현:
  - 개인 프로젝트에서 상태, 감지, 실패 처리, 체크포인트, 퍼즐 진행을 역할별 코드로 분리했다.
  - 적 감지는 거리, 각도, Raycast line-of-sight를 순서대로 판정하도록 구성했다.
  - 감지 성공은 실패 처리와 체크포인트 복귀 흐름으로 이어지도록 분리했다.
  - Treasure 퍼즐에서는 node/path/reset/phase unlock과 추적 적 흐름을 나누어 관리했다.
* 금지 표현:
  - 상용 수준 스텔스 AI.
  - 모든 AI 로직 직접 구현.
  - 모든 퍼즐 완벽 구현.
  - 모든 런타임 검증 완료.
  - AI/Codex 없이 전부 직접 작성.
  - repo 기준 확인되지 않은 HideZone, PuzzleSafeZone, Player 이동 구현 완료 표현.
* 보강 필요 자료:
  - scene/prefab/Inspector 연결 근거.
  - Play Mode 또는 빌드 검증 로그.
  - 시연 영상, 스크린샷, 발표자료.
  - HideZone, PuzzleSafeZone, Player 이동 코드.
  - 프로젝트 기간과 Unity 버전.

## 6. 자소서 작성 기준

* 1500~2000자.
* 사람됨보다 "무엇을 만들었고 어떻게 해결했는가" 중심으로 쓴다.
* 팀프로젝트1 → 팀프로젝트2 → 개인프로젝트 순서로 서사를 구성한다.
* AI 느낌을 줄이고, 실제 강사 검토용 문체로 쓴다.
* 감정 문장은 결과를 꾸미는 용도가 아니라 문제를 버티고 해결한 판단을 설명하는 용도로만 쓴다.
* 직접 구현 확정이 약한 Project2와 Project3는 제한 표현으로 쓰고, 구현 방어는 EscapeRoom 코드 근거로 보강한다.
* "제가 훌륭합니다"보다 "이 문제가 있었고, 이 책임을 나누었고, 이 근거로 확인했습니다" 형태로 쓴다.

## 7. 기술문서 작성 기준

* 문제 → 설계 → 구현 → 검증 → 한계 순서로 작성한다.
* 각 claim마다 근거 경로를 연결한다.
* 코드 확인, 문서 확인, Play Mode 확인, 빌드 확인, live proof를 구분한다.
* 확인되지 않은 항목은 `확인 필요`로 둔다.
* 과장 표현을 금지한다.
* 자소서와 PPT의 기준 문서 역할을 한다.
* 팀 프로젝트에서는 담당 범위, 팀 결과물, 공개 가능 근거, 비공개 원본 자료를 분리한다.
* 개인 프로젝트에서는 코드 근거가 있는 항목과 scene/prefab/영상 보강 필요 항목을 분리한다.

## 8. PPT 작성 기준

* 10~12장.
* 기술문서의 흐름을 발표용으로 재구성한다.
* 코드 설명보다 문제, 구조, 검증, 한계 중심으로 보여준다.
* 각 장마다 근거 경로 또는 화면 자료 후보를 연결한다.
* 추천 흐름:
  - 1장: 지원 포지셔닝과 전체 서사.
  - 2~4장: Coin Laundry의 Inventory / Shop 문제와 구조 분리.
  - 5~7장: Project3 Fisher의 검증 수준, PlayFab 경계, public evidence boundary.
  - 8~10장: EscapeRoom의 상태, 감지, 실패/체크포인트, 퍼즐 코드 근거.
  - 11장: 검증 한계와 보강 필요 자료.
  - 12장: 면접에서 방어 가능한 핵심 키워드.
* 원본 PPT, 이미지, 영상, PDF는 GitHub에 올리지 않고 Drive에 둔다.

## 9. 금지 표현

- 전부 직접 구현.
- 전체 시스템 설계.
- 전체 인벤토리/상점 시스템 단독 구현.
- 팀 전체 시스템 설계.
- 서버 전체 구현.
- PlayFab 전체 설계.
- 라이브 서비스 운영.
- 상용 수준 완성.
- 상용 수준 스텔스 AI.
- 모든 버그 해결.
- QA 전체 담당.
- 모든 Play Mode 검증 완료.
- 모든 런타임 검증 완료.
- 모든 퍼즐 완벽 구현.
- 전체 밸런스 확정.
- 전체 UI 아트 제작.
- 팀 전체 코드 주도.
- AI/Codex 없이 전부 직접 작성.
- AI가 만든 결과를 본인 직접 제작물처럼 표현.

## 10. 다음 단계 작업 순서

1. 2/5 기술문서 목차/초안
   - Coin Laundry → Project3 Fisher → EscapeRoom 순서로 목차를 잡는다.
   - 각 장마다 문제, 설계, 구현, 검증, 한계, 근거 경로를 둔다.
   - 완성 본문이 아니라 제출용 기술문서 초안 구조를 만든다.
2. 3/5 자소서 1500~2000자 초안
   - 기술문서 목차를 기준으로 서사를 압축한다.
   - AI 느낌을 줄이고 강사 검토용 문체로 작성한다.
   - 직접 구현 확정이 약한 문장은 제한 표현으로 낮춘다.
3. 4/5 PPT 스토리보드
   - 10~12장 구조로 장표 제목, 핵심 메시지, 근거 자료 후보를 잡는다.
   - PPTX 파일은 이 단계에서 만들지 않는다.
4. 5/5 AI 느낌 제거 및 최종 검수
   - 과장 표현, 근거 없는 claim, 직접 구현 확정 표현을 제거한다.
   - 자소서, 기술문서, PPT 스토리보드의 표현을 같은 기준으로 맞춘다.
