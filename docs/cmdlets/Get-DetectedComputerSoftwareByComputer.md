---
title: Get-DetectedComputerSoftwareByComputer
---

# Get-DetectedComputerSoftwareByComputer

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetDetectedComputerSoftwareByComputer` |
| Source | `Cmdlets/GetDetectedComputerSoftwareByComputer.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/computers/{ComputerId}/detected-computer-software? |
| Return Type | List<[DetectedComputerSoftwareResponse](../models/DetectedComputerSoftwareResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/computers/{ComputerId}/detected-computer-software?` and deserializes to List<[DetectedComputerSoftwareResponse](../models/DetectedComputerSoftwareResponse.md)>.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ComputerId | `Nullable`1` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[DetectedComputerSoftwareResponse](../models/DetectedComputerSoftwareResponse.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
