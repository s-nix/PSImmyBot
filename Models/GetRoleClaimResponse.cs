using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetRoleClaimResponse(
    [property: JsonPropertyName("claimType")]
    string? ClaimType,
    [property: JsonPropertyName("claimValue")]
    string? ClaimValue);
