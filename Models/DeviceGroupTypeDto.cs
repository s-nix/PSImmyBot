using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record DeviceGroupTypeDto(
    [property: JsonPropertyName("description")]
    string? Description,
    [property: JsonPropertyName("deviceGroupTypeId")]
    Guid DeviceGroupTypeId,
    [property: JsonPropertyName("displayName")]
    string? DisplayName,
    [property: JsonPropertyName("providerTypeId")]
    Guid ProviderTypeId,
    [property: JsonPropertyName("targetScope")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<TargetScope>))]
    TargetScope TargetScope);
