using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record InventoryTaskScriptPayload(
    [property: JsonPropertyName("inventoryKey")]
    string? InventoryKey,
    [property: JsonPropertyName("inventoryTaskId")]
    int InventoryTaskId,
    [property: JsonPropertyName("scriptId")]
    int ScriptId);
