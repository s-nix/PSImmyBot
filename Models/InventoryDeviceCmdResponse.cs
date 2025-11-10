using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record InventoryDeviceCmdResponse(
    [property: JsonPropertyName("failureReason")]
    string? FailureReason,
    [property: JsonPropertyName("output")] IDictionary<string, IDictionary<string, string>>? Output,
    [property: JsonPropertyName("success")]
    bool Success);
