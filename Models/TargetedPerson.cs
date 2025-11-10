using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record TargetedPerson(
    [property: JsonPropertyName("email")] string? Email,
    [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("personId")]
    int PersonId,
    [property: JsonPropertyName("tenantId")]
    int TenantId);
