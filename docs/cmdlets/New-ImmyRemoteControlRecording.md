---
title: New-ImmyRemoteControlRecording
---

# New-ImmyRemoteControlRecording

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewRemoteControlRecording` |
| Source | `Cmdlets/NewRemoteControlRecording.cs` |
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
| BlobName | `String` | False | — | All | None |
| Computer | [Computer](../models/Computer.md) | True | — | All | None |
| ComputerId | `Int32` | True | — | All | None |
| CreatedBy | `Nullable`1` | False | — | All | None |
| CreatedDate | `DateTimeOffset` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| MimeContentType | `String` | False | — | All | None |
| Tenant | [Tenant](../models/Tenant.md) | True | — | All | None |
| TenantId | `Int32` | True | — | All | None |
| UpdatedBy | `Nullable`1` | False | — | All | None |
| UpdatedDate | `DateTimeOffset` | True | — | All | None |
| User | [User](../models/User.md) | True | — | All | None |
| UserId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
