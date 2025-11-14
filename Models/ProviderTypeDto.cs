using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ProviderTypeDto(
    [property: JsonPropertyName("agentUpdateFormSchema")]
    AgentUpdateFormSchema AgentUpdateFormSchema,
    [property: JsonPropertyName("canManage")]
    bool CanManage,
    [property: JsonPropertyName("clientGroupTypes")]
    ICollection<ClientGroupTypeDto>? ClientGroupTypes,
    [property: JsonPropertyName("configurationForm")]
    DynamicFormBindResultWithConvertedParameters ConfigurationForm,
    [property: JsonPropertyName("deviceGroupTypes")]
    ICollection<DeviceGroupTypeDto>? DeviceGroupTypes,
    [property: JsonPropertyName("displayName")]
    string? DisplayName,
    [property: JsonPropertyName("docsUrl")]
    string? DocsUrl,
    [property: JsonPropertyName("isDynamic")]
    bool IsDynamic,
    [property: JsonPropertyName("logoSrc")]
    string? LogoSrc,
    [property: JsonPropertyName("providerCapabilities")]
    ICollection<string>? ProviderCapabilities,
    [property: JsonPropertyName("providerTypeId")]
    Guid ProviderTypeId,
    [property: JsonPropertyName("screenShareLogoSrc")]
    string? ScreenShareLogoSrc,
    [property: JsonPropertyName("source")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ProviderTypeSource>))]
    ProviderTypeSource Source,
    [property: JsonPropertyName("supportedCrossProviderClientLinkages")]
    ICollection<SupportedCrossProviderLinkage>? SupportedCrossProviderClientLinkages,
    [property: JsonPropertyName("supportedCrossProviderInitializationLinkages")]
    ICollection<SupportedCrossProviderLinkage>? SupportedCrossProviderInitializationLinkages,
    [property: JsonPropertyName("supportsDeviceUpdating")]
    bool SupportsDeviceUpdating,
    [property: JsonPropertyName("tag")] string? Tag);
