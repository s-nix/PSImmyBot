using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record MigrateToSupersedingAssignmentRequest(
    [property: JsonPropertyName("newTaskId")]
    int NewTaskId,
    [property: JsonPropertyName("newTaskType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    DatabaseType NewTaskType,
    [property: JsonPropertyName("oldAssignmentId")]
    int OldAssignmentId);
