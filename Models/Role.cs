using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record Role(
    [property: JsonPropertyName("concurrencyStamp")]
    string? ConcurrencyStamp,
    [property: JsonPropertyName("createdBy")]
    int? CreatedBy,
    [property: JsonPropertyName("createdByUser")]
    User CreatedByUser,
    [property: JsonPropertyName("createdDate")]
    DateTimeOffset CreatedDate,
    [property: JsonPropertyName("customAuditProperties")]
    ICollection<AuditPropertyChange>? CustomAuditProperties,
    [property: JsonPropertyName("description")]
    string? Description,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("normalizedName")]
    string? NormalizedName,
    [property: JsonPropertyName("roleClaims")]
    ICollection<RoleClaim>? RoleClaims,
    [property: JsonPropertyName("roleType")]
    RoleType RoleType,
    [property: JsonPropertyName("roleTypeId")]
    int RoleTypeId,
    [property: JsonPropertyName("tenantRestrictionMode")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<TenantRestrictionMode>))]
    TenantRestrictionMode TenantRestrictionMode,
    [property: JsonPropertyName("updatedBy")]
    int? UpdatedBy,
    [property: JsonPropertyName("updatedByUser")]
    User UpdatedByUser,
    [property: JsonPropertyName("updatedDate")]
    DateTimeOffset UpdatedDate,
    [property: JsonPropertyName("userRoles")]
    ICollection<UserRole>? UserRoles);
