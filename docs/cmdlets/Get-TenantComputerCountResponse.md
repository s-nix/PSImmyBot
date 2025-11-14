---
title: Get-TenantComputerCountResponse
---

# Get-TenantComputerCountResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetTenantComputerCountResponse` |
| Source | `Cmdlets/GetTenantComputerCountResponse.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/tenants/computer-counts? |
| Return Type | List<[TenantComputerCountResponse](../models/TenantComputerCountResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/tenants/computer-counts?` and deserializes to List<[TenantComputerCountResponse](../models/TenantComputerCountResponse.md)>.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- List<[TenantComputerCountResponse](../models/TenantComputerCountResponse.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
