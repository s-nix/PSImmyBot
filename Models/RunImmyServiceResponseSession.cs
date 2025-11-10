using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record RunImmyServiceResponseSession(
    [property: JsonPropertyName("computerId")]
    int? ComputerId,
    [property: JsonPropertyName("personId")]
    int? PersonId,
    [property: JsonPropertyName("sessionId")]
    int SessionId,
    [property: JsonPropertyName("tenantId")]
    int? TenantId);
