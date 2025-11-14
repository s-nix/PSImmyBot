using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record Int32OpResult(
    [property: JsonPropertyName("dateCreatedUtc")]
    DateTimeOffset DateCreatedUtc,
    [property: JsonPropertyName("isSuccess")]
    bool IsSuccess,
    [property: JsonPropertyName("reason")] string? Reason,
    [property: JsonPropertyName("value")] int Value);
