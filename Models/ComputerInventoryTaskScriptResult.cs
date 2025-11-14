using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ComputerInventoryTaskScriptResult(
    [property: JsonPropertyName("computer")]
    Computer Computer,
    [property: JsonPropertyName("computerId")]
    int ComputerId,
    [property: JsonPropertyName("inventoryKey")]
    string? InventoryKey,
    [property: JsonPropertyName("latestErrorResult")]
    object? LatestErrorResult,
    [property: JsonPropertyName("latestResultIsError")]
    bool LatestResultIsError,
    [property: JsonPropertyName("latestSuccessResult")]
    object? LatestSuccessResult,
    [property: JsonPropertyName("timestamp")]
    DateTimeOffset Timestamp);
