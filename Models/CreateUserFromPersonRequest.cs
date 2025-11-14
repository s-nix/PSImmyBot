using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record CreateUserFromPersonRequest(
    [property: JsonPropertyName("hasManagementAccess")]
    bool HasManagementAccess,
    [property: JsonPropertyName("personId")]
    int PersonId);
