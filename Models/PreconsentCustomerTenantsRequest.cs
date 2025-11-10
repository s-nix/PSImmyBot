using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record PreconsentCustomerTenantsRequest(
    [property: JsonPropertyName("customerPrincipalIds")]
    ICollection<string>? CustomerPrincipalIds,
    [property: JsonPropertyName("partnerPrincipalId")]
    string? PartnerPrincipalId);
