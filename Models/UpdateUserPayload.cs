using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record UpdateUserPayload(
    [property: JsonPropertyName("canManageCrossTenantDeployments")]
    bool CanManageCrossTenantDeployments,
    [property: JsonPropertyName("hasManagementAccess")]
    bool HasManagementAccess, [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("isAdmin")]
    bool IsAdmin,
    [property: JsonPropertyName("tenantId")]
    int TenantId);
