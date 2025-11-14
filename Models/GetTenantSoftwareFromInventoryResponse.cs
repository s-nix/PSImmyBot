using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetTenantSoftwareFromInventoryResponse(
    [property: JsonPropertyName("azureUserObjectId")]
    string? AzureUserObjectId,
    [property: JsonPropertyName("computerId")]
    int ComputerId,
    [property: JsonPropertyName("computerName")]
    string? ComputerName,
    [property: JsonPropertyName("dateDetectedUtc")]
    DateTimeOffset DateDetectedUtc,
    [property: JsonPropertyName("displayName")]
    string? DisplayName,
    [property: JsonPropertyName("globalSoftwareId")]
    int GlobalSoftwareId,
    [property: JsonPropertyName("globalSoftwareName")]
    string? GlobalSoftwareName,
    [property: JsonPropertyName("globalSoftwareVersion")]
    string? GlobalSoftwareVersion,
    [property: JsonPropertyName("personId")]
    int? PersonId,
    [property: JsonPropertyName("personName")]
    string? PersonName,
    [property: JsonPropertyName("tenantId")]
    int TenantId);
