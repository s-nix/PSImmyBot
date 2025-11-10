using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record AzureGdapRelationshipDetails(
    [property: JsonPropertyName("accessAssignments")]
    ICollection<GdapRelationshipAccessAssignment>? AccessAssignments,
    [property: JsonPropertyName("autoExtendDuration")]
    string? AutoExtendDuration,
    [property: JsonPropertyName("createdDateTimeUtc")]
    DateTimeOffset? CreatedDateTimeUtc,
    [property: JsonPropertyName("displayName")]
    string? DisplayName,
    [property: JsonPropertyName("durationNumDays")]
    int? DurationNumDays,
    [property: JsonPropertyName("endDateTimeUtc")]
    DateTimeOffset? EndDateTimeUtc,
    [property: JsonPropertyName("id")] string? Id,
    [property: JsonPropertyName("roles")] ICollection<GdapRelationshipRole>? Roles,
    [property: JsonPropertyName("status")] string? Status);
