---
title: New-ProviderTypeDto
---

# New-ProviderTypeDto

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewProviderTypeDto` |
| Source | `Cmdlets/NewProviderTypeDto.cs` |
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
| AgentUpdateFormSchema | `AgentUpdateFormSchema` | True | — | All | None |
| CanManage | `Boolean` | True | — | All | None |
| ClientGroupTypes | `ICollection`1` | False | — | All | None |
| ConfigurationForm | `DynamicFormBindResultWithConvertedParameters` | True | — | All | None |
| DeviceGroupTypes | `ICollection`1` | False | — | All | None |
| DisplayName | `String` | False | — | All | None |
| DocsUrl | `String` | False | — | All | None |
| IsDynamic | `Boolean` | True | — | All | None |
| LogoSrc | `String` | False | — | All | None |
| ProviderCapabilities | `ICollection`1` | False | — | All | None |
| ProviderTypeId | `Guid` | True | — | All | None |
| ScreenShareLogoSrc | `String` | False | — | All | None |
| Source | `ProviderTypeSource` | True | — | All | None |
| SupportedCrossProviderClientLinkages | `ICollection`1` | False | — | All | None |
| SupportedCrossProviderInitializationLinkages | `ICollection`1` | False | — | All | None |
| SupportsDeviceUpdating | `Boolean` | True | — | All | None |
| Tag | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
