using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record CustomAttributeTypedArgument(
    [property: JsonPropertyName("argumentType")]
    Type ArgumentType,
    [property: JsonPropertyName("value")] object? Value);
