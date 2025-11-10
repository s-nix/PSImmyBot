using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record TenantConsentRequestBody(
    [property: JsonPropertyName("appType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<AppRegistrationType>))]
    AppRegistrationType AppType,
    [property: JsonPropertyName("tenantPrincipalId")]
    string? TenantPrincipalId);
