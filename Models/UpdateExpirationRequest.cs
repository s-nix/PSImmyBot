using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record UpdateExpirationRequest(
    [property: JsonPropertyName("expiresIn")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ExpirationTime>))]
    ExpirationTime ExpiresIn,
    [property: JsonPropertyName("personIds")]
    ICollection<int>? PersonIds);
