---
title: Get-ImmyOnboardingComputer
---

# Get-ImmyOnboardingComputer

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetOnboardingComputer` |
| Source | `Cmdlets/GetOnboardingComputer.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/computers/onboarding? |
| Return Type | List<[GetOnboardingComputerResponse](../models/GetOnboardingComputerResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/computers/onboarding?` and deserializes to List<[GetOnboardingComputerResponse](../models/GetOnboardingComputerResponse.md)>.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- List<[GetOnboardingComputerResponse](../models/GetOnboardingComputerResponse.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
