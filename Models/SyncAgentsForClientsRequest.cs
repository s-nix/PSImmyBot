using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record SyncAgentsForClientsRequest(
    [property: JsonPropertyName("clientIds")]
    ICollection<string>? ClientIds);
