using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record UpdateReleaseChannelRequest(
    [property: JsonPropertyName("releaseChannel")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ReleaseChannel>))]
    ReleaseChannel ReleaseChannel);
