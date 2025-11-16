---
title: Send-ImmySkipOnboardingRequest
---

# Send-ImmySkipOnboardingRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendSkipOnboardingRequest` |
| Source | `Cmdlets/SendSkipOnboardingRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/computers/skip-onboarding? |
| Return Type | List<[SkipOnboardingRequest](../models/SkipOnboardingRequest.md)>, List<[SkipOnboardingResponse](../models/SkipOnboardingResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/computers/skip-onboarding?` and deserializes to List<[SkipOnboardingRequest](../models/SkipOnboardingRequest.md)>, List<[SkipOnboardingResponse](../models/SkipOnboardingResponse.md)>.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `List`1` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[SkipOnboardingRequest](../models/SkipOnboardingRequest.md)>, List<[SkipOnboardingResponse](../models/SkipOnboardingResponse.md)> records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
