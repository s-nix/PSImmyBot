using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record AzureTenantInfo(
    [property: JsonPropertyName("defaultDomainName")]
    string? DefaultDomainName,
    [property: JsonPropertyName("domainNames")]
    ICollection<string>? DomainNames,
    [property: JsonPropertyName("tenantName")]
    string? TenantName);
