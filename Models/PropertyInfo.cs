using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record PropertyInfo(
    [property: JsonPropertyName("attributes")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<PropertyAttributes>))]
    PropertyAttributes Attributes,
    [property: JsonPropertyName("canRead")]
    bool CanRead,
    [property: JsonPropertyName("canWrite")]
    bool CanWrite,
    [property: JsonPropertyName("customAttributes")]
    ICollection<CustomAttributeData>? CustomAttributes,
    [property: JsonPropertyName("declaringType")]
    Type DeclaringType,
    [property: JsonPropertyName("getMethod")]
    MethodInfo GetMethod,
    [property: JsonPropertyName("isCollectible")]
    bool IsCollectible,
    [property: JsonPropertyName("isSpecialName")]
    bool IsSpecialName,
    [property: JsonPropertyName("memberType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<MemberTypes>))]
    MemberTypes MemberType,
    [property: JsonPropertyName("metadataToken")]
    int MetadataToken,
    [property: JsonPropertyName("module")] Module Module,
    [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("propertyType")]
    Type PropertyType,
    [property: JsonPropertyName("reflectedType")]
    Type ReflectedType,
    [property: JsonPropertyName("setMethod")]
    MethodInfo SetMethod);
