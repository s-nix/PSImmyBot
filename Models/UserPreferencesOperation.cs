using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record UserPreferencesOperation(
    [property: JsonPropertyName("from")] string? From,
    [property: JsonPropertyName("op")] string? Op,
    [property: JsonPropertyName("operationType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<OperationType>))]
    OperationType OperationType,
    [property: JsonPropertyName("path")] string? Path,
    [property: JsonPropertyName("value")] object? Value);
