---
title: Get-EphemeralSessionDevelopmentBinary
---

# Get-EphemeralSessionDevelopmentBinary

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetEphemeralSessionDevelopmentBinary` |
| Source | `Cmdlets/GetEphemeralSessionDevelopmentBinary.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/ephemeral-session/development/latest-ephemeral-binary? |
| Return Type | `byte[]` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/ephemeral-session/development/latest-ephemeral-binary?` and deserializes to `byte[]`.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- `byte[]` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
