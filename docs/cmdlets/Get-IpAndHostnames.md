---
title: Get-IpAndHostnames
---

# Get-IpAndHostnames

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetIpAndHostnames` |
| Source | `Cmdlets/GetIpAndHostnames.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/auth/get-ip-addresses? |
| Return Type | [ImmyIpAndHostnamesResponse](../models/ImmyIpAndHostnamesResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/auth/get-ip-addresses?` and deserializes to [ImmyIpAndHostnamesResponse](../models/ImmyIpAndHostnamesResponse.md).

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- [ImmyIpAndHostnamesResponse](../models/ImmyIpAndHostnamesResponse.md) records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
