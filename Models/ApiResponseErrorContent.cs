using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ApiResponseErrorContent(
    [property: JsonPropertyName("content")]
    string? Content,
    [property: JsonPropertyName("httpMethod")]
    string? HttpMethod,
    [property: JsonPropertyName("statusCode")]
    int StatusCode,
    [property: JsonPropertyName("uri")] string? Uri);
