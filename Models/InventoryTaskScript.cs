using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record InventoryTaskScript(
    [property: JsonPropertyName("createdDate")]
    DateTimeOffset CreatedDate,
    [property: JsonPropertyName("fromProvider")]
    bool FromProvider,
    [property: JsonPropertyName("inventoryKey")]
    string? InventoryKey,
    [property: JsonPropertyName("inventoryTask")]
    InventoryTask InventoryTask,
    [property: JsonPropertyName("inventoryTaskId")]
    int InventoryTaskId,
    [property: JsonPropertyName("saveDebugStream")]
    bool SaveDebugStream,
    [property: JsonPropertyName("saveInformationStream")]
    bool SaveInformationStream,
    [property: JsonPropertyName("saveVerboseStream")]
    bool SaveVerboseStream,
    [property: JsonPropertyName("saveWarningStream")]
    bool SaveWarningStream,
    [property: JsonPropertyName("script")] Script Script,
    [property: JsonPropertyName("scriptId")]
    int ScriptId,
    [property: JsonPropertyName("updatedDate")]
    DateTimeOffset UpdatedDate);
