using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record AccessRequestResponse(
    [property: JsonPropertyName("azurePrincipalId")]
    string? AzurePrincipalId,
    [property: JsonPropertyName("dateRequestedUTC")]
    DateTimeOffset DateRequestedUtc,
    [property: JsonPropertyName("emailAddress")]
    string? EmailAddress,
    [property: JsonPropertyName("fullName")]
    string? FullName,
    [property: JsonPropertyName("id")]
    int Id,
    [property: JsonPropertyName("personId")]
    int PersonId);
