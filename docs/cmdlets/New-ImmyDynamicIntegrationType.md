---
title: New-ImmyDynamicIntegrationType
---

# New-ImmyDynamicIntegrationType

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewDynamicIntegrationType` |
| Source | `Cmdlets/NewDynamicIntegrationType.cs` |
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
| CreatedDate | `DateTimeOffset` | True | — | All | None |
| CreationErrorMessage | `String` | False | — | All | None |
| DatabaseType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| DocsUrl | `String` | False | — | All | None |
| Enabled | `Boolean` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| IntegrationTypeId | `Guid` | True | — | All | None |
| Logo | [Media](../models/Media.md) | True | — | All | None |
| LogoId | `Int32` | True | — | All | None |
| Name | `String` | False | — | All | None |
| Script | [Script](../models/Script.md) | True | — | All | None |
| ScriptId | `Int32` | True | — | All | None |
| Secrets | `Object` | False | — | All | None |
| Tag | [IntegrationTag](../models/IntegrationTag.md) | True | — | All | None |
| UpdatedDate | `DateTimeOffset` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
