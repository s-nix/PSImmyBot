---
title: New-ImmyReleaseDetails
---

# New-ImmyReleaseDetails

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewReleaseDetails` |
| Source | `Cmdlets/NewReleaseDetails.cs` |
| HTTP Method | Custom |
| Endpoint | Not applicable |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Refer to the source implementation for detailed flow; this cmdlet performs custom orchestration beyond simple API proxying.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ImmyAgentInstallerFileVersion | `String` | False | — | All | None |
| ImmyAgentInstallerVersion | [SemanticVersion](../models/SemanticVersion.md) | True | — | All | None |
| PublishedDate | `Nullable`1` | False | — | All | None |
| ReleaseChannel | [ReleaseChannel](../models/ReleaseChannel.md) | True | — | All | None |
| ReleaseNotes | `String` | False | — | All | None |
| Tag | [SemanticVersion](../models/SemanticVersion.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
