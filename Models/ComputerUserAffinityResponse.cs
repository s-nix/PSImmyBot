using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ComputerUserAffinityResponse(
    [property: JsonPropertyName("computerId")]
    int ComputerId,
    [property: JsonPropertyName("computerName")]
    string? ComputerName,
    [property: JsonPropertyName("date")] DateTimeOffset Date, [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("personId")]
    int PersonId,
    [property: JsonPropertyName("personName")]
    string? PersonName,
    [property: JsonPropertyName("tenantId")]
    int TenantId,
    [property: JsonPropertyName("tenantName")]
    string? TenantName);
