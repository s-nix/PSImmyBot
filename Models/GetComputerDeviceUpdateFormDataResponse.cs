using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetComputerDeviceUpdateFormDataResponse(
    [property: JsonPropertyName("devices")]
    ICollection<DeviceUpdateFormDataResponse>? Devices);
