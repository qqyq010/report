# PPT Storyboard v3

## 1. 작성 목적

이 문서는 기존 PPTX v2를 바로 수정하기 전에, 발표용 PPTX v3의 구조를 확정하기 위한 새 스토리보드입니다.

PPTX v3는 프로젝트별 1장 요약이 아니라, 프로젝트별 문제 상황과 구조, 검증 한계, 근거 경로를 발표자가 설명할 수 있게 재구성합니다. 핵심 키워드는 자소서 제출본과 동일하게 `상태 변경`, `실패 복구`, `검증 경계`로 둡니다.

현재 기준:

- 기술문서 최신본: Drive `external/submission-technical-document-external-v3.docx/pdf`
- 자소서 최신본: Drive `external/final-self-introduction-submission-v1.docx/pdf`
- 기존 PPT: Drive `ppt/unity-client-bootcamp-projects-v2.pptx`
- 기존 PPT 상태: 재구성 전 검토본
- 새 PPT 목표: 총 18장, 프로젝트별 최소 3장 이상

## 2. 전체 구성

| 구간 | Slide | 역할 |
| --- | --- | --- |
| 도입 | 1-3 | 핵심 키워드와 전체 프로젝트 흐름 제시 |
| Coin Laundry | 4-7 | Inventory/Shop의 상태 변경, 실패 복구, merge 책임 분리 |
| Project3 Fisher | 8-12 | 검증 경계, 협업 기준, 공개 범위, Codex/AI 사용 경계 |
| EscapeRoom | 13-16 | 개인 프로젝트 코드 근거와 Unity/C# 구현 설명 |
| 마무리 | 17-18 | 세 프로젝트의 공통 개발 방식과 제출 전 근거 연결 |

## 3. 장표별 스토리보드

### Slide 1. 표지

* 목적:
  - 발표의 주제와 세 프로젝트의 연결 기준을 첫 화면에서 보여줍니다.
* 핵심 메시지:
  - Unity/C# 프로젝트 경험을 상태 변경, 실패 복구, 검증 경계 중심으로 정리합니다.
* 화면 구성:
  - 제목: `Unity/C# 부트캠프 프로젝트 기술 정리`
  - 부제: `상태 변경, 실패 복구, 검증 경계를 중심으로 정리한 클라이언트 개발 경험`
  - 프로젝트명: `Coin Laundry`, `Project3 Fisher`, `EscapeRoom`
  - 하단 태그: `Unity`, `C#`, `Inventory/Shop`, `Verification`, `Stealth/Puzzle`
* 들어갈 문장:
  - `상태 변경, 실패 복구, 검증 경계를 중심으로 세 프로젝트의 기술 판단을 정리했습니다.`
* 도식/시각 자료 후보:
  - 세 프로젝트명을 가로로 배치하고, 아래에 세 핵심 키워드를 배지 형태로 배치합니다.
* 근거 경로:
  - [career/submission-package-index.md](https://github.com/qqyq010/report/blob/main/career/submission-package-index.md)
  - [career/final-self-introduction-submission.md](https://github.com/qqyq010/report/blob/main/career/final-self-introduction-submission.md)
* 피해야 할 표현:
  - 세 프로젝트를 모두 완성작처럼 표현하지 않습니다.
  - 팀 프로젝트 전체를 개인 단독 성과처럼 표현하지 않습니다.

### Slide 2. 핵심 키워드

* 목적:
  - 발표 전체의 판단 기준을 먼저 제시합니다.
* 핵심 메시지:
  - 기능 개수보다 상태가 언제 바뀌고, 실패했을 때 어떻게 복구하며, 어디까지 확인했는지가 중요했습니다.
* 화면 구성:
  - 큰 제목: `상태 변경 · 실패 복구 · 검증 경계`
  - 세 카드:
    - 상태 변경: 화면 상태와 실제 데이터 반영 시점
    - 실패 복구: 성공 경로뿐 아니라 실패 후 되돌림
    - 검증 경계: 확인한 것과 확인이 필요한 것 분리
* 들어갈 문장:
  - `세 프로젝트를 관통하는 기준은 기능 개수가 아니라 상태가 언제 바뀌고, 실패했을 때 어떻게 복구하며, 어디까지 확인했는지를 나누는 것이었습니다.`
* 도식/시각 자료 후보:
  - 3개 키워드를 같은 크기의 카드로 배치합니다.
* 근거 경로:
  - [career/final-self-introduction-submission.md](https://github.com/qqyq010/report/blob/main/career/final-self-introduction-submission.md)
  - [career/submission-technical-document-external.md](https://github.com/qqyq010/report/blob/main/career/submission-technical-document-external.md)
* 피해야 할 표현:
  - 모든 검증을 완료했다고 표현하지 않습니다.
  - 문제 해결 능력을 추상적으로만 말하지 않습니다.

### Slide 3. 전체 프로젝트 흐름

* 목적:
  - 세 프로젝트가 서로 어떤 역할로 연결되는지 보여줍니다.
* 핵심 메시지:
  - Coin Laundry에서 상태 변경과 실패 복구를 보고, Project3 Fisher에서 검증 경계와 협업 기준으로 확장했으며, EscapeRoom으로 코드 설명 근거를 보강합니다.
* 화면 구성:
  - 흐름도: `Coin Laundry -> Project3 Fisher -> EscapeRoom`
  - 역할 태그:
    - Coin Laundry: `Inventory/Shop 상태 변경과 실패 복구`
    - Project3 Fisher: `검증 경계와 협업 기준`
    - EscapeRoom: `코드로 설명 가능한 구현 근거`
* 들어갈 문장:
  - `발표 흐름은 팀 프로젝트 경험에서 출발하되, 직접 코드 설명이 필요한 부분은 개인 프로젝트 EscapeRoom으로 보강합니다.`
* 도식/시각 자료 후보:
  - 화살표 흐름도와 프로젝트별 역할 태그.
* 근거 경로:
  - [career/submission-technical-document-external.md](https://github.com/qqyq010/report/blob/main/career/submission-technical-document-external.md)
  - [career/claim-boundary.md](https://github.com/qqyq010/report/blob/main/career/claim-boundary.md)
* 피해야 할 표현:
  - Project3 Fisher를 완성 게임 포트폴리오처럼 소개하지 않습니다.
  - EscapeRoom의 모든 런타임 검증이 끝난 것처럼 표현하지 않습니다.

### Slide 4. Coin Laundry - 문제 상황

* 목적:
  - Inventory/Shop이 단순 UI가 아니라 상태 반영과 실패 복구가 연결된 기능임을 설명합니다.
* 핵심 메시지:
  - 화면에 보이는 상태와 실제 데이터 반영 시점이 섞이면 인벤토리와 상점 흐름이 어긋날 수 있습니다.
* 화면 구성:
  - 왼쪽: `화면 상태`
    - preview
    - drag/rotate
    - purchase UI
  - 오른쪽: `실제 데이터`
    - commit
    - runtime inventory
    - gold/item state
  - 하단: `구매 성공/실패`, `merge 판정/실행`
* 들어갈 문장:
  - `Inventory/Shop은 버튼과 슬롯 UI만의 문제가 아니라, 화면 상태와 실제 데이터 변경 시점이 연결된 기능이었습니다.`
* 도식/시각 자료 후보:
  - 화면 상태와 실제 데이터 상태를 나누는 2열 도식.
* 근거 경로:
  - [projects/project2-coin-laundry/technical-evidence.md](https://github.com/qqyq010/report/blob/main/projects/project2-coin-laundry/technical-evidence.md)
  - [projects/project2-coin-laundry/claim-evidence-map.md](https://github.com/qqyq010/report/blob/main/projects/project2-coin-laundry/claim-evidence-map.md)
* 피해야 할 표현:
  - `전체 인벤토리/상점 시스템을 혼자 구현했습니다.`
  - `팀 전체 시스템을 설계했습니다.`

### Slide 5. Coin Laundry - Inventory preview / commit

* 목적:
  - preview와 commit을 분리해서 설명합니다.
* 핵심 메시지:
  - preview는 입력 중 임시 상태이고, commit은 실제 런타임 상태 변경입니다.
* 화면 구성:
  - 흐름: `UI preview -> validation -> runtime commit`
  - 설명 박스:
    - preview: 위치, 회전, 배치 가능성 확인
    - validation: 배치/merge 가능 여부 확인
    - commit: 실제 인벤토리 상태 변경
* 들어갈 문장:
  - `preview와 commit이 섞이면 화면에는 가능한 배치처럼 보이지만 실제 데이터는 다른 상태가 될 수 있습니다.`
* 도식/시각 자료 후보:
  - 3단 흐름도.
  - preview와 commit의 책임을 색상으로 분리합니다.
* 근거 경로:
  - [projects/project2-coin-laundry/technical-evidence.md](https://github.com/qqyq010/report/blob/main/projects/project2-coin-laundry/technical-evidence.md)
  - [projects/project2-coin-laundry/source-file-map.md](https://github.com/qqyq010/report/blob/main/projects/project2-coin-laundry/source-file-map.md)
* 피해야 할 표현:
  - `InventoryUIController.cs`를 본인 단독 구현으로 확정하지 않습니다.
  - Play Mode 전체 검증 완료처럼 표현하지 않습니다.

### Slide 6. Coin Laundry - Shop spend / receive / refund

* 목적:
  - 구매 성공 경로뿐 아니라 실패 복구 경로를 함께 설명합니다.
* 핵심 메시지:
  - receive 실패 시 재화만 빠지는 문제가 생길 수 있으므로 spend, receive, refund 흐름을 같이 봐야 합니다.
* 화면 구성:
  - 정상 흐름: `purchase request -> spend -> receive -> success`
  - 실패 흐름: `receive fail -> refund -> failure result`
  - 하단 메모: `성공 경로만 보면 부족함`
* 들어갈 문장:
  - `구매는 성공 경로만 보면 단순하지만, 수령 실패까지 보면 환불 흐름과 상태 일관성을 함께 확인해야 합니다.`
* 도식/시각 자료 후보:
  - 정상 경로와 실패 경로를 나란히 배치한 flow chart.
* 근거 경로:
  - [projects/project2-coin-laundry/technical-evidence.md](https://github.com/qqyq010/report/blob/main/projects/project2-coin-laundry/technical-evidence.md)
  - [projects/project2-coin-laundry/claim-evidence-map.md](https://github.com/qqyq010/report/blob/main/projects/project2-coin-laundry/claim-evidence-map.md)
  - [portfolio/02-coin-laundry/evidence-source-map.md](https://github.com/qqyq010/report/blob/main/portfolio/02-coin-laundry/evidence-source-map.md)
* 피해야 할 표현:
  - 상점 시스템 전체를 완성했다고 표현하지 않습니다.
  - 모든 실패 케이스를 검증했다고 표현하지 않습니다.

### Slide 7. Coin Laundry - Merge 책임 분리와 한계

* 목적:
  - UI와 서비스의 책임 분리, 그리고 현재 근거 한계를 같이 보여줍니다.
* 핵심 메시지:
  - UI는 입력과 요청을 만들고, service는 merge 판정과 실행을 담당하는 구조로 설명합니다.
* 화면 구성:
  - 흐름: `UI request -> CanMerge -> TryMergeItems -> result`
  - 오른쪽 한계 박스:
    - 문서 근거 중심
    - 작성자/커밋 확인 필요
    - Play Mode 로그 보강 필요
* 들어갈 문장:
  - `현재는 설명 가능한 구조와 sanitized evidence 중심으로 사용하고, 직접 구현 확정은 작성자와 검증 로그 확인 전까지 보류합니다.`
* 도식/시각 자료 후보:
  - UI와 service를 분리한 책임 경계도.
  - `말할 수 있는 것` / `보강 필요` 2열 표.
* 근거 경로:
  - [projects/project2-coin-laundry/implemented-by-me.md](https://github.com/qqyq010/report/blob/main/projects/project2-coin-laundry/implemented-by-me.md)
  - [projects/project2-coin-laundry/interview-points.md](https://github.com/qqyq010/report/blob/main/projects/project2-coin-laundry/interview-points.md)
  - [career/verification-needed.md](https://github.com/qqyq010/report/blob/main/career/verification-needed.md)
* 피해야 할 표현:
  - sanitized evidence만으로 직접 구현이 확정됐다고 말하지 않습니다.
  - QA 전체 담당, 모든 버그 해결로 표현하지 않습니다.

### Slide 8. Project3 Fisher - 왜 보조 근거인가

* 목적:
  - Project3 Fisher의 위치를 완성작이 아닌 보조 근거로 명확히 둡니다.
* 핵심 메시지:
  - Project3 Fisher는 완성 게임 포트폴리오가 아니라 검증, 문서화, 툴링, 협업 경계 관리 사례입니다.
* 화면 구성:
  - 중앙 키워드: `보조 근거`
  - 주변 요소:
    - Fisher/CSH
    - PlayFab/CloudScript
    - Balance workbook
    - UI resource pipeline
    - verification workflow
* 들어갈 문장:
  - `Project3 Fisher는 기능 완성 주장이 아니라, 팀 프로젝트에서 확인 수준과 공개 범위를 나누는 방식의 근거로 사용합니다.`
* 도식/시각 자료 후보:
  - 기능 영역과 검증/문서화 영역을 분리한 map.
* 근거 경로:
  - [projects/project3-fisher/summary.md](https://github.com/qqyq010/report/blob/main/projects/project3-fisher/summary.md)
  - [projects/project3-fisher/role-and-scope.md](https://github.com/qqyq010/report/blob/main/projects/project3-fisher/role-and-scope.md)
  - [projects/project3-fisher/technical-evidence.md](https://github.com/qqyq010/report/blob/main/projects/project3-fisher/technical-evidence.md)
* 피해야 할 표현:
  - 완성 게임 포트폴리오.
  - 서버 전체 구현.
  - PlayFab 전체 설계.
  - 라이브 서비스 운영.

### Slide 9. Project3 Fisher - 확인 수준 분리

* 목적:
  - 확인 수준을 섞지 않는 방식을 설명합니다.
* 핵심 메시지:
  - 코드 확인, 문서 확인, Play Mode, build/self-test, 라이브 반영 근거는 서로 다른 검증 수준입니다.
* 화면 구성:
  - 단계: `현재 기준 -> 확인 목록 -> 실제 반영 근거`
  - 라벨:
    - code 확인
    - 문서 확인
    - Play Mode
    - build/self-test
    - live proof
* 들어갈 문장:
  - `확인한 것과 더 확인해야 할 것을 나누어 두어야 팀 프로젝트의 작업 상태를 과장하지 않을 수 있습니다.`
* 도식/시각 자료 후보:
  - 검증 수준 ladder.
  - 확인 완료와 확인 필요를 색상으로 구분합니다.
* 근거 경로:
  - [projects/project3-fisher/technical-evidence.md](https://github.com/qqyq010/report/blob/main/projects/project3-fisher/technical-evidence.md)
  - [portfolio/03-project3-fisher/tools-and-verification.md](https://github.com/qqyq010/report/blob/main/portfolio/03-project3-fisher/tools-and-verification.md)
* 피해야 할 표현:
  - 문서 확인을 Play Mode 검증 완료처럼 표현하지 않습니다.
  - 모든 검증 완료로 표현하지 않습니다.

### Slide 10. Project3 Fisher - Unity 요청 / 서버 응답 / 실제 반영 근거

* 목적:
  - PlayFab/CloudScript 문제를 서버 구현 주장이 아니라 진단 경계로 설명합니다.
* 핵심 메시지:
  - 서버와 연결된 문제는 Unity 요청, CloudScript 응답, client handling, 실제 반영 근거를 따로 보아야 합니다.
* 화면 구성:
  - 흐름: `Unity request -> CloudScript response -> client handling -> live proof`
  - 하단 주의: `서버 전체 구현 claim 아님`
* 들어갈 문장:
  - `UI 증상만으로 원인을 확정하지 않고, 요청과 응답, 실제 반영 근거를 분리해서 확인하는 기준을 세웠습니다.`
* 도식/시각 자료 후보:
  - client/server 경계 flow chart.
  - 요청/응답/반영 근거의 책임 분리 도식.
* 근거 경로:
  - [projects/project3-fisher/cloudscript-evidence.md](https://github.com/qqyq010/report/blob/main/projects/project3-fisher/cloudscript-evidence.md)
  - [projects/project3-fisher/claim-evidence-map.md](https://github.com/qqyq010/report/blob/main/projects/project3-fisher/claim-evidence-map.md)
  - [portfolio/03-project3-fisher/evidence-source-map.md](https://github.com/qqyq010/report/blob/main/portfolio/03-project3-fisher/evidence-source-map.md)
* 피해야 할 표현:
  - 서버 전체를 구현했다고 표현하지 않습니다.
  - live 반영을 완료했다고 확정하지 않습니다.

### Slide 11. Project3 Fisher - GitHub / Drive 공개 경계

* 목적:
  - 공개 가능한 자료와 비공개 원본의 분리를 설명합니다.
* 핵심 메시지:
  - GitHub에는 공개 가능한 요약과 근거 경로를 두고, 원본 문서와 대용량 자료는 Drive에 둡니다.
* 화면 구성:
  - 좌측: `GitHub`
    - Markdown 요약
    - 공개 가능한 근거 경로
    - sanitized evidence
  - 우측: `Drive`
    - 원본 문서
    - PDF/PPT/영상/이미지
    - 비공개 자료
  - 중앙: `공개 승인 전 원본 코드 제외`
* 들어갈 문장:
  - `팀 원본 코드, PlayFab 설정, 원본 로그는 공개 승인 전 GitHub에 두지 않고, 공개 가능한 요약과 원본 보관 위치를 나누었습니다.`
* 도식/시각 자료 후보:
  - GitHub와 Drive를 나누는 storage boundary diagram.
* 근거 경로:
  - [drive-links.md](https://github.com/qqyq010/report/blob/main/drive-links.md)
  - [portfolio-projects-role-map.md](https://github.com/qqyq010/report/blob/main/portfolio-projects-role-map.md)
  - [security-redaction-checklist.md](https://github.com/qqyq010/report/blob/main/security-redaction-checklist.md)
* 피해야 할 표현:
  - 원본 팀 코드를 공개 repo에 올려도 된다고 표현하지 않습니다.
  - PlayFab 설정이나 내부 로그를 공개 가능 자료처럼 표현하지 않습니다.

### Slide 12. Project3 Fisher - AI/Codex 사용 기준

* 목적:
  - AI/Codex 사용이 구현 성과가 아니라 검토 보조였음을 분리합니다.
* 핵심 메시지:
  - Codex/AI는 분석, 검토, 문서화, 확인 목록 관리 보조로 제한해서 사용했습니다.
* 화면 구성:
  - 허용 범위:
    - read-only scan
    - 영향 범위 확인
    - snippet append 금지
    - 전체 원본 기준 검토
    - 검증 결과 문서화
  - 금지 범위:
    - AI 결과를 직접 제작물처럼 표현
    - 검증 없이 구현 완료 표현
* 들어갈 문장:
  - `AI 도구는 성과를 대신 만든 근거가 아니라, 확인해야 할 범위와 문서화 기준을 정리하는 보조 도구로 사용했습니다.`
* 도식/시각 자료 후보:
  - AI/Codex 사용 범위를 `검토 보조`와 `구현 claim 금지`로 나누는 2열 표.
* 근거 경로:
  - [portfolio/03-project3-fisher/ai-assisted-workflow.md](https://github.com/qqyq010/report/blob/main/portfolio/03-project3-fisher/ai-assisted-workflow.md)
  - [projects/project3-fisher/interview-points.md](https://github.com/qqyq010/report/blob/main/projects/project3-fisher/interview-points.md)
* 피해야 할 표현:
  - AI가 전부 구현했다고 표현하지 않습니다.
  - AI/Codex 없이 전부 직접 작성했다고 표현하지 않습니다.

### Slide 13. EscapeRoom - 개인 프로젝트 위치

* 목적:
  - EscapeRoom이 직접 코드 설명 근거를 보강하는 개인 프로젝트임을 설명합니다.
* 핵심 메시지:
  - 팀 프로젝트에서 조심스럽게 말해야 하는 직접 구현 표현을 개인 프로젝트의 공개 C# 코드로 보강합니다.
* 화면 구성:
  - 프로젝트 역할: `개인 프로젝트`, `Unity/C# 코드 근거`
  - 기능 묶음:
    - GameState / ProgressState
    - EnemyVision
    - FailureHandler / Checkpoint
    - Treasure Puzzle
* 들어갈 문장:
  - `EscapeRoom은 상태 관리, 감지, 실패 처리, 체크포인트, 퍼즐 진행을 코드 경로로 설명할 수 있는 개인 프로젝트입니다.`
* 도식/시각 자료 후보:
  - Core / Enemy / Player / Puzzle / World 영역별 코드 map.
* 근거 경로:
  - [projects/project1-escape-room/summary.md](https://github.com/qqyq010/report/blob/main/projects/project1-escape-room/summary.md)
  - [projects/project1-escape-room/technical-evidence.md](https://github.com/qqyq010/report/blob/main/projects/project1-escape-room/technical-evidence.md)
  - [portfolio/01-escape-room/code/](https://github.com/qqyq010/report/tree/main/portfolio/01-escape-room/code)
* 피해야 할 표현:
  - 모든 런타임 검증 완료로 표현하지 않습니다.
  - 모든 퍼즐을 완벽하게 구현했다고 표현하지 않습니다.

### Slide 14. EscapeRoom - EnemyVision 감지 구조

* 목적:
  - 잠입 요소의 감지 조건을 코드 구조로 설명합니다.
* 핵심 메시지:
  - EnemyVision은 거리, 각도, Raycast 순서로 감지 조건을 단계화합니다.
* 화면 구성:
  - 흐름: `거리 -> 각도 -> Raycast`
  - 보조 요소:
    - line-of-sight
    - obstacle/layer 확인 필요
    - PlayerDetectionTarget
* 들어갈 문장:
  - `단순 거리 판정만 쓰지 않고, 적의 전방 기준 각도와 Raycast line-of-sight를 함께 확인하는 구조로 설명할 수 있습니다.`
* 도식/시각 자료 후보:
  - 적 시야 cone과 Raycast 선을 단순 도형으로 표현합니다.
* 근거 경로:
  - [portfolio/01-escape-room/code/Enemy/EnemyVision.cs](https://github.com/qqyq010/report/blob/main/portfolio/01-escape-room/code/Enemy/EnemyVision.cs)
  - [portfolio/01-escape-room/code/Enemy/DetectionController.cs](https://github.com/qqyq010/report/blob/main/portfolio/01-escape-room/code/Enemy/DetectionController.cs)
  - [portfolio/01-escape-room/code/Player/PlayerDetectionTarget.cs](https://github.com/qqyq010/report/blob/main/portfolio/01-escape-room/code/Player/PlayerDetectionTarget.cs)
* 피해야 할 표현:
  - 상용 수준 스텔스 AI로 표현하지 않습니다.
  - 모든 적 AI를 직접 구현했다고 표현하지 않습니다.

### Slide 15. EscapeRoom - 실패 처리와 체크포인트 복귀

* 목적:
  - 감지 후 실패 처리와 재시도 흐름을 책임별로 설명합니다.
* 핵심 메시지:
  - 감지, 실패 처리, 복귀 위치 관리를 분리해 재시도 흐름을 설명할 수 있습니다.
* 화면 구성:
  - 흐름: `DetectionController -> FailureHandler -> CheckpointManager / CheckpointTrigger`
  - 설명:
    - 감지 결과
    - 실패 중복 방지
    - 복귀 위치
    - 재시도 흐름
* 들어갈 문장:
  - `감지 성공 뒤 실패 처리가 중복 실행되거나 복귀 위치가 꼬이지 않도록 감지, 실패 처리, 체크포인트 책임을 나누어 보았습니다.`
* 도식/시각 자료 후보:
  - 실패 처리 flow chart.
  - checkpoint 저장/복귀를 나누는 sequence diagram.
* 근거 경로:
  - [portfolio/01-escape-room/code/Core/FailureHandler.cs](https://github.com/qqyq010/report/blob/main/portfolio/01-escape-room/code/Core/FailureHandler.cs)
  - [portfolio/01-escape-room/code/Core/CheckpointManager.cs](https://github.com/qqyq010/report/blob/main/portfolio/01-escape-room/code/Core/CheckpointManager.cs)
  - [portfolio/01-escape-room/code/World/CheckpointTrigger.cs](https://github.com/qqyq010/report/blob/main/portfolio/01-escape-room/code/World/CheckpointTrigger.cs)
* 피해야 할 표현:
  - Play Mode로 모든 실패 케이스를 검증했다고 표현하지 않습니다.
  - scene trigger 배치까지 확인 완료된 것처럼 표현하지 않습니다.

### Slide 16. EscapeRoom - Treasure Puzzle 흐름

* 목적:
  - 퍼즐 상태 관리와 phase unlock 흐름을 설명합니다.
* 핵심 메시지:
  - Treasure Puzzle은 node/path, reset, solved, phase unlock, 퍼즐 내부 추적 적의 실패 조건으로 나뉩니다.
* 화면 구성:
  - 흐름: `node/path -> reset -> solved -> phase unlock`
  - 별도 실패 흐름: `TreasureEnemy -> failure`
  - 보강 필요: 누락 타입, Play Mode 영상
* 들어갈 문장:
  - `Treasure Puzzle은 퍼즐 진행 상태와 실패 조건을 나누어 관리하고, 클리어 결과는 phase unlock 흐름으로 연결됩니다.`
* 도식/시각 자료 후보:
  - grid/path/reset/phase unlock flow chart.
  - 퍼즐 내부 enemy failure를 별도 branch로 표시합니다.
* 근거 경로:
  - [portfolio/01-escape-room/code/Puzzle/TreasureGridManager.cs](https://github.com/qqyq010/report/blob/main/portfolio/01-escape-room/code/Puzzle/TreasureGridManager.cs)
  - [portfolio/01-escape-room/code/Puzzle/TreasureEnemy.cs](https://github.com/qqyq010/report/blob/main/portfolio/01-escape-room/code/Puzzle/TreasureEnemy.cs)
  - [portfolio/01-escape-room/code/Core/ProgressState.cs](https://github.com/qqyq010/report/blob/main/portfolio/01-escape-room/code/Core/ProgressState.cs)
  - [projects/project1-escape-room/claim-evidence-map.md](https://github.com/qqyq010/report/blob/main/projects/project1-escape-room/claim-evidence-map.md)
* 피해야 할 표현:
  - 모든 퍼즐 완성 또는 모든 런타임 검증 완료로 표현하지 않습니다.
  - 누락 타입까지 확인 완료된 것처럼 표현하지 않습니다.

### Slide 17. 세 프로젝트에서 정리한 개발 방식

* 목적:
  - 프로젝트별 사례를 공통 개발 방식으로 묶습니다.
* 핵심 메시지:
  - 상태 변경, 실패 복구, 검증 경계를 나누어 보는 방식이 세 프로젝트의 공통 기준입니다.
* 화면 구성:
  - 카드 6개:
    - UI preview / commit
    - spend / receive / refund
    - Unity request / server response / live proof
    - code 확인 / Play Mode / build / live proof
    - detection / failure / checkpoint
    - puzzle reset / phase unlock
* 들어갈 문장:
  - `상태 변경, 실패 복구, 검증 경계를 나누어 보는 방식이 세 프로젝트의 공통 기준이었습니다.`
* 도식/시각 자료 후보:
  - 6개 카드를 2행 3열로 배치합니다.
  - 카드마다 관련 프로젝트 아이콘 또는 태그를 붙입니다.
* 근거 경로:
  - [career/submission-technical-document-external.md](https://github.com/qqyq010/report/blob/main/career/submission-technical-document-external.md)
  - [career/final-self-introduction-submission.md](https://github.com/qqyq010/report/blob/main/career/final-self-introduction-submission.md)
* 피해야 할 표현:
  - 모든 문제를 해결했다고 표현하지 않습니다.
  - 모든 검증을 완료했다고 표현하지 않습니다.

### Slide 18. 제출 전 근거 연결과 확인 사항

* 목적:
  - PPT v3 제작 전 연결해야 할 기준 문서와 Drive 산출물을 정리합니다.
* 핵심 메시지:
  - 기술문서, 자소서, PPT, Drive 원본, GitHub 기준 문서의 표현 수위를 맞추어야 합니다.
* 화면 구성:
  - 제출 후보:
    - 기술문서 v3: Drive `external/submission-technical-document-external-v3.docx/pdf`
    - 자소서 v1: Drive `external/final-self-introduction-submission-v1.docx/pdf`
    - PPT: v3 제작 예정
  - 기준 문서:
    - GitHub `career/submission-technical-document-external.md`
    - GitHub `career/final-self-introduction-submission.md`
    - GitHub `career/ppt-storyboard-v3.md`
  - 확인:
    - 공개 가능 자료와 비공개 원본 분리
    - 회사별 지원 시 자소서 마지막 문단 교체 가능
* 들어갈 문장:
  - `PPTX v3는 이 스토리보드를 기준으로 제작하고, 기존 PPTX v2는 재구성 전 검토본으로 보관합니다.`
* 도식/시각 자료 후보:
  - GitHub 기준 문서와 Drive 제출 파일을 연결하는 2열 구조.
* 근거 경로:
  - [career/submission-package-index.md](https://github.com/qqyq010/report/blob/main/career/submission-package-index.md)
  - [career/claim-boundary.md](https://github.com/qqyq010/report/blob/main/career/claim-boundary.md)
  - [career/verification-needed.md](https://github.com/qqyq010/report/blob/main/career/verification-needed.md)
* 피해야 할 표현:
  - 기존 PPTX v2를 최종본처럼 표현하지 않습니다.
  - Drive 원본 자료를 GitHub에 올린다고 표현하지 않습니다.

## 4. PPTX v3 제작 시 공통 주의 사항

- 총 slide 수는 18장 기준으로 제작합니다.
- 프로젝트별 최소 3장 이상을 유지합니다.
- 장표는 발표용으로 짧게 쓰고, 상세 설명은 발표자가 말로 보강합니다.
- 기술문서 v3의 GitHub 근거 링크 구조를 반영합니다.
- 자소서의 첫 키워드인 `상태 변경`, `실패 복구`, `검증 경계`를 초반 장표에 배치합니다.
- Coin Laundry는 담당 범위 후보와 설명 가능한 구조 중심으로 표현합니다.
- Project3 Fisher는 완성작이 아니라 검증/문서화/툴링/협업 경계 사례로 표현합니다.
- EscapeRoom은 개인 프로젝트의 공개 C# 코드 근거 중심으로 표현합니다.
- Drive 원본, 영상, 이미지, PPTX, PDF는 GitHub에 올리지 않습니다.

## 5. PPT에서 금지할 표현

- 전체 인벤토리/상점 시스템을 혼자 구현했습니다.
- 팀 전체 시스템을 설계했습니다.
- 서버 전체를 구현했습니다.
- PlayFab 전체를 설계했습니다.
- 라이브 서비스를 운영했습니다.
- 전체 밸런스를 확정했습니다.
- 모든 검증을 완료했습니다.
- 모든 버그를 해결했습니다.
- QA 전체를 담당했습니다.
- 상용 수준으로 완성했습니다.
- 상용 수준 스텔스 AI를 구현했습니다.
- AI/Codex 없이 전부 직접 작성했습니다.
- AI가 만든 결과를 제 직접 제작물처럼 표현했습니다.
- Project3 Fisher를 완성 게임 포트폴리오로 표현합니다.
- Coin Laundry의 팀 결과물을 개인 단독 구현처럼 표현합니다.

## 6. PPTX v3 제작 전 필요한 자료

- Coin Laundry:
  - Inventory/Shop 화면 캡처 또는 시연 영상.
  - preview/commit, spend/receive/refund, merge 흐름을 보여줄 수 있는 이미지 후보.
  - 작성자/커밋/팀 승인 자료는 있으면 보강합니다.
- Project3 Fisher:
  - 검증 흐름, GitHub/Drive 분리, Codex/AI 사용 기준을 보여줄 수 있는 자료.
  - PlayFab/CloudScript 관련 원본은 공개하지 않고 요약 또는 비공개 Drive 기준으로 둡니다.
- EscapeRoom:
  - `EnemyVision`, `FailureHandler`, `CheckpointManager`, `TreasureGridManager` 코드 캡처 후보.
  - scene/Play Mode/영상은 있으면 보강하되, 없으면 코드 구조 설명 범위로 제한합니다.
