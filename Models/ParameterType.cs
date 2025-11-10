using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ParameterType(
    [property: JsonPropertyName("elementType")]
    object? ElementType,
    [property: JsonPropertyName("enumValues")]
    object? EnumValues,
    [property: JsonPropertyName("fullName")]
    string? FullName,
    [property: JsonPropertyName("hasFlagAttribute")]
    bool HasFlagAttribute,
    [property: JsonPropertyName("implementsDictionary")]
    bool ImplementsDictionary,
    [property: JsonPropertyName("isArray")]
    bool IsArray,
    [property: JsonPropertyName("isEnum")] bool IsEnum,
    [property: JsonPropertyName("name")] string? Name);
