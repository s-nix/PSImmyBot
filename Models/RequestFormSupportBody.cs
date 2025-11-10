using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record RequestFormSupportBody(
    [property: JsonPropertyName("allowTechnicianAccess")]
    bool? AllowTechnicianAccess,
    [property: JsonPropertyName("blobNames")]
    ICollection<string>? BlobNames,
    [property: JsonPropertyName("notes")] string? Notes,
    [property: JsonPropertyName("requesterEmail")]
    string? RequesterEmail,
    [property: JsonPropertyName("subject")]
    string? Subject);
