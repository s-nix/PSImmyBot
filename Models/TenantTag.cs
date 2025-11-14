using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record TenantTag(
    [property: JsonPropertyName("entityId")]
    int EntityId,
    [property: JsonPropertyName("tag")] Tag Tag,
    [property: JsonPropertyName("tagId")] int TagId,
    [property: JsonPropertyName("tenant")] Tenant Tenant);
