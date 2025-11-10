using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetRoleResponse(
    [property: JsonPropertyName("createdDate")]
    DateTimeOffset? CreatedDate,
    [property: JsonPropertyName("description")]
    string? Description,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("roleClaims")]
    ICollection<GetRoleClaimResponse>? RoleClaims,
    [property: JsonPropertyName("roleTypeId")]
    int RoleTypeId,
    [property: JsonPropertyName("roleTypeName")]
    string? RoleTypeName,
    [property: JsonPropertyName("updatedBy")]
    string? UpdatedBy,
    [property: JsonPropertyName("updatedDate")]
    DateTimeOffset? UpdatedDate,
    [property: JsonPropertyName("userCount")]
    int UserCount);
