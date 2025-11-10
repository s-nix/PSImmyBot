using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record UserRole(
    [property: JsonPropertyName("auditObjectName")]
    string? AuditObjectName,
    [property: JsonPropertyName("createdBy")]
    int? CreatedBy,
    [property: JsonPropertyName("createdDate")]
    DateTimeOffset CreatedDate, [property: JsonPropertyName("role")] Role Role, [property: JsonPropertyName("roleId")] int RoleId,
    [property: JsonPropertyName("updatedBy")]
    int? UpdatedBy,
    [property: JsonPropertyName("updatedDate")]
    DateTimeOffset UpdatedDate, [property: JsonPropertyName("user")] User User, [property: JsonPropertyName("userId")] int UserId);
