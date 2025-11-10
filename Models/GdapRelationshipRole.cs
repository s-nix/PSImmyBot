using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GdapRelationshipRole(
    [property: JsonPropertyName("roleDefinitionId")]
    string? RoleDefinitionId,
    [property: JsonPropertyName("roleDefinitionName")]
    string? RoleDefinitionName);
