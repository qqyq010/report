# Portfolio / Projects Role Map

## 목적

`portfolio/`, `projects/`, `career/`, Drive `center`의 역할을 분리해 같은 내용을 장문으로 중복 작성하지 않도록 한다.

## portfolio/의 역할

- 외부 공개 가능한 포트폴리오 근거를 둔다.
- 정제된 프로젝트 설명과 sanitized evidence를 둔다.
- 공개 가능한 코드/문서 근거만 둔다.
- 기존 구조를 유지한다.

## projects/의 역할

- 자소서/면접용 내부 정리 공간으로 사용한다.
- 직접 구현 / 팀 결과물 / 확인 필요 / 과장 위험을 분류한다.
- 면접 답변 준비용 메모와 claim 후보를 둔다.
- 코드 근거 투입 대기 공간으로 사용한다.
- 아직 공개 포트폴리오 문장으로 확정하지 않은 working area로 둔다.

## career/의 역할

- 프로젝트별 근거를 이력서, 자소서, 면접 소재로 변환하는 상위 정리 공간이다.
- 개별 프로젝트 설명을 길게 반복하지 않고, `projects/`와 `portfolio/`를 참조한다.
- 지원 포지셔닝, 주장 경계, 검증 필요 항목을 관리한다.

## Drive center의 역할

- 원본 문서, PPT, PDF, 영상, 이미지, 압축파일을 보관한다.
- 자소서 초안, 이력서 원본, 최종 제출본, 원본 피드백을 보관한다.
- Drive 원본을 GitHub에 복사하지 않고 GitHub에는 링크와 요약만 둔다.

## 중복 작성 방지 기준

- 공개 가능한 정제 설명은 `portfolio/`에 둔다.
- 자소서/면접용 claim 정리는 `projects/`에 둔다.
- 전체 취업 포지셔닝은 `career/`에 둔다.
- 원본 파일은 Drive `center`에 둔다.
- GitHub에는 링크와 요약만 둔다.
- 같은 프로젝트 설명을 두 군데에 장문으로 반복하지 않는다.

## 자소서 작성 시 참조 우선순위

1. `career/claim-boundary.md`
2. `career/self-introduction-materials.md`
3. `projects/<project>/`
4. `portfolio/<project>/`
5. `drive-links.md`

## 면접 준비 시 참조 우선순위

1. `projects/<project>/interview-points.md`
2. `projects/<project>/technical-evidence.md`
3. `career/interview-keywords.md`
4. `portfolio/<project>/`
5. Drive 원본 자료

## 공개 포트폴리오로 옮기기 전 검수 기준

- 직접 구현과 팀 결과물 / 협업 기여가 분리되어 있는가?
- 확인 필요 항목이 확정 표현으로 바뀌지 않았는가?
- 과장 위험 표현이 제거되었는가?
- 민감정보, 팀원 개인정보, 유료 에셋 원본, 대용량 원본이 빠졌는가?
- Drive 원본을 GitHub에 복사하지 않고 링크와 요약만 남겼는가?
- Project3는 완성 게임 포트폴리오가 아니라 보조 근거로 유지되는가?
