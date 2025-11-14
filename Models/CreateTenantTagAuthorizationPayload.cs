using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record CreateTenantTagAuthorizationPayload(
    [property: JsonPropertyName("relationship")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<Relationship>))]
    Relationship Relationship,
    [property: JsonPropertyName("tenantId")]
    int TenantId);
