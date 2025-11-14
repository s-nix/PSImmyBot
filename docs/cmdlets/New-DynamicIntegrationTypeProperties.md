---
title: New-DynamicIntegrationTypeProperties
---

# New-DynamicIntegrationTypeProperties

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewDynamicIntegrationTypeProperties` |
| Source | `Cmdlets/NewDynamicIntegrationTypeProperties.cs` |
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
| DatabaseType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| DocsUrl | `String` | False | — | All | None |
| LogoMediaId | `Int32` | True | — | All | None |
| Name | `String` | False | — | All | None |
| ProviderTypeId | `Guid` | True | — | All | None |
| Secrets | `IDictionary`2` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
