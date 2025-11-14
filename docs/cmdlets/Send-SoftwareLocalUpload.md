---
title: Send-SoftwareLocalUpload
---

# Send-SoftwareLocalUpload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendSoftwareLocalUpload` |
| Source | `Cmdlets/SendSoftwareLocalUpload.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/software/local/upload? |
| Return Type | `SoftwareFileUploadData` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/software/local/upload?` and deserializes to `SoftwareFileUploadData`.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- `SoftwareFileUploadData` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
