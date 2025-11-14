using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record LinkClientToNewTenantResponseBody(
    [property: JsonPropertyName("tenantId")]
    int? TenantId,
    [property: JsonPropertyName("tenantName")]
    string? TenantName);
