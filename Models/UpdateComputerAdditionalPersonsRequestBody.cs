using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record UpdateComputerAdditionalPersonsRequestBody(
    [property: JsonPropertyName("additionalPersonIds")]
    ICollection<int>? AdditionalPersonIds);
