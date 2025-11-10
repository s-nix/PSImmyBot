using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record DxComputerInventoryScriptResult(
    [property: JsonPropertyName("computerId")]
    int ComputerId,
    [property: JsonPropertyName("computerName")]
    string? ComputerName,
    [property: JsonPropertyName("inventoryKey")]
    string? InventoryKey,
    [property: JsonPropertyName("latestSuccessResult")]
    object? LatestSuccessResult,
    [property: JsonPropertyName("latestSuccessResultJson")]
    string? LatestSuccessResultJson,
    [property: JsonPropertyName("success")]
    bool Success,
    [property: JsonPropertyName("tenantId")]
    int TenantId,
    [property: JsonPropertyName("tenantName")]
    string? TenantName,
    [property: JsonPropertyName("timestampUtc")]
    [property: System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    DateTimeOffset TimestampUtc);
