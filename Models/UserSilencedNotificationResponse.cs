using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record UserSilencedNotificationResponse(
    [property: JsonPropertyName("dateSilencedUtc")]
    DateTimeOffset DateSilencedUtc, [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("notificationObjectId")]
    string? NotificationObjectId,
    [property: JsonPropertyName("notificationType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<NotificationType>))]
    NotificationType NotificationType, [property: JsonPropertyName("userId")] int UserId);
