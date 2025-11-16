---
title: Get-ImmyAppRegistrationOptions
---

# Get-ImmyAppRegistrationOptions

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetAppRegistrationOptions` |
| Source | `Cmdlets/GetAppRegistrationOptions.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/azure/app-registration-options? |
| Return Type | List<[AppRegistrationOption](../models/AppRegistrationOption.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/azure/app-registration-options?` and deserializes to List<[AppRegistrationOption](../models/AppRegistrationOption.md)>.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- List<[AppRegistrationOption](../models/AppRegistrationOption.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
