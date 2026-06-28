# Unity Client Portfolio / Career Evidence Repository

Unity 클라이언트 개발 신입 지원용 취업 근거 정리 저장소입니다.

이 repo는 코드 원본 저장소가 아니라 취업 근거 정리소다.
원본 문서와 대용량 자료는 Google Drive `center` 폴더에 둔다.
GitHub에는 민감정보와 원본 대용량 자료를 올리지 않는다.
직접 구현 / 팀 결과물 / 확인 필요 / 과장 위험을 분리해서 기록한다.

## 목적

이 저장소는 전체 프로젝트 원본을 그대로 올리는 용도가 아니라, 이력서,
자소서, 포트폴리오, 면접에서 설명할 수 있는 공개 가능한 근거를 정리하는 용도입니다.
완성 문장을 먼저 만드는 곳이 아니라, 나중에 자소서와 발표자료에 넣을 수 있는
근거를 안전하게 분류하는 작업 공간입니다.

## 운영 기준

모든 문서는 아래 네 분류를 유지합니다.

| 분류 | 의미 |
| --- | --- |
| 직접 구현 | 본인이 코드, 문서, 검증 자료로 설명할 수 있는 담당 범위 |
| 팀 결과물 / 협업 기여 | 팀 산출물 중 본인 역할이 분리되어 설명 가능한 범위 |
| 확인 필요 | 아직 코드, 문서, 커밋, 영상, 피드백 등 근거가 부족한 항목 |
| 과장 위험 | 현재 근거로는 자소서, 이력서, 면접에서 쓰면 위험한 표현 |

확인되지 않은 내용은 `TODO`, `확인 필요`, `추가 설명 필요`로 남깁니다.
문서상 설계, 코드 존재, 빌드 확인, 런타임 검증은 서로 다른 근거 수준으로 기록합니다.

## 주요 문서

- [INDEX.md](INDEX.md): 전체 근거 문서 인덱스
- [portfolio-projects-role-map.md](portfolio-projects-role-map.md): `portfolio/`, `projects/`, `career/`, Drive 역할 분리 기준
- [drive-links.md](drive-links.md): Google Drive 원본 자료 위치
- [security-redaction-checklist.md](security-redaction-checklist.md): 공개 전 제거 항목
- [career/](career/): 이력서, 자소서, 면접 소재 정리
- [projects/](projects/): 프로젝트별 구현 근거 정리
- [portfolio/](portfolio/): 기존 공개 포트폴리오 근거

## 역할 분리

| 위치 | 역할 |
| --- | --- |
| `portfolio/` | 외부 공개 가능한 정제 포트폴리오 근거, sanitized evidence, 공개 가능한 코드/문서 근거 |
| `projects/` | 자소서/면접용 내부 working area, 직접 구현 / 팀 결과물 / 확인 필요 / 과장 위험 분류, 코드 근거 투입 대기 |
| `career/` | 프로젝트별 근거를 이력서, 자소서, 면접 소재로 변환하는 상위 정리 공간 |
| Drive `center` | 원본 문서, PPT, PDF, 영상, 이미지, 압축파일 보관 |

같은 프로젝트 설명을 여러 곳에 장문으로 반복하지 않습니다. 공개 가능한 정제 설명은 `portfolio/`,
claim 정리는 `projects/`, 전체 취업 포지셔닝은 `career/`, 원본 파일은 Drive에 둡니다.

## 기존 Portfolio Structure

| Folder | Purpose |
| --- | --- |
| `portfolio/01-escape-room` | 개인 프로젝트 EscapeRoom 핵심 코드 |
| `portfolio/02-coin-laundry` | 팀 프로젝트 1 인벤토리/상점 담당 범위 정리 |
| `portfolio/03-project3-fisher` | 팀 프로젝트 2 Fisher/Project3 및 AI-assisted workflow 정리 |
| `portfolio/_shared` | 공개 기준, 보안 기준, 면접 사용 기준 |

## 새 Evidence Structure

| Folder | Purpose |
| --- | --- |
| `career/` | 지원 포지셔닝, 자소서 소재, 면접 키워드, 주장 경계 |
| `projects/project1-escape-room/` | 개인 프로젝트 근거 정리 |
| `projects/project2-coin-survivor/` | 팀 프로젝트 1 근거 정리. 현재 경로명은 임시이며 Project2 canonical name 후보는 `Coin Laundry` |
| `projects/project3-fisher/` | 팀 프로젝트 2 / Project3 Fisher 근거 정리 |

## Project 분류 기준

| Project | 현재 기준 |
| --- | --- |
| Project1 | EscapeRoom 개인 프로젝트로 추정되는 자료를 받을 예정입니다. 기존 `portfolio/01-escape-room/` 공개 코드가 있으나 직접 구현/검증 범위는 문서별로 확인해 연결합니다. |
| Project2 | `Coin Laundry`를 canonical name 후보로 둡니다. 현재 `projects/project2-coin-survivor/` 경로는 rename 승인 전 임시 경로이며, Inventory / Shop / UI / EventBus / 디버깅 / 검증 근거를 받을 예정입니다. |
| Project3 | Fisher / CSH / 밸런스 / CloudScript / UI 아트 파이프라인 / 검증 문서 근거를 받을 예정입니다. 완성 게임 포트폴리오가 아니라 작업 방식, 검증, 문서화, 툴링 태도의 보조 근거로 다룹니다. |

## Public Scope

- 개인 프로젝트 코드는 공개 가능한 핵심 C# 파일만 선별해 둡니다.
- 팀 프로젝트 코드는 팀 권한과 공개 범위가 확정되기 전까지 원본 전체를 공개하지 않습니다.
- 팀 프로젝트 1/2는 핵심 파일명, 담당 책임, 설명 가능한 구조, 면접 질문 기준으로 정리합니다.
- PlayFab 설정, 서버 키, raw transcript, 팀원 개인정보, 유료 에셋, 팀 전체 소스는 공개하지 않습니다.
- 자소서 원문 전체와 이력서 원본 전체는 GitHub에 올리지 않습니다.

## Main Positioning

Unity와 C#으로 게임 시스템을 구현하면서, AI/Codex를 단순 코드 생성기가 아니라
코드베이스 분석, 영향 범위 제한, 검증 항목 정리, 로그와 current-truth 관리에 활용한 경험을 정리합니다.

단, AI/Codex 활용은 포트폴리오 보조 근거로 다룹니다. 실제 게임 완성도나 전체 시스템
성과를 대체하는 표현으로 사용하지 않습니다.

## 금지 표현

근거가 생기기 전까지 아래 표현은 사용하지 않습니다.

- 전부 직접 구현
- 전체 시스템 설계
- 서버 전체 구현
- 라이브 서비스 운영
- 상용 수준 완성
- 모든 버그 해결
- 팀 전체 코드 주도
- QA 전체 담당
- 밸런스 전체 확정

## 허용 가능한 표현 방향

근거가 있을 때만 아래처럼 범위를 제한해 표현합니다.

- 담당 범위 내 구현
- 특정 기능의 구조 개선
- 검증 로그 기반 문제 추적
- 팀 결과물 중 본인 기여 범위 명시
- 코드/문서/테스트 근거 기반 개선
- 포트폴리오 보조 근거
