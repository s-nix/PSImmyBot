using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record BulkLinkClientsToTenantsRequestBody(
    [property: JsonPropertyName("clientIds")]
    ICollection<string>? ClientIds);
