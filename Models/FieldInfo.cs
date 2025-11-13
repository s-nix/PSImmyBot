using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record FieldInfo(
    [property: JsonPropertyName("name")]
    string? Name,

    [property: JsonPropertyName("declaringType")]
    Type DeclaringType,

    [property: JsonPropertyName("reflectedType")]
    Type ReflectedType,

    [property: JsonPropertyName("module")]
    Module Module,

    [property: JsonPropertyName("customAttributes")]
    ICollection<CustomAttributeData>? CustomAttributes,

    [property: JsonPropertyName("isCollectible")]
    bool IsCollectible,

    [property: JsonPropertyName("metadataToken")]
    int MetadataToken,

    [property: JsonPropertyName("memberType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<MemberTypes>))]
    MemberTypes MemberType,

    [property: JsonPropertyName("attributes")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<FieldAttributes>))]
    FieldAttributes Attributes,

    [property: JsonPropertyName("fieldType")]
    Type FieldType,

    [property: JsonPropertyName("isInitOnly")]
    bool IsInitOnly,

    [property: JsonPropertyName("isLiteral")]
    bool IsLiteral,

    [property: JsonPropertyName("isNotSerialized")]
    [property: Obsolete]
    bool IsNotSerialized,

    [property: JsonPropertyName("isPinvokeImpl")]
    bool IsPinvokeImpl,

    [property: JsonPropertyName("isSpecialName")]
    bool IsSpecialName,

    [property: JsonPropertyName("isStatic")]
    bool IsStatic,

    [property: JsonPropertyName("isAssembly")]
    bool IsAssembly,

    [property: JsonPropertyName("isFamily")]
    bool IsFamily,

    [property: JsonPropertyName("isFamilyAndAssembly")]
    bool IsFamilyAndAssembly,

    [property: JsonPropertyName("isFamilyOrAssembly")]
    bool IsFamilyOrAssembly,

    [property: JsonPropertyName("isPrivate")]
    bool IsPrivate,

    [property: JsonPropertyName("isPublic")]
    bool IsPublic,

    [property: JsonPropertyName("isSecurityCritical")]
    bool IsSecurityCritical,

    [property: JsonPropertyName("isSecuritySafeCritical")]
    bool IsSecuritySafeCritical,

    [property: JsonPropertyName("isSecurityTransparent")]
    bool IsSecurityTransparent,

    [property: JsonPropertyName("fieldHandle")]
    RuntimeFieldHandle FieldHandle
);
