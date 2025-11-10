namespace PSImmyBot.Models;

using System;
using System.Text.Json.Serialization;

public record AzureTokenEndpointMetadataResponse {
    [JsonPropertyName("token_endpoint")]
    public Uri TokenEndpoint { get; set; } = default!;
}
