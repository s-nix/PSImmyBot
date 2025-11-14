using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetIpAddressesResponse(
    [property: JsonPropertyName("ipAddresses")]
    ICollection<string>? IpAddresses,
    [property: JsonPropertyName("message")]
    string? Message,
    [property: JsonPropertyName("success")]
    bool Success);
