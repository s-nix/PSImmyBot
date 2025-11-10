using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetUserResponse(
    [property: JsonPropertyName("azurePrincipalId")]
    string? AzurePrincipalId,
    [property: JsonPropertyName("canManageCrossTenantDeployments")]
    bool CanManageCrossTenantDeployments,
    [property: JsonPropertyName("companyName")]
    string? CompanyName,
    [property: JsonPropertyName("email")] string? Email,
    [property: JsonPropertyName("expirationDateUTC")]
    DateTimeOffset? ExpirationDateUtc,
    [property: JsonPropertyName("hasManagementAccess")]
    bool HasManagementAccess,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("isAdmin")]
    bool IsAdmin,
    [property: JsonPropertyName("isExpired")]
    bool IsExpired,
    [property: JsonPropertyName("isMsp")] bool IsMsp,
    [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("personId")]
    int? PersonId,
    [property: JsonPropertyName("roles")] ICollection<string>? Roles,
    [property: JsonPropertyName("tenantId")]
    int TenantId,
    [property: JsonPropertyName("type")] string? Type);
