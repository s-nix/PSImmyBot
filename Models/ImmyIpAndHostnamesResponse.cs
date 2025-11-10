using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ImmyIpAndHostnamesResponse(
    [property: JsonPropertyName("globalBlobStorageEndpoint")]
    string? GlobalBlobStorageEndpoint, [property: JsonPropertyName("ipInfo")] GetIpAddressesResponse IpInfo,
    [property: JsonPropertyName("localBlobStorageEndpoint")]
    string? LocalBlobStorageEndpoint);
