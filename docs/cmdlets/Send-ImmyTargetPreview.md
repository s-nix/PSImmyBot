---
title: Send-ImmyTargetPreview
---

# Send-ImmyTargetPreview

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendTargetPreview` |
| Source | `Cmdlets/SendTargetPreview.cs` |
| HTTP Method | Custom |
| Endpoint | /api/v1/target-assignments/target-preview? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Refer to the source implementation for detailed flow; this cmdlet performs custom orchestration beyond simple API proxying.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [CalculateTargetsRequest](../models/CalculateTargetsRequest.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
