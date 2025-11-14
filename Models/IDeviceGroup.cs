using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record IDeviceGroup(
    [property: JsonPropertyName("deviceGroupDisplayName")]
    string? DeviceGroupDisplayName,
    [property: JsonPropertyName("deviceGroupId")]
    string? DeviceGroupId);
