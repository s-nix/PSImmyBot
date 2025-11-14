using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record SubmitFeedbackRequestBody(
    [property: JsonPropertyName("details")]
    string? Details,
    [property: JsonPropertyName("rating")] string? Rating);
