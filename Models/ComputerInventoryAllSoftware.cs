using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ComputerInventoryAllSoftware(
    [property: JsonPropertyName("computer")]
    string? Computer,
    [property: JsonPropertyName("computerId")]
    int ComputerId,
    [property: JsonPropertyName("softwareName")]
    string? SoftwareName,
    [property: JsonPropertyName("softwareVersion")]
    string? SoftwareVersion,
    [property: JsonPropertyName("tenant")] string? Tenant,
    [property: JsonPropertyName("tenantId")]
    int TenantId);
