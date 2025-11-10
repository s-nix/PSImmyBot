using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

public record Assembly {
    [JsonConstructor]
    [Obsolete]
    public Assembly(string? @codeBase, ICollection<CustomAttributeData>? @customAttributes, ICollection<TypeInfo>? @definedTypes, MethodInfo @entryPoint, string? @escapedCodeBase, ICollection<Type>? @exportedTypes, string? @fullName, bool @globalAssemblyCache, long @hostContext, string? @imageRuntimeVersion, bool @isCollectible, bool @isDynamic, bool @isFullyTrusted, string? @location, Module @manifestModule, ICollection<Module>? @modules, bool @reflectionOnly, SecurityRuleSet @securityRuleSet) {
        DefinedTypes = @definedTypes;
        ExportedTypes = @exportedTypes;
        CodeBase = @codeBase;
        EntryPoint = @entryPoint;
        FullName = @fullName;
        ImageRuntimeVersion = @imageRuntimeVersion;
        IsDynamic = @isDynamic;
        Location = @location;
        ReflectionOnly = @reflectionOnly;
        IsCollectible = @isCollectible;
        IsFullyTrusted = @isFullyTrusted;
        CustomAttributes = @customAttributes;
        EscapedCodeBase = @escapedCodeBase;
        ManifestModule = @manifestModule;
        Modules = @modules;
        GlobalAssemblyCache = @globalAssemblyCache;
        HostContext = @hostContext;
        SecurityRuleSet = @securityRuleSet;
    }

    [JsonPropertyName("definedTypes")]
    public ICollection<TypeInfo>? DefinedTypes { get; init; }

    [JsonPropertyName("exportedTypes")]
    public ICollection<Type>? ExportedTypes { get; init; }

    [JsonPropertyName("codeBase")]
    [Obsolete]
    public string? CodeBase { get; init; }

    [JsonPropertyName("entryPoint")]
    public MethodInfo EntryPoint { get; init; }

    [JsonPropertyName("fullName")]
    public string? FullName { get; init; }

    [JsonPropertyName("imageRuntimeVersion")]
    public string? ImageRuntimeVersion { get; init; }

    [JsonPropertyName("isDynamic")]
    public bool IsDynamic { get; init; }

    [JsonPropertyName("location")]
    public string? Location { get; init; }

    [JsonPropertyName("reflectionOnly")]
    public bool ReflectionOnly { get; init; }

    [JsonPropertyName("isCollectible")]
    public bool IsCollectible { get; init; }

    [JsonPropertyName("isFullyTrusted")]
    public bool IsFullyTrusted { get; init; }

    [JsonPropertyName("customAttributes")]
    public ICollection<CustomAttributeData>? CustomAttributes { get; init; }

    [JsonPropertyName("escapedCodeBase")]
    [Obsolete]
    public string? EscapedCodeBase { get; init; }

    [JsonPropertyName("manifestModule")]
    public Module ManifestModule { get; init; }

    [JsonPropertyName("modules")]
    public ICollection<Module>? Modules { get; init; }

    [JsonPropertyName("globalAssemblyCache")]
    [Obsolete]
    public bool GlobalAssemblyCache { get; init; }

    [JsonPropertyName("hostContext")]
    public long HostContext { get; init; }

    [JsonPropertyName("securityRuleSet")]
    [JsonConverter(typeof(JsonStringEnumConverter<SecurityRuleSet>))]
    public SecurityRuleSet SecurityRuleSet { get; init; }
}
