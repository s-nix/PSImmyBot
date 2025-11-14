using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record DeviceDetails(
    [property: JsonPropertyName("azureTenantId")]
    string? AzureTenantId,
    [property: JsonPropertyName("chassisTypes")]
    ICollection<int>? ChassisTypes,
    [property: JsonPropertyName("deviceId")]
    Guid? DeviceId,
    [property: JsonPropertyName("deviceName")]
    string? DeviceName,
    [property: JsonPropertyName("domain")] string? Domain,
    [property: JsonPropertyName("domainRole")]
    int? DomainRole,
    [property: JsonPropertyName("isSandbox")]
    bool IsSandbox,
    [property: JsonPropertyName("machineId")]
    string? MachineId,
    [property: JsonPropertyName("manufacturer")]
    string? Manufacturer,
    [property: JsonPropertyName("operatingSystemName")]
    string? OperatingSystemName,
    [property: JsonPropertyName("osInstallDateUTC")]
    DateTimeOffset? OsInstallDateUtc,
    [property: JsonPropertyName("serialNumber")]
    string? SerialNumber);
