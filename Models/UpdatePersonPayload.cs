using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record UpdatePersonPayload(
    [property: JsonPropertyName("azurePrincipalId")]
    string? AzurePrincipalId,
    [property: JsonPropertyName("emailAddress")]
    string? EmailAddress,
    [property: JsonPropertyName("firstName")]
    string? FirstName, [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("lastName")]
    string? LastName,
    [property: JsonPropertyName("tenantId")]
    int TenantId);
