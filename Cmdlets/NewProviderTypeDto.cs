using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ProviderTypeDto")]
public class NewProviderTypeDto : Cmdlet {
    [Parameter(Mandatory = true)] public required AgentUpdateFormSchema AgentUpdateFormSchema { get; set; }
    [Parameter(Mandatory = true)] public required bool CanManage { get; set; }
    [Parameter(Mandatory = false)] public ICollection<ClientGroupTypeDto>? ClientGroupTypes { get; set; }
    [Parameter(Mandatory = true)] public required DynamicFormBindResultWithConvertedParameters ConfigurationForm { get; set; }
    [Parameter(Mandatory = false)] public ICollection<DeviceGroupTypeDto>? DeviceGroupTypes { get; set; }
    [Parameter(Mandatory = false)] public string? DisplayName { get; set; }
    [Parameter(Mandatory = false)] public string? DocsUrl { get; set; }
    [Parameter(Mandatory = true)] public required bool IsDynamic { get; set; }
    [Parameter(Mandatory = false)] public string? LogoSrc { get; set; }
    [Parameter(Mandatory = false)] public ICollection<string>? ProviderCapabilities { get; set; }
    [Parameter(Mandatory = true)] public required Guid ProviderTypeId { get; set; }
    [Parameter(Mandatory = false)] public string? ScreenShareLogoSrc { get; set; }
    [Parameter(Mandatory = true)] public required ProviderTypeSource Source { get; set; }
    [Parameter(Mandatory = false)] public ICollection<SupportedCrossProviderLinkage>? SupportedCrossProviderClientLinkages { get; set; }
    [Parameter(Mandatory = false)] public ICollection<SupportedCrossProviderLinkage>? SupportedCrossProviderInitializationLinkages { get; set; }
    [Parameter(Mandatory = true)] public required bool SupportsDeviceUpdating { get; set; }
    [Parameter(Mandatory = false)] public string? Tag { get; set; }

    protected override void ProcessRecord() {
        ProviderTypeDto outputObject = new(AgentUpdateFormSchema, CanManage, ClientGroupTypes, ConfigurationForm, DeviceGroupTypes, DisplayName, DocsUrl, IsDynamic, LogoSrc, ProviderCapabilities, ProviderTypeId, ScreenShareLogoSrc, Source, SupportedCrossProviderClientLinkages, SupportedCrossProviderInitializationLinkages, SupportsDeviceUpdating, Tag);
        WriteObject(outputObject);
    }
}
