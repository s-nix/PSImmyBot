using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record TestIntegrationMethodRequest(
    [property: JsonPropertyName("providerTypeFormData")]
    object ProviderTypeFormData);
