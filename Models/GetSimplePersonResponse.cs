using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetSimplePersonResponse(
    [property: JsonPropertyName("azurePrincipalId")]
    string? AzurePrincipalId,
    [property: JsonPropertyName("createdDateUTC")]
    DateTimeOffset CreatedDateUtc,
    [property: JsonPropertyName("emailAddress")]
    string? EmailAddress,
    [property: JsonPropertyName("expirationDateUTC")]
    DateTimeOffset? ExpirationDateUtc,
    [property: JsonPropertyName("firstName")]
    string? FirstName,
    [property: JsonPropertyName("fullName")]
    string? FullName,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("lastName")]
    string? LastName,
    [property: JsonPropertyName("onPremisesSecurityIdentifier")]
    string? OnPremisesSecurityIdentifier,
    [property: JsonPropertyName("personTagIds")]
    ICollection<int>? PersonTagIds,
    [property: JsonPropertyName("roleIds")]
    ICollection<int>? RoleIds,
    [property: JsonPropertyName("tenantId")]
    int TenantId,
    [property: JsonPropertyName("tenantName")]
    string? TenantName,
    [property: JsonPropertyName("updatedBy")]
    string? UpdatedBy,
    [property: JsonPropertyName("updatedDateUTC")]
    DateTimeOffset UpdatedDateUtc,
    [property: JsonPropertyName("userId")] int? UserId);
