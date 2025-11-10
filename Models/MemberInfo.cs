using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record MemberInfo(
    [property: JsonPropertyName("customAttributes")]
    ICollection<CustomAttributeData>? CustomAttributes,
    [property: JsonPropertyName("declaringType")]
    Type DeclaringType,
    [property: JsonPropertyName("isCollectible")]
    bool IsCollectible,
    [property: JsonPropertyName("memberType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<MemberTypes>))]
    MemberTypes MemberType,
    [property: JsonPropertyName("metadataToken")]
    int MetadataToken,
    [property: JsonPropertyName("module")] Module Module,
    [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("reflectedType")]
    Type ReflectedType);
