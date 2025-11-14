using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record DeleteAzureTenantAuthDetailsCmdResult(
    [property: JsonPropertyName("defaultAppRegistrationUpdated")]
    bool DefaultAppRegistrationUpdated);
