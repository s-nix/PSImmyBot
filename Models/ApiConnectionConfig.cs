namespace PSImmyBot.Models;
public record ApiConnectionConfig {
    public string AzureTenantDomain { get; init; } = string.Empty;
    public string AzureClientId { get; init; } = string.Empty;
    public string AzureClientSecret { get; init; } = string.Empty;
    public string ImmySubdomain { get; init; } = string.Empty;
}
