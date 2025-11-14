using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record UpdateAzureTenantAuthDetailsCmdResult(
    [property: JsonPropertyName("authDetails")]
    AzureTenantAuthDetails AuthDetails,
    [property: JsonPropertyName("defaultAppRegistrationUpdated")]
    bool DefaultAppRegistrationUpdated);
