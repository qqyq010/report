# Career Evidence Index

## Purpose

This index links career-material evidence without copying original documents or large assets into GitHub.
It is a routing document for evidence, not a finished resume, self-introduction, or presentation.

## 사용 기준

- 직접 구현, 팀 결과물 / 협업 기여, 확인 필요, 과장 위험을 분리한다.
- 근거가 들어오기 전까지 완성 문장으로 확정하지 않는다.
- Drive 원본은 복사하지 않고 링크와 요약만 둔다.
- 각 프로젝트 문서는 자소서 문장보다 먼저 코드/문서/검증 근거를 연결한다.

## Core Documents

- [Repository README](README.md): repo 운영 기준과 공개 범위
- [Portfolio / projects role map](portfolio-projects-role-map.md): `portfolio/`, `projects/`, `career/`, Drive 역할 분리
- [Drive links](drive-links.md): 원본 자료 보관 위치
- [Security redaction checklist](security-redaction-checklist.md): 공개 전 제거 항목

## 저장 위치 기준

| 위치 | 사용 기준 |
| --- | --- |
| `portfolio/` | 외부 공개 가능한 정제 설명과 sanitized evidence |
| `projects/` | 자소서/면접용 내부 claim 정리와 근거 투입 대기 |
| `career/` | 프로젝트별 근거를 지원 포지셔닝과 자소서/면접 소재로 변환 |
| Drive `center` | 원본 문서, PPT, PDF, 영상, 이미지, 압축파일 |

중복을 피하기 위해 장문 프로젝트 설명은 한 위치에만 둔다. 다른 문서는 링크와 요약만 남긴다.

## Career Materials

- [Resume positioning](career/resume-positioning.md): 이력서 포지셔닝 후보와 근거 수준
- [Self-introduction materials](career/self-introduction-materials.md): 자소서 소재 후보와 확인 필요 항목
- [Interview keywords](career/interview-keywords.md): 면접 키워드와 설명 가능 범위
- [Claim boundary](career/claim-boundary.md): 말할 수 있는 범위와 금지 표현
- [Verification needed](career/verification-needed.md): 아직 확정하지 않은 항목

## Project Evidence

- [Project 1 - Escape Room](projects/project1-escape-room/summary.md): 개인 프로젝트 근거 정리
- [Project 2 - Coin Survivor](projects/project2-coin-survivor/summary.md): 팀 프로젝트 1 근거 정리
- [Project 3 - Fisher](projects/project3-fisher/summary.md): 팀 프로젝트 2 / Project3 보조 근거 정리

## Project 분류 기준

| Project | 직접 구현 후보 | 팀 결과물 / 협업 기여 | 확인 필요 | 과장 위험 |
| --- | --- | --- | --- | --- |
| Project1 | EscapeRoom, 퍼즐, 잠입 요소 | 개인 프로젝트라 팀 기여는 기본적으로 해당 없음 | 기존 `portfolio/01-escape-room/` 코드와 실제 직접 구현 범위 연결 | 근거 없이 전체 게임 완성도나 모든 시스템 구현 주장 |
| Project2 | Inventory, Shop, UI, EventBus, 디버깅 | 팀 프로젝트 1 결과물 중 본인 담당 범위 | Coin Survivor와 기존 `portfolio/02-coin-laundry/` 명칭/근거 연결 | 팀 전체 성과를 개인 구현처럼 표현 |
| Project3 | Fisher, CSH, 밸런스, CloudScript, UI 아트 파이프라인 검증 문서 | 팀 프로젝트 2의 협업/검증/문서화/툴링 기여 | 직접 구현, 문서상 설계, 실제 실행 검증 분리 | 완성 게임 포트폴리오 또는 메인 프로젝트처럼 과장 |

## 확인 필요

- TODO: 기존 `portfolio/` 문서와 새 `projects/` 문서의 연결 기준 확정.
- TODO: 각 프로젝트별 공개 가능한 코드 근거 범위 확정.
- TODO: Drive 원본 자료 중 GitHub에 링크만 둘 자료 목록 확정.
- TODO: 자소서 초안과 기술문서에 연결할 문서 우선순위 확정.
