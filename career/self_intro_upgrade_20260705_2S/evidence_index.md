# Evidence Index

## Summary

This index connects sanitized evidence to claims that can be reused across a resume, technical document, and presentation.
Verification levels are intentionally narrow. Local checks are not treated as deployed service proof.

| evidence_id | connected claim | evidence file | verification level | public level | resume use | technical doc use | PPT use |
| --- | --- | --- | --- | --- | --- | --- | --- |
| E-CODE-01 | Common request gate prevents duplicate requests and filters stale callbacks. | `FisherServerMutationGate.cs` | Direct code check | Sanitized excerpt only | Request gate claim | Request lifecycle section | One flow slide |
| E-CODE-02 | Bridge separates snapshot pull, server request, and mutation response application. | `FisherPlayerDataBridge.cs` | Direct code check | Structure summary plus short excerpt | Adapter/bridge boundary claim | Runtime integration section | Architecture slide |
| E-CODE-03 | Shop UI routes purchase through bridge success/reject callbacks instead of directly finalizing local state. | `ShopPanelAdapter.cs` | Direct code check | Sanitized excerpt only | Shop purchase boundary claim | Shop request sequence | UI-to-server flow slide |
| E-CODE-04 | Cooking UI manages start/claim/cancel/speedup request state with gate and timeout recovery. | `CookingPanelAdapter.cs` | Direct code check | Sanitized excerpt only | Cooking state-risk claim | Cooking request sequence | Failure recovery slide |
| E-CODE-05 | Bag UI handles sell request callbacks through bridge and restores UI state on rejection. | `BagPanelAdapter.cs` | Direct code check | Sanitized excerpt only | Inventory sell boundary claim | Inventory mutation section | Error path slide |
| E-CODE-06 | Collection reward claim is routed through request gate and bridge callback paths. | `CollectionPanelAdapter.cs` | Direct code check | Sanitized excerpt only | Reward claim boundary claim | Collection reward section | Claim flow slide |
| E-DATA-01 | CloudScript candidate behavior passed local VM checks. | `full80-report.json` summary | Local VM candidate check, 37 pass / 0 fail | Count summary only | Local candidate validation claim | VM result caveat | Metric callout |
| E-DATA-02 | TitleData upload candidate shape passed smoke checks. | `full80-generated-upload-payload-smoke.json` summary | Local smoke check, 11 pass / 0 fail / 0 warnings | Count summary only | TitleData candidate claim | Smoke result caveat | Metric callout |
| E-DATA-03 | Generated CSV references and schemas passed validator checks. | `generated_csv_validator_results.md/.csv` summary | Local validator, 129 pass / 0 error / 0 warning | Summary and redacted sample | CSV consistency claim | Data validation section | Metric callout |
| E-DATA-04 | Workbook version `v0.5.7-ko` produced pass summary and generated output checks. | `fisher-balance-workbook-v0.5.7-ko-summary.json` summary | Workbook summary check | Summary only | Workbook-based candidate claim | Balance workflow section | Workbook evidence slide |
| E-DATA-05 | Generated CSV files expose shop, recipe, collection, item, gacha, and parameter schemas. | Generated CSV samples | Header plus 1-3 sample rows | Redacted samples only | Data-contract learning claim | Data schema appendix | Table sample slide |
| E-RED-01 | Public sharing excludes raw source, workbook, raw CSV, raw JSON, and service payloads. | `redaction_report.md` | Package policy check | Public | Sharing safety claim | Appendix | Risk-control slide |

## Safe Claim Candidates

- UI adapters and data bridge roles were separated so UI interaction did not directly stand in for server mutation completion.
- Request gate logic was used to handle duplicate requests, stale callbacks, and timeout recovery.
- VM, smoke, validator, and workbook checks were used to review local candidates before any stronger service-level claim.
- AI/Codex output was treated as a candidate-generation and risk-review aid, with adoption limited by local files and validators.

## Claims To Avoid

- Whole-project sole ownership.
- Deployed service proof based only on local VM or smoke results.
- Final economy outcome based only on workbook or CSV validator checks.
- Public sharing of original code, workbook, raw generated data, or service payloads.
