using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record CloneRoleRequest(
    [property: JsonPropertyName("newName")]
    string? NewName);
