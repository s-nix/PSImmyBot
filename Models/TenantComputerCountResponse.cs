using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record TenantComputerCountResponse(
    [property: JsonPropertyName("computerCount")]
    int ComputerCount,
    [property: JsonPropertyName("tenantId")]
    int TenantId);
