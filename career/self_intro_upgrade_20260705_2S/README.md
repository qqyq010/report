# Unity Portfolio Sanitized Evidence Package

## Purpose

This package is a sanitized evidence package for resume, technical-document, and presentation use.
It includes Project1 script samples and Project3 boundary-management evidence.
It is not a full source-code archive, not a workbook archive, and not a raw project export.

The package preserves only the evidence needed to explain defensible portfolio claims:

- Project1 failure recovery, checkpoint restore, detection, interaction, and movement flow through sanitized script samples.
- UI request, server response, and local snapshot boundary handling.
- Adapter and bridge responsibility separation.
- Request gate behavior for duplicate request prevention, stale callback filtering, and timeout recovery.
- Local candidate checks for CloudScript VM, TitleData smoke, Generated CSV validator, and workbook consistency.
- Redaction boundaries for public GitHub and private Drive review.

## Scope

Included:

- Public-facing evidence index.
- Code structure summary based on verified file names and class/method roles.
- Data validation summary with pass/fail counts and explicit limits.
- Short sanitized code excerpts, each kept below full-source disclosure level.
- CSV samples limited to header plus representative rows.
- Redaction report for sharing boundaries.

Excluded:

- Full `.cs` source files.
- Original `.xlsx` workbook.
- Full generated CSV files.
- CloudScript raw source.
- PlayFab payload, account state, credentials, or live service state.
- Team log originals and private working notes.
- Local absolute paths.

## Project1 Code Evidence

Project1 scripts are sanitized portfolio samples. They are not the full original Unity project.
Project-specific paths, assets, debug code, and non-essential implementation details were removed.
These samples are intended to support the portfolio explanation of failure recovery, checkpoint restore, detection, interaction, and movement flow.

- [Project1 script sample README](scripts/project1/README.md)
- [GameManager_sample.cs](scripts/project1/GameManager_sample.cs)
- [ProgressState_sample.cs](scripts/project1/ProgressState_sample.cs)
- [FailureHandler_sample.cs](scripts/project1/FailureHandler_sample.cs)
- [CheckpointManager_sample.cs](scripts/project1/CheckpointManager_sample.cs)
- [EnemyVision_sample.cs](scripts/project1/EnemyVision_sample.cs)
- [PlayerInteraction_sample.cs](scripts/project1/PlayerInteraction_sample.cs)
- [PlayerMove_sample.cs](scripts/project1/PlayerMove_sample.cs)
- [Project1 redaction report](redaction_report_project1.md)

## Project3 Claim Boundary

Project3 should be presented as local candidate verification and boundary-management experience, not as a shipped or final product.

Safe framing:

- "I checked local candidates with VM, smoke, validator, and workbook summary evidence."
- "I separated UI adapter responsibility from bridge request/response handling."
- "I used request gates and snapshot suppression to reduce stale-state and duplicate-request risks."

Unsafe framing:

- Claiming deployed service proof from local VM/smoke results.
- Claiming final economy outcome from workbook and validator results.
- Claiming sole ownership of the whole team project.

## How To Review

Recommended review order:

1. `evidence_index.md`
2. `code_structure_summary.md`
3. `data_validation_summary.md`
4. `sanitized_excerpts.md`
5. `redaction_report.md`
6. `scripts/project1/README.md`
7. `redaction_report_project1.md`

For an external GPT review, upload only the reviewed public package files listed above.
Do not attach original project source, workbook, raw CSV, raw JSON, or project logs unless a separate private review has been approved.
