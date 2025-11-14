using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record DeleteAzureTenantAuthDetailsCmdPayload(
    [property: JsonPropertyName("azureTenantPrincipalId")]
    string? AzureTenantPrincipalId);
