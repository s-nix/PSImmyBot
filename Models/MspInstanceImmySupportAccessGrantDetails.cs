using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record MspInstanceImmySupportAccessGrantDetails(
    [property: JsonPropertyName("disabledByEmail")]
    string? DisabledByEmail,
    [property: JsonPropertyName("disabledByName")]
    string? DisabledByName,
    [property: JsonPropertyName("disabledDateUtc")]
    DateTimeOffset? DisabledDateUtc,
    [property: JsonPropertyName("enabledByEmail")]
    string? EnabledByEmail,
    [property: JsonPropertyName("enabledByName")]
    string? EnabledByName,
    [property: JsonPropertyName("enabledDateUtc")]
    [property: System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    DateTimeOffset EnabledDateUtc,
    [property: JsonPropertyName("isEnabled")]
    bool IsEnabled);
