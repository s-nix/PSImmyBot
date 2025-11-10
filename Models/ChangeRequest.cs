using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ChangeRequest(
    [property: JsonPropertyName("acknowledgedByUserId")]
    int? AcknowledgedByUserId,
    [property: JsonPropertyName("acknowledgedByUserName")]
    string? AcknowledgedByUserName,
    [property: JsonPropertyName("comments")]
    ICollection<ChangeRequestComment>? Comments,
    [property: JsonPropertyName("createdBy")]
    int? CreatedBy,
    [property: JsonPropertyName("createdByUser")]
    User CreatedByUser,
    [property: JsonPropertyName("createdDate")]
    DateTimeOffset CreatedDate,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("newValuesJson")]
    object NewValuesJson,
    [property: JsonPropertyName("objectType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ChangeRequestObjectType>))]
    ChangeRequestObjectType ObjectType,
    [property: JsonPropertyName("script")] Script Script,
    [property: JsonPropertyName("scriptId")]
    int? ScriptId,
    [property: JsonPropertyName("state")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ChangeRequestState>))]
    ChangeRequestState State,
    [property: JsonPropertyName("targetAssignment")]
    TargetAssignment TargetAssignment,
    [property: JsonPropertyName("targetAssignmentId")]
    int? TargetAssignmentId,
    [property: JsonPropertyName("updatedBy")]
    int? UpdatedBy,
    [property: JsonPropertyName("updatedByUser")]
    User UpdatedByUser,
    [property: JsonPropertyName("updatedDate")]
    DateTimeOffset UpdatedDate);
