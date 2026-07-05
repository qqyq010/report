# Sanitized Excerpts

## Scope And Rules

These excerpts are not full source disclosure.
They are short, sanitized samples selected to show structure and claim support.

Rules applied:

- File names only, no local absolute paths.
- No raw CloudScript source.
- No PlayFab payload or account state.
- No full workbook, full CSV, or raw JSON.
- No team log originals.
- Code excerpts are intentionally short and incomplete.
- CSV samples are limited to header plus representative rows.
- Request sequence identifiers are generalized in excerpts to avoid credential-token confusion.

## C# Excerpts

### FisherServerMutationGate.cs

Claim supported: common request gate for duplicate request prevention and stale callback filtering.

```csharp
internal sealed class FisherServerRequestGate
{
    private int _requestSequence;
    private float _startedAt;
    private string _requestName = string.Empty;

    public bool IsBusy { get; private set; }
    public int RequestSequence => _requestSequence;

    public bool IsBusyFor(string requestName)
    {
        return IsBusy && string.Equals(
            _requestName,
            requestName ?? string.Empty,
            System.StringComparison.Ordinal);
    }

    public bool TryBegin(string requestName)
    {
        if (IsBusy)
        {
            return false;
        }

        IsBusy = true;
        _requestSequence++;
        _startedAt = Time.unscaledTime;
        _requestName = requestName ?? string.Empty;
        return true;
    }

    public bool TryComplete(int requestSequence)
    {
        if (!IsCurrent(requestSequence))
        {
            return false;
        }

        Invalidate();
        return true;
    }
}
```

### FisherPlayerDataBridge.cs

Claim supported: bridge layer separates snapshot pulls and mutation result handling from UI adapters.

```csharp
public bool PullDisplaySnapshotsFromPlayFabDataStore(
    bool notify = true,
    bool forceInventory = false,
    bool forceCooking = false)
{
    bool changedOrApplied = false;
    changedOrApplied |= PullCurrenciesFromPlayFabDataStore(notify: false);
    changedOrApplied |= PullInventoryFromPlayFabDataStore(notify: false, force: forceInventory);
    changedOrApplied |= PullCookingFromPlayFabDataStore(notify: false, force: forceCooking);

    if (notify && changedOrApplied)
    {
        _context?.NotifyRuntimeChanged();
    }

    return changedOrApplied;
}

private void HandlePlayFabMutationResult(
    PlayFabGateway gateway,
    ExecuteCloudScriptResult result,
    string operation,
    object requestArgs,
    Action onApplied,
    Action<string> onRejected)
{
    if (!TryReadMutationSuccess(gateway, result, operation, out string rejectMessage, out CloudScriptMutationResponse response))
    {
        HandleRejectedMutation(gateway, operation, response, onRejected, rejectMessage);
        return;
    }

    HandleAcceptedMutation(gateway, operation, requestArgs, response, onApplied, onRejected);
}
```

### ShopPanelAdapter.cs

Claim supported: shop purchase UI routes through bridge callbacks and request gate completion.

```csharp
private void PurchaseAndRefresh(string shopItemId, Sprite toastIcon, string toastTitle, string toastMeta)
{
    if (!TryBeginServerShopPurchaseRequest(shopItemId))
    {
        Refresh();
        return;
    }

    int requestSequence = _purchaseRequest.RequestSequence;
    FisherPlayerDataBridge bridge = ShopBridge();
    if (bridge == null ||
        !bridge.TryRequestShopPurchase(
            shopItemId,
            () => CompleteServerShopPurchaseRequest(requestSequence, "purchase applied", toastIcon, toastTitle, toastMeta),
            message => HandleServerShopPurchaseRejected(requestSequence, message, shopItemId)))
    {
        AbortServerShopPurchaseRequest(requestSequence, "PurchaseShopItem request failed");
        return;
    }

    _lastMessage = "purchase request pending";
    _purchaseSheetStatusOverride = "pending";
    Refresh();
}

private bool TryBeginServerShopPurchaseRequest(string shopItemId)
{
    if (!_purchaseRequest.TryBegin(shopItemId))
    {
        return false;
    }

    _lastMessage = "server purchase request pending";
    return true;
}
```

### CookingPanelAdapter.cs

Claim supported: cooking request state uses bridge callbacks and timeout recovery.

```csharp
if (!TryBeginServerCookingRequest("StartCooking"))
{
    Refresh();
    return;
}

int requestSequence = _cookingRequest.RequestSequence;
FisherPlayerDataBridge bridge = CookingBridge();
if (bridge == null ||
    !bridge.TryRequestCookingStart(
        slotIndex,
        recipe.RecipeId,
        safeCount,
        () =>
        {
            CompleteServerCookingRequest(requestSequence, "cooking request applied");
        },
        message => HandleServerCookingStartRejected(requestSequence, message, recipe, safeCount)))
{
    AbortServerCookingRequest(requestSequence, "StartCooking request failed");
    return;
}

private void RecoverExpiredServerCookingRequest()
{
    if (!_cookingRequest.TryRecoverTimeout(
            _serverCookingRequestTimeoutSeconds,
            "Cooking",
            out string requestName))
    {
        return;
    }

    _lastMessage = "server response delayed";
    SuppressPlayFabDataStorePull();
    Refresh();
}
```

### BagPanelAdapter.cs

Claim supported: inventory sell waits for bridge result before completing visible flow.

```csharp
ClampSellCount(current);
int sellCount = _sellCount;
CurrencyMath.TryMultiply(current.SellPrice, sellCount, out long sellGain);
Sprite soldIcon = FisherRuntimeUi.ResolveItemIcon(_artProfile, current.ItemId, current.Category);
int saleRequestSequence = BeginSaleRequestTimeout(current.ItemId);
FisherPlayerDataBridge bridge = ResolvePlayerDataBridge();
if (bridge == null ||
    !bridge.TryRequestInventorySell(current.ItemId, sellCount, () =>
    {
        if (!TryCompleteSaleRequest(saleRequestSequence))
        {
            return;
        }

        _lastMessage = "sale applied";
        ShowBagResultToast(
            soldIcon,
            "sale complete",
            current.DisplayNameKo + " " + CompactNumberFormatter.FormatCount(sellCount) +
            "\nTotal " + CompactNumberFormatter.FormatGold(sellGain));
        if (current.Count <= sellCount)
        {
            _selectedItemId = string.Empty;
        }

        CloseSaleUiAndRefresh();
    },
    message =>
    {
        if (!TryCompleteSaleRequest(saleRequestSequence))
        {
            return;
        }

        _lastMessage = string.IsNullOrWhiteSpace(message) ? "sale failed" : message;
        CloseSaleUiAndRefresh();
    }))
{
    CloseSaleUiAndRefresh();
}
```

### CollectionPanelAdapter.cs

Claim supported: collection reward claim routes success and rejection through request gate.

```csharp
private void RequestServerCollectionRewardClaim(string rewardId)
{
    if (string.IsNullOrEmpty(rewardId) || _collectionRewardRequest.IsBusy)
    {
        return;
    }

    int requestSequence = BeginCollectionRewardRequestTimeout(rewardId);
    FisherPlayerDataBridge bridge = ResolvePlayerDataBridge();
    if (bridge == null ||
        !bridge.TryRequestCollectionRewardClaim(
            rewardId,
            () =>
            {
                if (!TryCompleteCollectionRewardRequest(requestSequence))
                {
                    return;
                }

                _lastMessage = "collection reward applied";
                _context?.NotifyRuntimeChanged();
                ShowCollectionRewardReceipt(rewardId);
                Refresh();
            },
            message =>
            {
                if (!TryCompleteCollectionRewardRequest(requestSequence))
                {
                    return;
                }

                _lastMessage = string.IsNullOrWhiteSpace(message) ? "collection reward failed" : message;
                Refresh();
            }))
    {
        _collectionRewardRequest.TryAbort(requestSequence);
        _lastMessage = "collection reward request failed";
        Refresh();
    }
}
```

## CSV Samples

### generated_csv_validator_results.csv

```csv
checkId,artifact,severity,status,message,nextAction
schema_contract_count,generated_csv_schema_spec.csv,info,pass,Found 17 Generated CSV contracts.,
sample_header:balance_params.csv,redacted/sample_pack/balance_params.csv,info,pass,Header matches requiredColumns.,
sample_rows:balance_params.csv,redacted/sample_pack/balance_params.csv,info,pass,Sample pack has exactly one schema-only row.,
```

### shop_items.csv

```csv
shopItemId,category,priceType,priceAmount,rewardItemId,rewardCount,unlockCondition,sortOrder,isEnabled,notes,visibilityCondition
shop_upgrade_common_pack_001,gold,softCurrency,3000,mat_upgrade_common,1,stage>=1,100,TRUE,[sanitized note],
shop_upgrade_common_pack_002,gold,softCurrency,15000,mat_upgrade_common,5,stage>=2,110,TRUE,[sanitized note],
```

### recipes.csv

```csv
recipeId,inputItemId,inputCount,inputItemId2,inputCount2,durationSec,outputItemId,outputCount,crewExp,unlockCondition,isEnabled,notes
recipe_grilled_anchovy_g1,fish_anchovy,1,fish_saury,1,60,food_grilled_anchovy,1,5,stage>=1,TRUE,[sanitized note]
recipe_grilled_mackerel_g1,fish_mackerel,1,fish_anchovy,1,90,food_grilled_mackerel,1,6,stage>=1,TRUE,[sanitized note]
```

### collection_rewards.csv

```csv
rewardId,itemId,conditionType,conditionValue,rewardCurrency,rewardAmount,rewardItemId,rewardItemCount,claimId,sortOrder,isEnabled,notes
codex_fish_anchovy_count_1,fish_anchovy,count,1,,0,ticket_basic,1,codex:fish:fish_anchovy:discovery,1001,TRUE,[sanitized note]
codex_fish_anchovy_count_10,fish_anchovy,count,10,,0,ticket_basic,1,codex:fish:fish_anchovy:count10,1002,TRUE,[sanitized note]
```

### balance_params.csv

```csv
key,value,valueType,unit,scope,isEnabled,applyMode,sourceSheet,sourceRange,sourceKey,precision,sourceHash,notes
fishing_manual_base_reward,1.3,float,contribution,fishing,TRUE,apply,08_ManualFishingEfficiency,,_baseReward,0.000001,,manual catch contribution base
fishing_auto_target_contribution,0.49,float,contribution,fishing,TRUE,validateOnly,08_ManualFishingEfficiency,,manualBase*autoPenalty,0.000001,,auto contribution target after penalty
```

### gacha_rate_tiers.csv

```csv
bannerId,rollLayer,rewardType,grade,ratePct,rateDecimal,isRemainder,isEnabled,applyMode,sourceSheet,sourceRange,sourceKey,precision,sourceHash,notes
premium_crew,crew_grade,Crew,R,80,0.8,FALSE,TRUE,apply,10_GachaProbability,,_rRate,0.0001,,premium crew grade R rate
premium_crew,crew_grade,Crew,SR,17,0.17,FALSE,TRUE,apply,10_GachaProbability,,_srRate,0.0001,,premium crew grade SR rate
```

## Workbook And JSON Summaries

Workbook:

- Version: `v0.5.7-ko`
- Status: `pass`
- Error scan count: `0`
- Sheet-level source workbook is not included.
- Full workbook is not included.

CloudScript VM:

- Candidate check: `37 pass / 0 fail`
- Raw report is not included.

TitleData smoke:

- Smoke check: `11 pass / 0 fail / 0 warnings`
- Raw payload and raw report are not included.

Generated CSV validator:

- Validator check: `129 pass / 0 error / 0 warning`
- Full validator CSV is not included.
