using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record TestIntegrationBindConfigurationFormRequest(
    [property: JsonPropertyName("parameterValues")]
    IDictionary<string, ParameterValue>? ParameterValues);
