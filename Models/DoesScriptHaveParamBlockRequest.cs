using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record DoesScriptHaveParamBlockRequest([property: JsonPropertyName("script")] string? Script);
