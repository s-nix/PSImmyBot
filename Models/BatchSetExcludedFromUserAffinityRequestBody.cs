using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record BatchSetExcludedFromUserAffinityRequestBody(
    [property: JsonPropertyName("computerIds")]
    ICollection<int>? ComputerIds,
    [property: JsonPropertyName("isExcluded")]
    bool IsExcluded);
