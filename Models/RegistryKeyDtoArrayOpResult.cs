using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record RegistryKeyDtoArrayOpResult(
    [property: JsonPropertyName("dateCreatedUtc")]
    DateTimeOffset DateCreatedUtc,
    [property: JsonPropertyName("isSuccess")]
    bool IsSuccess,
    [property: JsonPropertyName("reason")] string? Reason,
    [property: JsonPropertyName("value")] ICollection<RegistryKeyDto>? Value);
