---
title: Get-TechnicianPageInfoFromPsaTicket
---

# Get-TechnicianPageInfoFromPsaTicket

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetTechnicianPageInfoFromPsaTicket` |
| Source | `Cmdlets/GetTechnicianPageInfoFromPsaTicket.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/provider-links/{Id}/tickets/{TicketId}? |
| Return Type | `TechnicianPageInfoFromPsaTicket` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/provider-links/{Id}/tickets/{TicketId}?` and deserializes to `TechnicianPageInfoFromPsaTicket`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |
| TicketId | `String` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `TechnicianPageInfoFromPsaTicket` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
