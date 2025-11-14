using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record DynamicFormBindResultWithConvertedParameters(
    [property: JsonPropertyName("bindErrors")]
    IDictionary<string, string>? BindErrors,
    [property: JsonPropertyName("convertedParameters")]
    IDictionary<string, object?>? ConvertedParameters,
    [property: JsonPropertyName("hasErrors")]
    bool HasErrors,
    [property: JsonPropertyName("parameterSetName")]
    string? ParameterSetName,
    [property: JsonPropertyName("showCommandInfo")]
    ShowCommandInfo ShowCommandInfo);
