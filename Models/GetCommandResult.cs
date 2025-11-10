using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetCommandResult(
    [property: JsonPropertyName("commandType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<CommandTypes>))]
    CommandTypes CommandType,
    [property: JsonPropertyName("name")] string? Name);
