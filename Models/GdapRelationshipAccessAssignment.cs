using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GdapRelationshipAccessAssignment(
    [property: JsonPropertyName("accessContainerId")]
    string? AccessContainerId,
    [property: JsonPropertyName("accessContainerType")]
    string? AccessContainerType);
