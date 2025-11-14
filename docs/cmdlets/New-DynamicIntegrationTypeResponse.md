---
title: New-DynamicIntegrationTypeResponse
---

# New-DynamicIntegrationTypeResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewDynamicIntegrationTypeResponse` |
| Source | `Cmdlets/NewDynamicIntegrationTypeResponse.cs` |
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
| CreatedDateUtc | `DateTimeOffset` | True | — | All | None |
| CreationErrorMessage | `String` | False | — | All | None |
| DatabaseType | `DatabaseType` | True | — | All | None |
| DocsUrl | `String` | False | — | All | None |
| Enabled | `Boolean` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| IntegrationTypeId | `Guid` | True | — | All | None |
| Logo | `GlobalMediaResponse` | True | — | All | None |
| LogoId | `Int32` | True | — | All | None |
| Name | `String` | False | — | All | None |
| ScriptId | `Int32` | True | — | All | None |
| Tag | `IntegrationTag` | True | — | All | None |
| UpdatedDateUtc | `DateTimeOffset` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
