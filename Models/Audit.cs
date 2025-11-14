using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record Audit(
    [property: JsonPropertyName("affectedProperties")]
    string? AffectedProperties,
    [property: JsonPropertyName("dateTimeUtc")]
    [property: System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    DateTimeOffset DateTimeUtc,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("message")]
    string? Message,
    [property: JsonPropertyName("newValues")]
    string? NewValues,
    [property: JsonPropertyName("objectName")]
    string? ObjectName,
    [property: JsonPropertyName("objectType")]
    string? ObjectType,
    [property: JsonPropertyName("oldValues")]
    string? OldValues,
    [property: JsonPropertyName("primaryKey")]
    string? PrimaryKey,
    [property: JsonPropertyName("type")] string? Type,
    [property: JsonPropertyName("userAzureId")]
    string? UserAzureId,
    [property: JsonPropertyName("userDisplayName")]
    string? UserDisplayName,
    [property: JsonPropertyName("userId")] int? UserId);
