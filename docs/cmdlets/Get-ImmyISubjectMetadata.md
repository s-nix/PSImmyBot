---
title: Get-ImmyISubjectMetadata
---

# Get-ImmyISubjectMetadata

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetISubjectMetadata` |
| Source | `Cmdlets/GetISubjectMetadata.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/roles/permissions? |
| Return Type | List<[ISubjectMetadata](../models/ISubjectMetadata.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/roles/permissions?` and deserializes to List<[ISubjectMetadata](../models/ISubjectMetadata.md)>.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- List<[ISubjectMetadata](../models/ISubjectMetadata.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
