# Tools And Verification

## Local Tools

| Tool Type | Purpose | Portfolio Use |
| --- | --- | --- |
| Markdown checker | 문서 링크와 기본 형식 점검 | 문서 기반 workflow 검증 |
| Token/context checker | 긴 문서와 AI context 부담 확인 | AI 작업 효율 관리 |
| Local launcher | 자주 쓰는 로컬 점검 명령 묶음 | 반복 점검 체계 설명 |
| Balance validator | 샘플 balance CSV 검증 | 수치/데이터 검증 습관 |
| Economy simulator | idle economy 후보 비교 | balance-risk warning으로만 설명 |
| Server catalog exporter | Fisher server catalog 후보 생성 | 업로드가 아니라 로컬 검토용 |
| Handoff organizer | handoff 문서 정리 | 협업 인수인계 관리 |
| Memory/log index | 로그와 문서 검색 | current-truth 우선 구조 설명 |

## Verification Labels

| Label | What It Means |
| --- | --- |
| Code Only | 코드 작성 또는 구조 확인 |
| Direct Code Check | 관련 호출/참조를 코드상 확인 |
| Generated Project Build Checked | C# build 또는 self-test 통과 |
| Asset Text Checked | Unity asset text를 확인 |
| Prefab Checked | prefab reference 확인 |
| Scene Checked | scene binding 확인 |
| Play Mode Checked | Unity Play Mode에서 직접 확인 |
| Live Checked | PlayFab/server/live 환경에서 확인 |

## Important Caveat

`dotnet build` 또는 self-test 성공은 Unity Play Mode 성공이나 PlayFab live 성공을 의미하지 않습니다.
