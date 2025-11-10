using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ISubjectMetadata(
    [property: JsonPropertyName("description")]
    string? Description,
    [property: JsonPropertyName("displayName")]
    string? DisplayName, [property: JsonPropertyName("id")] string? Id,
    [property: JsonPropertyName("isMspOnly")]
    bool IsMspOnly,
    [property: JsonPropertyName("isResourceBased")]
    bool IsResourceBased,
    [property: JsonPropertyName("isSystemManaged")]
    bool IsSystemManaged, [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("permissions")]
    ICollection<IPermissionMetadata>? Permissions,
    [property: JsonPropertyName("sortOrder")]
    int SortOrder);
