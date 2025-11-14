using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record RemoteControlRecording(
    [property: JsonPropertyName("blobName")]
    string? BlobName,
    [property: JsonPropertyName("computer")]
    Computer Computer,
    [property: JsonPropertyName("computerId")]
    int ComputerId,
    [property: JsonPropertyName("createdBy")]
    int? CreatedBy,
    [property: JsonPropertyName("createdDate")]
    DateTimeOffset CreatedDate,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("mimeContentType")]
    string? MimeContentType,
    [property: JsonPropertyName("tenant")] Tenant Tenant,
    [property: JsonPropertyName("tenantId")]
    int TenantId,
    [property: JsonPropertyName("updatedBy")]
    int? UpdatedBy,
    [property: JsonPropertyName("updatedDate")]
    DateTimeOffset UpdatedDate,
    [property: JsonPropertyName("user")] User User,
    [property: JsonPropertyName("userId")] int UserId);
