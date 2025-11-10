using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record MaintenanceTaskParameter(
    [property: JsonPropertyName("dataType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<MaintenanceTaskParameterType>))]
    MaintenanceTaskParameterType DataType,
    [property: JsonPropertyName("defaultMedia")]
    Media DefaultMedia,
    [property: JsonPropertyName("defaultMediaDatabaseType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    DatabaseType DefaultMediaDatabaseType,
    [property: JsonPropertyName("defaultMediaId")]
    int? DefaultMediaId,
    [property: JsonPropertyName("defaultValue")]
    string? DefaultValue,
    [property: JsonPropertyName("hidden")] bool Hidden,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("maintenanceTask")]
    MaintenanceTask MaintenanceTask,
    [property: JsonPropertyName("maintenanceTaskId")]
    int MaintenanceTaskId,
    [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("notes")] string? Notes,
    [property: JsonPropertyName("order")] int Order,
    [property: JsonPropertyName("required")]
    bool Required,
    [property: JsonPropertyName("selectableValues")]
    ICollection<string>? SelectableValues);
