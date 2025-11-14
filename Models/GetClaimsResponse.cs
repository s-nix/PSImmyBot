using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetClaimsResponse([property: JsonPropertyName("claims")] ICollection<ClaimResponse>? Claims);
