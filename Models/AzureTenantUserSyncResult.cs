using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record AzureTenantUserSyncResult(
    [property: JsonPropertyName("failedReason")]
    AzureError FailedReason,
    [property: JsonPropertyName("immyTenantsSyncedUsers")]
    IDictionary<string, int>? ImmyTenantsSyncedUsers,
    [property: JsonPropertyName("numUsersSynced")]
    int NumUsersSynced,
    [property: JsonPropertyName("principalId")]
    string? PrincipalId,
    [property: JsonPropertyName("wasSuccessful")]
    bool WasSuccessful);
