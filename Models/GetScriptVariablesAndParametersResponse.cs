using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetScriptVariablesAndParametersResponse(
    [property: JsonPropertyName("parameters")]
    IDictionary<string, object?>? Parameters,
    [property: JsonPropertyName("variables")]
    IDictionary<string, object?>? Variables);
