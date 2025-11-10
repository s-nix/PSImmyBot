using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record BulkUpdateRoleRequest(
    [property: JsonPropertyName("personIds")]
    ICollection<int>? PersonIds,
    [property: JsonPropertyName("roleIds")]
    ICollection<int>? RoleIds);
