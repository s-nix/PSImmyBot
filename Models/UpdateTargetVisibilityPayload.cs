using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record UpdateTargetVisibilityPayload(
    [property: JsonPropertyName("targetVisibility")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<TargetVisibility>))]
    TargetVisibility TargetVisibility,
    [property: JsonPropertyName("updateStatus")]
    bool? UpdateStatus);
