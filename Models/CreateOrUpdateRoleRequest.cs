using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record CreateOrUpdateRoleRequest(
    [property: JsonPropertyName("description")]
    string? Description,
    [property: JsonPropertyName("grantedPermissionIds")]
    ICollection<string>? GrantedPermissionIds, [property: JsonPropertyName("name")] string? Name);
