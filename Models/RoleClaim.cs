using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record RoleClaim(
    [property: JsonPropertyName("auditObjectName")]
    string? AuditObjectName,
    [property: JsonPropertyName("claimType")]
    string? ClaimType,
    [property: JsonPropertyName("claimValue")]
    string? ClaimValue,
    [property: JsonPropertyName("createdBy")]
    int? CreatedBy,
    [property: JsonPropertyName("createdDate")]
    DateTimeOffset CreatedDate, [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("role")] Role Role, [property: JsonPropertyName("roleId")] int RoleId,
    [property: JsonPropertyName("updatedBy")]
    int? UpdatedBy,
    [property: JsonPropertyName("updatedDate")]
    DateTimeOffset UpdatedDate);
