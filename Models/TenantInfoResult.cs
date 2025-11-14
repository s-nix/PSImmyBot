using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record TenantInfoResult(
    [property: JsonPropertyName("principalId")]
    string? PrincipalId,
    [property: JsonPropertyName("result")] AzureTenantInfoAzureErrorOneOf Result);
