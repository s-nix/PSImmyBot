using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record EventInfo(
    [property: JsonPropertyName("addMethod")]
    MethodInfo AddMethod,
    [property: JsonPropertyName("attributes")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<EventAttributes>))]
    EventAttributes Attributes,
    [property: JsonPropertyName("customAttributes")]
    ICollection<CustomAttributeData>? CustomAttributes,
    [property: JsonPropertyName("declaringType")]
    Type DeclaringType,
    [property: JsonPropertyName("eventHandlerType")]
    Type EventHandlerType,
    [property: JsonPropertyName("isCollectible")]
    bool IsCollectible,
    [property: JsonPropertyName("isMulticast")]
    bool IsMulticast,
    [property: JsonPropertyName("isSpecialName")]
    bool IsSpecialName,
    [property: JsonPropertyName("memberType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<MemberTypes>))]
    MemberTypes MemberType,
    [property: JsonPropertyName("metadataToken")]
    int MetadataToken,
    [property: JsonPropertyName("module")] Module Module,
    [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("raiseMethod")]
    MethodInfo RaiseMethod,
    [property: JsonPropertyName("reflectedType")]
    Type ReflectedType,
    [property: JsonPropertyName("removeMethod")]
    MethodInfo RemoveMethod);
