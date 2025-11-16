---
title: Send-ImmyCalculateTargetsRequest
---

# Send-ImmyCalculateTargetsRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendCalculateTargetsRequest` |
| Source | `Cmdlets/SendCalculateTargetsRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/target-assignments/persons-target-preview? |
| Return Type | [CalculateTargetsRequest](../models/CalculateTargetsRequest.md), List<[TargetedPerson](../models/TargetedPerson.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/target-assignments/persons-target-preview?` and deserializes to [CalculateTargetsRequest](../models/CalculateTargetsRequest.md), List<[TargetedPerson](../models/TargetedPerson.md)>.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [CalculateTargetsRequest](../models/CalculateTargetsRequest.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [CalculateTargetsRequest](../models/CalculateTargetsRequest.md), List<[TargetedPerson](../models/TargetedPerson.md)> records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
