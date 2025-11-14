---
title: Send-SoftwareGlobalUpload
---

# Send-SoftwareGlobalUpload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendSoftwareGlobalUpload` |
| Source | `Cmdlets/SendSoftwareGlobalUpload.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/software/global/upload? |
| Return Type | [SoftwareFileUploadData](../models/SoftwareFileUploadData.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/software/global/upload?` and deserializes to [SoftwareFileUploadData](../models/SoftwareFileUploadData.md).

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- [SoftwareFileUploadData](../models/SoftwareFileUploadData.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
