using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record UpdateTenantPayload([property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("isMsp")] bool? IsMsp, [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("parentTenantId")]
    int? ParentTenantId, [property: JsonPropertyName("slug")] string? Slug);
