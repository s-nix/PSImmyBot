using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record InventoryTaskScriptResource(
    [property: JsonPropertyName("fromProvider")]
    bool FromProvider,
    [property: JsonPropertyName("inventoryKey")]
    string? InventoryKey,
    [property: JsonPropertyName("scriptId")]
    int ScriptId);
