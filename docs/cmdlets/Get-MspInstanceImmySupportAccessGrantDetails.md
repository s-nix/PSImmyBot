---
title: Get-MspInstanceImmySupportAccessGrantDetails
---

# Get-MspInstanceImmySupportAccessGrantDetails

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetMspInstanceImmySupportAccessGrantDetails` |
| Source | `Cmdlets/GetMspInstanceImmySupportAccessGrantDetails.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/system/immy-support-access-grant-details? |
| Return Type | `MspInstanceImmySupportAccessGrantDetails` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/system/immy-support-access-grant-details?` and deserializes to `MspInstanceImmySupportAccessGrantDetails`.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- `MspInstanceImmySupportAccessGrantDetails` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
