using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetFunctionSyntaxRequest(
    [property: JsonPropertyName("functionName")]
    string? FunctionName);
