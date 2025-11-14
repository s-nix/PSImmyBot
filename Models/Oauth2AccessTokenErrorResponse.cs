using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record Oauth2AccessTokenErrorResponse(
    [property: JsonPropertyName("correlationId")]
    string? CorrelationId, [property: JsonPropertyName("error")] string? Error,
    [property: JsonPropertyName("errorCodes")]
    ICollection<int>? ErrorCodes,
    [property: JsonPropertyName("errorDescription")]
    string? ErrorDescription,
    [property: JsonPropertyName("timestamp")]
    string? Timestamp,
    [property: JsonPropertyName("traceId")]
    string? TraceId);
