---
title: New-ImmyCreateLicenseRequestBody
---

# New-ImmyCreateLicenseRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewCreateLicenseRequestBody` |
| Source | `Cmdlets/NewCreateLicenseRequestBody.cs` |
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
| LicenseValue | `String` | False | — | All | None |
| Name | `String` | False | — | All | None |
| RestrictToMajorVersion | `Boolean` | True | — | All | None |
| SemanticVersion | [SemanticVersion](../models/SemanticVersion.md) | True | — | All | None |
| SoftwareIdentifier | `String` | False | — | All | None |
| SoftwareName | `String` | False | — | All | None |
| SoftwareType | [SoftwareType](../models/SoftwareType.md) | True | — | All | None |
| TenantId | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
