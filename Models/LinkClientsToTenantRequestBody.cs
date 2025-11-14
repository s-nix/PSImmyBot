using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record LinkClientsToTenantRequestBody(
    [property: JsonPropertyName("clientIds")]
    ICollection<string>? ClientIds,
    [property: JsonPropertyName("tenantId")]
    int TenantId);
