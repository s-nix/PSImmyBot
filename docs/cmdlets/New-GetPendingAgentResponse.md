---
title: New-GetPendingAgentResponse
---

# New-GetPendingAgentResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewGetPendingAgentResponse` |
| Source | `Cmdlets/NewGetPendingAgentResponse.cs` |
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
| ComputerId | `Nullable`1` | False | — | All | None |
| ComputerName | `String` | False | — | All | None |
| DateAdded | `DateTimeOffset` | True | — | All | None |
| ExternalAgentId | `String` | False | — | All | None |
| ExternalClientName | `String` | False | — | All | None |
| Failed | `Boolean` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| IdentificationFailures | `ICollection`1` | False | — | All | None |
| IsComputerDeleted | `Boolean` | True | — | All | None |
| IsOnline | `Boolean` | True | — | All | None |
| Manufacturer | `String` | False | — | All | None |
| OperatingSystemName | `String` | False | — | All | None |
| OsInstallDateUtc | `Nullable`1` | False | — | All | None |
| ProviderLinkId | `Int32` | True | — | All | None |
| ProviderLinkName | `String` | False | — | All | None |
| RequireManualIdentification | `Boolean` | True | — | All | None |
| RequiresManualResolution | `Boolean` | True | — | All | None |
| Serial | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
