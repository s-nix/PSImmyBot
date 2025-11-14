using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record AzureErrorLogItem(
    [property: JsonPropertyName("azureError")]
    AzureError AzureError,
    [property: JsonPropertyName("createdDateUtc")]
    DateTimeOffset CreatedDateUtc, [property: JsonPropertyName("id")] Guid Id,
    [property: JsonPropertyName("oauth2AccessTokenId")]
    int? Oauth2AccessTokenId,
    [property: JsonPropertyName("sourceMessage")]
    string? SourceMessage,
    [property: JsonPropertyName("tenantPrincipalId")]
    string? TenantPrincipalId);
