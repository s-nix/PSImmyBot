using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetProviderLinkResponse")]
public class NewGetProviderLinkResponse : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<GetComputerResponse>? Computers { get; set; }
    [Parameter(Mandatory = false)] public int? CreatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDateUtc { get; set; }
    [Parameter(Mandatory = true)] public required bool Disabled { get; set; }
    [Parameter(Mandatory = false)] public string? ErrorMessage { get; set; }
    [Parameter(Mandatory = false)] public ICollection<string>? ExcludedCapabilities { get; set; }
    [Parameter(Mandatory = false)] public string? GetFormSchemaFailedMessage { get; set; }
    [Parameter(Mandatory = false)] public string? GetLatestAgentVersionFailedMessage { get; set; }
    [Parameter(Mandatory = false)] public string? GetProviderFailedMessage { get; set; }
    [Parameter(Mandatory = true)] public required HealthStatus HealthStatus { get; set; }
    [Parameter(Mandatory = false)] public string? HealthStatusMessage { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? IncludeClientsFailedMessage { get; set; }
    [Parameter(Mandatory = false)] public ICollection<string>? InputsWithStoredPasswords { get; set; }
    [Parameter(Mandatory = false)] public string? LatestAgentVersion { get; set; }
    [Parameter(Mandatory = false)] public ICollection<LinkedExternalLink>? LinkedFromProviders { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = true)] public required int OwnerTenantId { get; set; }
    [Parameter(Mandatory = false)] public ICollection<string>? ProviderCapabilities { get; set; }
    [Parameter(Mandatory = false)] public ICollection<GetProviderClientResponse>? ProviderClients { get; set; }
    [Parameter(Mandatory = false)] public string? ProviderPluginBaseUrl { get; set; }
    [Parameter(Mandatory = false)] public ICollection<LinkedExternalLink>? ProvidersLinkedFromThisProvider { get; set; }
    [Parameter(Mandatory = true)] public required object ProviderTypeFormData { get; set; }
    [Parameter(Mandatory = true)] public required Guid ProviderTypeId { get; set; }
    [Parameter(Mandatory = true)] public required int RunScriptPriority { get; set; }
    [Parameter(Mandatory = false)] public ICollection<GetScheduleResponse>? Schedules { get; set; }
    [Parameter(Mandatory = false)] public ICollection<SupportedCrossProviderLinkage>? SupportedCrossProviderClientLinkages { get; set; }
    [Parameter(Mandatory = false)] public ICollection<SupportedCrossProviderLinkage>? SupportedCrossProviderInitializationLinkages { get; set; }
    [Parameter(Mandatory = true)] public required bool SupportsDeviceUpdating { get; set; }
    [Parameter(Mandatory = false)] public int? UpdatedBy { get; set; }
    [Parameter(Mandatory = false)] public string? UpdatedByName { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDateUtc { get; set; }

    protected override void ProcessRecord() {
        GetProviderLinkResponse outputObject = new(Computers, CreatedBy, CreatedDateUtc, Disabled, ErrorMessage, ExcludedCapabilities, GetFormSchemaFailedMessage, GetLatestAgentVersionFailedMessage, GetProviderFailedMessage, HealthStatus, HealthStatusMessage, Id, IncludeClientsFailedMessage, InputsWithStoredPasswords, LatestAgentVersion, LinkedFromProviders, Name, OwnerTenantId, ProviderCapabilities, ProviderClients, ProviderPluginBaseUrl, ProvidersLinkedFromThisProvider, ProviderTypeFormData, ProviderTypeId, RunScriptPriority, Schedules, SupportedCrossProviderClientLinkages, SupportedCrossProviderInitializationLinkages, SupportsDeviceUpdating, UpdatedBy, UpdatedByName, UpdatedDateUtc);
        WriteObject(outputObject);
    }
}
