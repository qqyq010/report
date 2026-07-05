# Redaction Report

## Summary

This package is built for public or semi-public evidence review.
It intentionally removes original materials and keeps only sanitized summaries, short excerpts, and small samples.

## Removed Information

Removed from the package:

- Local absolute paths.
- Full Unity C# source files.
- Full workbook file.
- Full generated CSV files.
- Raw VM report JSON.
- Raw TitleData smoke JSON and upload payload references.
- CloudScript raw source.
- PlayFab payload, account state, title/account identifiers, credentials, and service state.
- Team log originals and private working notes.
- Team-member identity or ownership inference beyond generic role boundaries.
- Long Korean UI text and notes where not needed for structure evidence.

## Credential Pattern Review

The package was prepared to avoid credential-style material:

- No API key values.
- No bearer credentials.
- No authorization headers.
- No password or secret values.
- No service account payloads.

The code excerpts generalize request-gate sequence identifiers to avoid confusion with credential material.

## Public GitHub Range

Allowed for GitHub after user approval:

- `README.md`
- `evidence_index.md`
- `code_structure_summary.md`
- `data_validation_summary.md`
- `sanitized_excerpts.md`
- `redaction_report.md`

GitHub should receive only this sanitized package or a user-approved derivative.
It should not receive original source, workbook, raw CSV, raw JSON, service payload, or private logs.

## Private Drive Review Range

Allowed for private Drive review after user approval:

- This sanitized package.
- A zip containing only the six markdown files.
- Optional extra sanitized excerpts generated from the same rules.

Requires separate approval before inclusion:

- Original workbook.
- Original generated CSV sets.
- Raw VM or smoke reports.
- TitleData JSON originals.
- Any team logs or recordings.

## Hold List

Keep out of public review:

- Full `.cs` files.
- Original `.xlsx` workbook.
- Full Generated CSV and BalanceCore CSV files.
- Raw `.project3-local` reports.
- CloudScript raw source.
- PlayFab payloads and live service state.
- Team or personal log originals.

## Review Result

This package is suitable as a public sanitized evidence package after final user approval.
It is also suitable as an external GPT review pack because the zip contains only the six markdown files and no original project assets.
