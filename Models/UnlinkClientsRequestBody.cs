using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record UnlinkClientsRequestBody(
    [property: JsonPropertyName("clientIds")]
    ICollection<string>? ClientIds);
