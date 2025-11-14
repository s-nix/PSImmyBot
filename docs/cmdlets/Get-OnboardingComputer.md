---
title: Get-OnboardingComputer
---

# Get-OnboardingComputer

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetOnboardingComputer` |
| Source | `Cmdlets/GetOnboardingComputer.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/computers/onboarding? |
| Return Type | `List<GetOnboardingComputerResponse>` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/computers/onboarding?` and deserializes to `List<GetOnboardingComputerResponse>`.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- `List<GetOnboardingComputerResponse>` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
