using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ComputerSearch(
    [property: JsonPropertyName("excludeFromMaintenance")]
    bool ExcludeFromMaintenance, [property: JsonPropertyName("id")] int Id, [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("online")] bool Online, [property: JsonPropertyName("tenant")] string? Tenant,
    [property: JsonPropertyName("tenantId")]
    int TenantId,
    [property: JsonPropertyName("updatedDate")]
    DateTimeOffset UpdatedDate);
