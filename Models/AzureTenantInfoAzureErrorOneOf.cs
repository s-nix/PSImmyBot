using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record AzureTenantInfoAzureErrorOneOf([property: JsonPropertyName("asT0")] AzureTenantInfo AsT0, [property: JsonPropertyName("asT1")] AzureError AsT1, [property: JsonPropertyName("index")] int Index, [property: JsonPropertyName("isT0")] bool IsT0, [property: JsonPropertyName("isT1")] bool IsT1, [property: JsonPropertyName("value")] object? Value);
