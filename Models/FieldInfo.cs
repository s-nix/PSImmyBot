using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

public record FieldInfo {
    [JsonConstructor]
    [Obsolete]
    public FieldInfo(FieldAttributes @attributes, ICollection<CustomAttributeData>? @customAttributes, Type @declaringType, RuntimeFieldHandle @fieldHandle, Type @fieldType, bool @isAssembly, bool @isCollectible, bool @isFamily, bool @isFamilyAndAssembly, bool @isFamilyOrAssembly, bool @isInitOnly, bool @isLiteral, bool @isNotSerialized, bool @isPinvokeImpl, bool @isPrivate, bool @isPublic, bool @isSecurityCritical, bool @isSecuritySafeCritical, bool @isSecurityTransparent, bool @isSpecialName, bool @isStatic, MemberTypes @memberType, int @metadataToken, Module @module, string? @name, Type @reflectedType) {
        Name = @name;
        DeclaringType = @declaringType;
        ReflectedType = @reflectedType;
        Module = @module;
        CustomAttributes = @customAttributes;
        IsCollectible = @isCollectible;
        MetadataToken = @metadataToken;
        MemberType = @memberType;
        Attributes = @attributes;
        FieldType = @fieldType;
        IsInitOnly = @isInitOnly;
        IsLiteral = @isLiteral;
        IsNotSerialized = @isNotSerialized;
        IsPinvokeImpl = @isPinvokeImpl;
        IsSpecialName = @isSpecialName;
        IsStatic = @isStatic;
        IsAssembly = @isAssembly;
        IsFamily = @isFamily;
        IsFamilyAndAssembly = @isFamilyAndAssembly;
        IsFamilyOrAssembly = @isFamilyOrAssembly;
        IsPrivate = @isPrivate;
        IsPublic = @isPublic;
        IsSecurityCritical = @isSecurityCritical;
        IsSecuritySafeCritical = @isSecuritySafeCritical;
        IsSecurityTransparent = @isSecurityTransparent;
        FieldHandle = @fieldHandle;
    }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("declaringType")]
    public Type DeclaringType { get; init; }

    [JsonPropertyName("reflectedType")]
    public Type ReflectedType { get; init; }

    [JsonPropertyName("module")]
    public Module Module { get; init; }

    [JsonPropertyName("customAttributes")]
    public ICollection<CustomAttributeData>? CustomAttributes { get; init; }

    [JsonPropertyName("isCollectible")]
    public bool IsCollectible { get; init; }

    [JsonPropertyName("metadataToken")]
    public int MetadataToken { get; init; }

    [JsonPropertyName("memberType")]
    [JsonConverter(typeof(JsonStringEnumConverter<MemberTypes>))]
    public MemberTypes MemberType { get; init; }

    [JsonPropertyName("attributes")]
    [JsonConverter(typeof(JsonStringEnumConverter<FieldAttributes>))]
    public FieldAttributes Attributes { get; init; }

    [JsonPropertyName("fieldType")]
    public Type FieldType { get; init; }

    [JsonPropertyName("isInitOnly")]
    public bool IsInitOnly { get; init; }

    [JsonPropertyName("isLiteral")]
    public bool IsLiteral { get; init; }

    [JsonPropertyName("isNotSerialized")]
    [Obsolete]
    public bool IsNotSerialized { get; init; }

    [JsonPropertyName("isPinvokeImpl")]
    public bool IsPinvokeImpl { get; init; }

    [JsonPropertyName("isSpecialName")]
    public bool IsSpecialName { get; init; }

    [JsonPropertyName("isStatic")]
    public bool IsStatic { get; init; }

    [JsonPropertyName("isAssembly")]
    public bool IsAssembly { get; init; }

    [JsonPropertyName("isFamily")]
    public bool IsFamily { get; init; }

    [JsonPropertyName("isFamilyAndAssembly")]
    public bool IsFamilyAndAssembly { get; init; }

    [JsonPropertyName("isFamilyOrAssembly")]
    public bool IsFamilyOrAssembly { get; init; }

    [JsonPropertyName("isPrivate")]
    public bool IsPrivate { get; init; }

    [JsonPropertyName("isPublic")]
    public bool IsPublic { get; init; }

    [JsonPropertyName("isSecurityCritical")]
    public bool IsSecurityCritical { get; init; }

    [JsonPropertyName("isSecuritySafeCritical")]
    public bool IsSecuritySafeCritical { get; init; }

    [JsonPropertyName("isSecurityTransparent")]
    public bool IsSecurityTransparent { get; init; }

    [JsonPropertyName("fieldHandle")]
    public RuntimeFieldHandle FieldHandle { get; init; }
}
