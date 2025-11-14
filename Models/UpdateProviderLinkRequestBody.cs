using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record UpdateProviderLinkRequestBody(
    [property: JsonPropertyName("disabled")]
    bool Disabled,
    [property: JsonPropertyName("excludedCapabilities")]
    ICollection<string>? ExcludedCapabilities, [property: JsonPropertyName("id")] int Id, [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("providerTypeFormData")]
    object ProviderTypeFormData,
    [property: JsonPropertyName("updatedBy")]
    int? UpdatedBy);
