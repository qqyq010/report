# Interview Keywords

## 목적

면접에서 설명할 수 있는 키워드를 프로젝트 근거와 연결한다.
키워드는 아는 단어 목록이 아니라, 코드/문서/검증 근거로 설명 가능한 주제만
면접 카드로 승격한다.

## 현재 확정된 사실

- 후보 키워드는 직접 구현, 팀 결과물 / 협업 기여, 확인 필요, 과장 위험으로 분류한다.
- Project3 키워드는 완성 게임의 대표 성과가 아니라 검증, 문서화, 툴링 태도의 보조 근거로 다룬다.

## 직접 구현 근거

- Project1 후보: TODO: EscapeRoom, 퍼즐, 잠입 요소, 상태 관리, 실패 처리, 체크포인트.
- Project2 후보: TODO: Coin Laundry, Inventory, Shop, UI, EventBus, 디버깅, 검증.
- Project3 후보: TODO: Fisher, CSH, 밸런스, CloudScript, UI 아트 파이프라인, 검증 문서.

## Project2 - Coin Laundry 키워드 후보

| 키워드 | 상태 | 근거 경로 | 사용 기준 |
| --- | --- | --- | --- |
| Unity UI | 확인 필요 | `projects/project2-coin-laundry/source-file-map.md`의 `InventoryUIController.cs` 언급 | 원본 코드 확인 후 UI 상호작용 설명에 사용 |
| Inventory | 사용 가능 후보 | `portfolio/02-coin-laundry/evidence-source-map.md`, `projects/project2-coin-laundry/technical-evidence.md` | preview/commit 분리 소재로 제한 |
| Shop | 사용 가능 후보 | `portfolio/_shared/sanitized-evidence-matrix.md`, `projects/project2-coin-laundry/claim-evidence-map.md` | 구매 실패 시 환불 경로 소재로 제한 |
| EventBus | 확인 필요 | 현재 repo 근거에는 EventBus 코드 파일명 없음 | 추가 코드 자료 제공 전 핵심 키워드로 사용하지 않음 |
| 런타임 상태 관리 | 확인 필요 | `InventoryRuntimeService.cs`가 문서상 언급됨 | 원본 코드 확인 후 사용 |
| 디버깅 | 확인 필요 | 환불/배치 실패 시나리오가 문서상 언급됨 | 실제 버그 수정 로그 필요 |
| 검증 로그 | 확인 필요 | Project2 AI work rules, baseline docs가 문서상 언급됨 | Play Mode A-K 또는 빌드 로그 필요 |
| 팀 협업 | 사용 가능 후보 | `portfolio/_shared/publication-policy.md`, `implemented-by-me.md` | 공개 범위와 담당 범위 분리 소재로 사용 |
| 포트폴리오 문서화 | 사용 가능 | `portfolio/02-coin-laundry/`, `projects/project2-coin-laundry/` | sanitized summary와 내부 claim 정리 연결로 사용 |

## 팀 결과물 / 협업 근거

- 팀 프로젝트 키워드는 팀 결과물과 개인 담당 범위를 함께 기록한다.
- 팀 공용 시스템, 서버 계약, 전체 QA, 전체 밸런스처럼 범위가 큰 키워드는 개인 단독 키워드로 쓰지 않는다.

## 확인 필요

- TODO: 면접에서 코드 수준으로 설명 가능한 키워드와 개념 수준 키워드 분리.
- TODO: 각 키워드별 근거 파일, 문서, 로그, 영상 링크.
- TODO: 실제 실행 검증 여부.
- TODO: 팀원 구현분과 본인 구현분의 경계.

## 자소서 활용 가능 포인트

- 담당 범위 내 구현은 자소서 핵심 소재 후보로 둔다.
- 검증 로그 기반 문제 추적과 코드/문서/테스트 근거 기반 개선은 기술문서와 면접 답변에 연결한다.
- Project3는 보조 근거로 두고 작업 방식과 검증 태도를 설명하는 데 사용한다.

## 면접 예상 질문

- TODO: 이 키워드가 실제 코드에서 어디에 나타나는가?
- TODO: 어떤 문제를 해결하기 위해 이 구조를 썼는가?
- TODO: 팀 결과물 중 본인이 설명할 수 있는 범위는 어디까지인가?
- TODO: 검증 로그나 테스트 근거가 있는가?

## 과장 위험 / 금지 표현

- 용어만 알고 실제 구현 근거가 없는 키워드는 핵심 역량으로 쓰지 않는다.
- 서버 전체 구현, 라이브 서비스 운영, QA 전체 담당, 밸런스 전체 확정은 근거가 생기기 전까지 금지한다.
- 설명 가능한 깊이가 부족한 키워드는 확인 필요로 남긴다.
