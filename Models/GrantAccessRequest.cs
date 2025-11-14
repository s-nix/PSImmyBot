using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GrantAccessRequest(
    [property: JsonPropertyName("expirationTime")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ExpirationTime>))]
    ExpirationTime ExpirationTime,
    [property: JsonPropertyName("hasManagementAccess")]
    bool HasManagementAccess,
    [property: JsonPropertyName("isAdmin")]
    bool IsAdmin);
