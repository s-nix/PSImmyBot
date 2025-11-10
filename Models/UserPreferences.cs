using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record UserPreferences([property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("maskPiiData")]
    bool MaskPiiData, [property: JsonPropertyName("userId")] int UserId);
