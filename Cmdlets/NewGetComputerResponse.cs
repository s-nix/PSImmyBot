using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetComputerResponse")]
public class NewGetComputerResponse : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<GetPersonResponse>? AdditionalPersons { get; set; }
    [Parameter(Mandatory = false)] public ICollection<GetProviderAgentResponse>? Agents { get; set; }
    [Parameter(Mandatory = false)] public string? ComputerName { get; set; }
    [Parameter(Mandatory = false)] public ICollection<int>? ComputerTagIds { get; set; }
    [Parameter(Mandatory = true)] public required bool DetectionOutdated { get; set; }
    [Parameter(Mandatory = true)] public required Guid DeviceId { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? DevLabVmClaimExpirationDateUtc { get; set; }
    [Parameter(Mandatory = true)] public required bool DevLabVmUnclaimed { get; set; }
    [Parameter(Mandatory = true)] public required bool EphemeralAgentConnected { get; set; }
    [Parameter(Mandatory = true)] public required bool ExcludedFromUserAffinity { get; set; }
    [Parameter(Mandatory = true)] public required bool ExcludeFromMaintenance { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public object? Inventory { get; set; }
    [Parameter(Mandatory = false)] public bool? IsDesktop { get; set; }
    [Parameter(Mandatory = true)] public required bool IsDevLab { get; set; }
    [Parameter(Mandatory = false)] public bool? IsDomainController { get; set; }
    [Parameter(Mandatory = false)] public bool? IsMissingSomeRequiredInventoryResults { get; set; }
    [Parameter(Mandatory = true)] public required bool IsOnline { get; set; }
    [Parameter(Mandatory = false)] public bool? IsPortable { get; set; }
    [Parameter(Mandatory = true)] public required bool IsSandbox { get; set; }
    [Parameter(Mandatory = false)] public bool? IsServer { get; set; }
    [Parameter(Mandatory = true)] public required bool Licensed { get; set; }
    [Parameter(Mandatory = false)] public string? Notes { get; set; }
    [Parameter(Mandatory = true)] public required ComputerOnboardingStatus OnboardingStatus { get; set; }
    [Parameter(Mandatory = true)] public required GetPersonResponse PrimaryPerson { get; set; }
    [Parameter(Mandatory = false)] public int? PrimaryPersonId { get; set; }
    [Parameter(Mandatory = false)] public ICollection<GetMaintenanceSessionResponse>? Sessions { get; set; }
    [Parameter(Mandatory = true)] public required GetTenantResponse Tenant { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }
    [Parameter(Mandatory = false)] public string? TenantName { get; set; }

    protected override void ProcessRecord() {
        GetComputerResponse outputObject = new(AdditionalPersons, Agents, ComputerName, ComputerTagIds, DetectionOutdated, DeviceId, DevLabVmClaimExpirationDateUtc, DevLabVmUnclaimed, EphemeralAgentConnected, ExcludedFromUserAffinity, ExcludeFromMaintenance, Id, Inventory, IsDesktop, IsDevLab, IsDomainController, IsMissingSomeRequiredInventoryResults, IsOnline, IsPortable, IsSandbox, IsServer, Licensed, Notes, OnboardingStatus, PrimaryPerson, PrimaryPersonId, Sessions, Tenant, TenantId, TenantName);
        WriteObject(outputObject);
    }
}
