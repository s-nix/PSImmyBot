---
title: New-GetUserAffinityResponse
---

# New-GetUserAffinityResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewGetUserAffinityResponse` |
| Source | `Cmdlets/NewGetUserAffinityResponse.cs` |
| HTTP Method | Custom |
| Endpoint | Not applicable |
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
| ComputerId | `Int32` | True | — | All | None |
| Date | `DateTimeOffset` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| Person | [GetPersonResponse](../models/GetPersonResponse.md) | True | — | All | None |
| PersonId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
