using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record IntegrationBindParametersRequest(
    [property: JsonPropertyName("parameterValues")]
    IDictionary<string, ParameterValue>? ParameterValues,
    [property: JsonPropertyName("providerLinkId")]
    int? ProviderLinkId);
