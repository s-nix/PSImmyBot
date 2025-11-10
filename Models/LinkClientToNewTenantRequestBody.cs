using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record LinkClientToNewTenantRequestBody(
    [property: JsonPropertyName("externalClientId")]
    string? ExternalClientId,
    [property: JsonPropertyName("tenantName")]
    string? TenantName);
