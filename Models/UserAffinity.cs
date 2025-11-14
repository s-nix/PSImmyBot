using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record UserAffinity(
    [property: JsonPropertyName("computer")]
    Computer Computer,
    [property: JsonPropertyName("computerId")]
    int ComputerId,
    [property: JsonPropertyName("date")] DateTimeOffset Date, [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("person")] Person Person,
    [property: JsonPropertyName("personId")]
    int PersonId);
