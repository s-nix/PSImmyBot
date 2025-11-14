using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record AzureTenantCustomer(
    [property: JsonPropertyName("displayName")]
    string? DisplayName,
    [property: JsonPropertyName("domain")] string? Domain,
    [property: JsonPropertyName("gdapRelationships")]
    ICollection<AzureGdapRelationshipDetails>? GdapRelationships,
    [property: JsonPropertyName("tenantId")]
    string? TenantId);
