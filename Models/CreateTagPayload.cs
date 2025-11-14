using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record CreateTagPayload(
    [property: JsonPropertyName("color")] string? Color,
    [property: JsonPropertyName("description")]
    string? Description, [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("tenantTagAuthorizations")]
    ICollection<CreateTenantTagAuthorizationPayload>? TenantTagAuthorizations);
