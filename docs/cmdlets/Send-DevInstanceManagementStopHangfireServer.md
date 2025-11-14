---
title: Send-DevInstanceManagementStopHangfireServer
---

# Send-DevInstanceManagementStopHangfireServer

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendDevInstanceManagementStopHangfireServer` |
| Source | `Cmdlets/SendDevInstanceManagementStopHangfireServer.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/dev-instance-management/stop-hangfire-server? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/dev-instance-management/stop-hangfire-server?`.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
