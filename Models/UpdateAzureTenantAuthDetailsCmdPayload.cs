using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record UpdateAzureTenantAuthDetailsCmdPayload(
    [property: JsonPropertyName("authDetails")]
    AzureTenantAuthDetails AuthDetails);
