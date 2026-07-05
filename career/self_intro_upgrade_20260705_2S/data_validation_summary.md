# Data Validation Summary

## Summary

The data evidence supports local candidate validation, not final service or economy claims.
The counts below are useful because they show a disciplined verification path: VM checks, TitleData smoke checks, Generated CSV validator checks, and workbook summary checks.

## Result Counts

| evidence | result | what it supports | what it does not support |
| --- | ---: | --- | --- |
| CloudScript VM candidate check | 37 pass / 0 fail | Local candidate behavior matched the VM test expectations. | Does not prove deployed PlayFab revision behavior, live account state, production latency, or scene bindings. |
| TitleData smoke check | 11 pass / 0 fail / 0 warnings | Upload candidate shape and required TitleData list parsing were locally checked. | Does not prove the data was deployed to a live title or approved as production content. |
| Generated CSV validator | 129 pass / 0 error / 0 warning | Schema, sample pack, current generated CSV, and contract-style consistency checks passed locally. | Does not prove gameplay feel, player economy outcome, or live service state. |
| Workbook `v0.5.7-ko` summary | status pass | Workbook generation and selected output checks were internally consistent. | Does not prove final balance, release readiness, or business approval. |

## Workbook Summary

Observed workbook summary fields:

- Workbook version: `v0.5.7-ko`
- Previous version: `v0.5.6-ko`
- Status: `pass`
- Error scan count: `0`
- Applied local row counts:
  - balance parameter apply rows: `18`
  - balance parameter validate-only rows: `7`
  - gacha rate rows: `6`
  - gacha duplicate reward rows: `3`
  - stage fish weight rows: `98`
  - hot spot stage rows: `4`
  - food crew-exp rows: `17`
  - upload payload keys: `10`
- Gacha sum checks:
  - premium crew grade sum: `100`
  - basic material reward type sum: `100`
- Generated output existence checks:
  - `balance_params.csv`: exists
  - `gacha_rate_tiers.csv`: exists
  - `gacha_duplicate_rewards.csv`: exists
  - `rms_stage_fish_weights.csv`: exists

## TitleData Smoke Summary

Required list counts checked by smoke result:

| list | count |
| --- | ---: |
| FishList | 30 |
| FoodList | 17 |
| IngredientList | 4 |
| TicketList | 7 |
| BoxList | 4 |
| FragmentList | 10 |
| RecipeList | 17 |
| ShopItemList | 20 |
| PremiumCurrencyProductList | 3 |
| CollectionRewardList | 135 |

## Validator Scope

The validator result is useful for public evidence because it shows:

- Generated CSV contracts were checked.
- Sample-pack headers and one-row schema samples were checked.
- Current generated CSV files were checked against expected structure.
- Result reports were written without requiring raw workbook or raw service payload disclosure.

The validator result should be described as a local consistency check.
It should not be used to claim final balance quality, live service correctness, or production approval.

## Safe Wording

Use:

- "local candidate checks"
- "schema and generated-output consistency"
- "workbook-backed candidate review"
- "VM/smoke checks before stronger service-level claims"

Avoid:

- Service-deployment claims based only on local checks.
- Final economy claims based only on workbook or validator output.
- Release-readiness claims based only on this package.
