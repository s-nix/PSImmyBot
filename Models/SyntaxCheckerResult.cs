using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record SyntaxCheckerResult(
    [property: JsonPropertyName("errors")] ICollection<string>? Errors,
    [property: JsonPropertyName("isSyntaxValid")]
    bool IsSyntaxValid);
