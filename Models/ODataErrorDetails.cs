using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ODataErrorDetails(
    [property: JsonPropertyName("clientRequestId")]
    string? ClientRequestId, [property: JsonPropertyName("code")] string? Code, [property: JsonPropertyName("date")] DateTimeOffset? Date,
    [property: JsonPropertyName("odataType")]
    string? OdataType,
    [property: JsonPropertyName("requestId")]
    string? RequestId);
