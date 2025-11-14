using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record LastException(
    [property: JsonPropertyName("data")] IDictionary<string, object>? Data,
    [property: JsonPropertyName("helpLink")]
    string? HelpLink,
    [property: JsonPropertyName("hResult")]
    int HResult,
    [property: JsonPropertyName("innerException")]
    LastException InnerException,
    [property: JsonPropertyName("message")]
    string? Message,
    [property: JsonPropertyName("source")] string? Source,
    [property: JsonPropertyName("stackTrace")]
    string? StackTrace,
    [property: JsonPropertyName("targetSite")]
    MethodBase TargetSite);
