using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record IPermissionMetadata(
    [property: JsonPropertyName("allowClaim")]
    string? AllowClaim,
    [property: JsonPropertyName("category")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<PermissionCategory>))]
    PermissionCategory Category,
    [property: JsonPropertyName("claim")] string? Claim,
    [property: JsonPropertyName("denyClaim")]
    string? DenyClaim,
    [property: JsonPropertyName("dependencies")]
    ICollection<IPermissionMetadata>? Dependencies,
    [property: JsonPropertyName("description")]
    string? Description,
    [property: JsonPropertyName("displayName")]
    string? DisplayName,
    [property: JsonPropertyName("hasGreatPower")]
    bool HasGreatPower,
    [property: JsonPropertyName("id")] string? Id,
    [property: JsonPropertyName("isMspOnly")]
    bool IsMspOnly,
    [property: JsonPropertyName("isSystemManaged")]
    bool IsSystemManaged,
    [property: JsonPropertyName("permissionName")]
    string? PermissionName,
    [property: JsonPropertyName("resourceClaimType")]
    string? ResourceClaimType,
    [property: JsonPropertyName("sortOrder")]
    int SortOrder,
    [property: JsonPropertyName("subject")]
    ISubjectMetadata Subject,
    [property: JsonPropertyName("subjectClaimType")]
    string? SubjectClaimType,
    [property: JsonPropertyName("tenantClaimType")]
    string? TenantClaimType);
