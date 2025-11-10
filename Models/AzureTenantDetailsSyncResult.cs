using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record AzureTenantDetailsSyncResult(
    [property: JsonPropertyName("failedReason")]
    AzureError FailedReason,
    [property: JsonPropertyName("principalId")]
    string? PrincipalId,
    [property: JsonPropertyName("tenantInformationSynced")]
    AzureTenantInfo TenantInformationSynced,
    [property: JsonPropertyName("wasSuccessful")]
    bool WasSuccessful);
