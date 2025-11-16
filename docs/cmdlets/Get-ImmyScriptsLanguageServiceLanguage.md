---
title: Get-ImmyScriptsLanguageServiceLanguage
---

# Get-ImmyScriptsLanguageServiceLanguage

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetScriptsLanguageServiceLanguage` |
| Source | `Cmdlets/GetScriptsLanguageServiceLanguage.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/scripts/language-service/{TerminalId}/language? |
| Return Type | `byte[]` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/scripts/language-service/{TerminalId}/language?` and deserializes to `byte[]`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| TerminalId | `String` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `byte[]` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
