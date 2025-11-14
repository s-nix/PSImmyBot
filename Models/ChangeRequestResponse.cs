using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ChangeRequestResponse(
    [property: JsonPropertyName("acknowledgedByUserId")]
    int? AcknowledgedByUserId,
    [property: JsonPropertyName("acknowledgedByUserName")]
    string? AcknowledgedByUserName,
    [property: JsonPropertyName("comments")]
    ICollection<ChangeRequestCommentResponse>? Comments,
    [property: JsonPropertyName("createdByUserName")]
    string? CreatedByUserName,
    [property: JsonPropertyName("createdDateUtc")]
    DateTimeOffset CreatedDateUtc,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("newValuesJson")]
    object NewValuesJson,
    [property: JsonPropertyName("objectType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ChangeRequestObjectType>))]
    ChangeRequestObjectType ObjectType,
    [property: JsonPropertyName("scriptId")]
    int? ScriptId,
    [property: JsonPropertyName("state")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ChangeRequestState>))]
    ChangeRequestState State,
    [property: JsonPropertyName("targetAssignmentId")]
    int? TargetAssignmentId,
    [property: JsonPropertyName("updatedDateUtc")]
    DateTimeOffset UpdatedDateUtc);
