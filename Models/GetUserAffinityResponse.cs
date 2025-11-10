using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetUserAffinityResponse(
    [property: JsonPropertyName("computerId")]
    int ComputerId,
    [property: JsonPropertyName("date")] DateTimeOffset Date, [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("person")] GetPersonResponse Person,
    [property: JsonPropertyName("personId")]
    int PersonId);
