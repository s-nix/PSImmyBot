using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record TenantTagAuthorization(
    [property: JsonPropertyName("relationship")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<Relationship>))]
    Relationship Relationship,
    [property: JsonPropertyName("tag")] Tag Tag, [property: JsonPropertyName("tagId")] int TagId,
    [property: JsonPropertyName("tenant")] Tenant Tenant,
    [property: JsonPropertyName("tenantId")]
    int TenantId);
