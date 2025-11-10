using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ReleaseChannelUpdatedRequestBody(
    [property: JsonPropertyName("releaseChannel")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ReleaseChannel>))]
    ReleaseChannel ReleaseChannel);
