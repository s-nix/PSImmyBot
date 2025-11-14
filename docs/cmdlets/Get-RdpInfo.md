---
title: Get-RdpInfo
---

# Get-RdpInfo

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetRdpInfo` |
| Source | `Cmdlets/GetRdpInfo.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/dev-lab/{ComputerId}/rdp-info? |
| Return Type | `GetRdpInfoResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/dev-lab/{ComputerId}/rdp-info?` and deserializes to `GetRdpInfoResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ComputerId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `GetRdpInfoResponse` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
