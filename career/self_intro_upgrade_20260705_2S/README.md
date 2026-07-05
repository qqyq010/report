# Project3 Sanitized Evidence Package

## Purpose

This package is a sanitized evidence package for resume, technical-document, and presentation use.
It is not a source-code archive, not a workbook archive, and not a raw project export.

The package preserves only the evidence needed to explain defensible Project3 claims:

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

For an external GPT review, upload only the zip generated from these six markdown files.
Do not attach original project source, workbook, raw CSV, raw JSON, or project logs unless a separate private review has been approved.
