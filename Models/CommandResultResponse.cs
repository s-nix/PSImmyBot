using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record CommandResultResponse(
    [property: JsonPropertyName("commandType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<CommandTypes>))]
    CommandTypes CommandType,
    [property: JsonPropertyName("name")] string? Name);
