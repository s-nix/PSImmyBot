using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetRdpInfoResponse(
    [property: JsonPropertyName("rdpFileContent")]
    string? RdpFileContent,
    [property: JsonPropertyName("rdpFileName")]
    string? RdpFileName,
    [property: JsonPropertyName("rdpPassword")]
    string? RdpPassword);
