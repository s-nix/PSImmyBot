using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record Notification(
    [property: JsonPropertyName("acknowledgedByUserAzureId")]
    string? AcknowledgedByUserAzureId,
    [property: JsonPropertyName("acknowledgedByUserDisplayName")]
    string? AcknowledgedByUserDisplayName,
    [property: JsonPropertyName("acknowledgedByUserId")]
    int? AcknowledgedByUserId,
    [property: JsonPropertyName("acknowledgement")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<NotificationAcknowledgement>))]
    NotificationAcknowledgement Acknowledgement,
    [property: JsonPropertyName("adminOnly")]
    bool AdminOnly,
    [property: JsonPropertyName("createdDate")]
    DateTimeOffset CreatedDate,
    [property: JsonPropertyName("description")]
    string? Description,
    [property: JsonPropertyName("id")] Guid Id,
    [property: JsonPropertyName("inputData")]
    object? InputData,
    [property: JsonPropertyName("objectId")]
    string? ObjectId,
    [property: JsonPropertyName("onlyForUserId")]
    int? OnlyForUserId,
    [property: JsonPropertyName("outputData")]
    object? OutputData,
    [property: JsonPropertyName("resolved")]
    bool Resolved,
    [property: JsonPropertyName("severity")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<NotificationSeverity>))]
    NotificationSeverity Severity,
    [property: JsonPropertyName("tenantId")]
    int? TenantId,
    [property: JsonPropertyName("title")] string? Title,
    [property: JsonPropertyName("triggeredByUserId")]
    int? TriggeredByUserId,
    [property: JsonPropertyName("type")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<NotificationType>))]
    NotificationType Type,
    [property: JsonPropertyName("updatedDate")]
    DateTimeOffset UpdatedDate);
