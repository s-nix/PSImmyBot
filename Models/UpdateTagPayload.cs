using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record UpdateTagPayload(
    [property: JsonPropertyName("color")] string? Color,
    [property: JsonPropertyName("description")]
    string? Description, [property: JsonPropertyName("id")] int Id, [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("tenantTagAuthorizations")]
    ICollection<CreateTenantTagAuthorizationPayload>? TenantTagAuthorizations);
