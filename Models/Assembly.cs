using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record Assembly(
    [property: JsonPropertyName("definedTypes")]
    ICollection<TypeInfo>? DefinedTypes,

    [property: JsonPropertyName("exportedTypes")]
    ICollection<Type>? ExportedTypes,

    [property: JsonPropertyName("codeBase")]
    [property: Obsolete]
    string? CodeBase,

    [property: JsonPropertyName("entryPoint")]
    MethodInfo EntryPoint,

    [property: JsonPropertyName("fullName")]
    string? FullName,

    [property: JsonPropertyName("imageRuntimeVersion")]
    string? ImageRuntimeVersion,

    [property: JsonPropertyName("isDynamic")]
    bool IsDynamic,

    [property: JsonPropertyName("location")]
    string? Location,

    [property: JsonPropertyName("reflectionOnly")]
    bool ReflectionOnly,

    [property: JsonPropertyName("isCollectible")]
    bool IsCollectible,

    [property: JsonPropertyName("isFullyTrusted")]
    bool IsFullyTrusted,

    [property: JsonPropertyName("customAttributes")]
    ICollection<CustomAttributeData>? CustomAttributes,

    [property: JsonPropertyName("escapedCodeBase")]
    [property: Obsolete]
    string? EscapedCodeBase,

    [property: JsonPropertyName("manifestModule")]
    Module ManifestModule,

    [property: JsonPropertyName("modules")]
    ICollection<Module>? Modules,

    [property: JsonPropertyName("globalAssemblyCache")]
    [property: Obsolete]
    bool GlobalAssemblyCache,

    [property: JsonPropertyName("hostContext")]
    long HostContext,

    [property: JsonPropertyName("securityRuleSet")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<SecurityRuleSet>))]
    SecurityRuleSet SecurityRuleSet
);
