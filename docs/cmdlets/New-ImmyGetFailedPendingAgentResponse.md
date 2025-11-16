---
title: New-ImmyGetFailedPendingAgentResponse
---

# New-ImmyGetFailedPendingAgentResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewGetFailedPendingAgentResponse` |
| Source | `Cmdlets/NewGetFailedPendingAgentResponse.cs` |
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
| ComputerName | `String` | False | — | All | None |
| DateAdded | `DateTimeOffset` | True | — | All | None |
| DeviceId | `String` | False | — | All | None |
| ExternalAgentId | `String` | False | — | All | None |
| ExternalClientName | `String` | False | — | All | None |
| Id | `Int32` | True | — | All | None |
| IdentificationFailures | `ICollection`1` | False | — | All | None |
| IsOnline | `Boolean` | True | — | All | None |
| OperatingSystemName | `String` | False | — | All | None |
| OsInstallDate | `Nullable`1` | False | — | All | None |
| OsInstallDateUtc | `Nullable`1` | False | — | All | None |
| ProviderLinkName | `String` | False | — | All | None |
| Serial | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
