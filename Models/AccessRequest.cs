using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record AccessRequest(
    [property: JsonPropertyName("acknowledgedByUser")]
    User AcknowledgedByUser,
    [property: JsonPropertyName("acknowledgedByUserId")]
    int? AcknowledgedByUserId,
    [property: JsonPropertyName("dateAcknowledgedUTC")]
    DateTimeOffset? DateAcknowledgedUtc,
    [property: JsonPropertyName("dateRequestedUTC")]
    DateTimeOffset DateRequestedUtc,
    [property: JsonPropertyName("expirationTime")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ExpirationTime>))]
    ExpirationTime ExpirationTime,
    [property: JsonPropertyName("granted")]
    bool Granted,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("isAdmin")]
    bool? IsAdmin,
    [property: JsonPropertyName("message")]
    string? Message,
    [property: JsonPropertyName("person")] Person Person,
    [property: JsonPropertyName("personId")]
    int PersonId);
