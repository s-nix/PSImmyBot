using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record SetExcludedFromUserAffinityRequestBody(
    [property: JsonPropertyName("isExcluded")]
    bool IsExcluded);
