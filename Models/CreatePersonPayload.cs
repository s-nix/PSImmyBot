using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record CreatePersonPayload(
    [property: JsonPropertyName("azurePrincipalId")]
    string? AzurePrincipalId,
    [property: JsonPropertyName("emailAddress")]
    string? EmailAddress,
    [property: JsonPropertyName("firstName")]
    string? FirstName,
    [property: JsonPropertyName("lastName")]
    string? LastName,
    [property: JsonPropertyName("onPremisesSecurityIdentifier")]
    string? OnPremisesSecurityIdentifier,
    [property: JsonPropertyName("tenantId")]
    int TenantId);
