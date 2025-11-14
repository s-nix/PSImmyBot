using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ComputerPageResponse([property: JsonPropertyName("count")] int Count,
    [property: JsonPropertyName("results")]
    ICollection<ComputerListViewModel>? Results);
