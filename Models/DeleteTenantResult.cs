using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record DeleteTenantResult(
    [property: JsonPropertyName("failedReason")]
    string? FailedReason,
    [property: JsonPropertyName("success")]
    bool Success,
    [property: JsonPropertyName("tenantId")]
    int TenantId);
