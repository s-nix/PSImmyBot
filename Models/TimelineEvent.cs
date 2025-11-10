using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record TimelineEvent(
    [property: JsonPropertyName("data")] string? Data,
    [property: JsonPropertyName("dateUTC")]
    DateTimeOffset DateUtc,
    [property: JsonPropertyName("eventType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<TimelineEventType>))]
    TimelineEventType EventType, [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("identifier")]
    string? Identifier,
    [property: JsonPropertyName("message")]
    string? Message,
    [property: JsonPropertyName("objectId")]
    string? ObjectId,
    [property: JsonPropertyName("objectType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<TimelineObjectType>))]
    TimelineObjectType ObjectType);
