using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ProviderLink")]
public class NewProviderLink : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<ProviderAgent>? Agents { get; set; }
    [Parameter(Mandatory = false)] public int? CreatedBy { get; set; }
    [Parameter(Mandatory = true)] public required User CreatedByUser { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDate { get; set; }
    [Parameter(Mandatory = true)] public required bool Disabled { get; set; }
    [Parameter(Mandatory = true)] public required bool DisabledOrUnhealthy { get; set; }
    [Parameter(Mandatory = false)] public ICollection<string>? ExcludedCapabilities { get; set; }
    [Parameter(Mandatory = true)] public required HealthStatus HealthStatus { get; set; }
    [Parameter(Mandatory = false)] public string? HealthStatusMessage { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public ICollection<ProviderLinkCrossReference>? LinkedFromProviders { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = true)] public required Tenant OwnerTenant { get; set; }
    [Parameter(Mandatory = false)] public ICollection<ProviderClient>? ProviderClients { get; set; }
    [Parameter(Mandatory = true)] public required ProviderLinkInternalData ProviderInternalData { get; set; }
    [Parameter(Mandatory = false)] public ICollection<ProviderLinkCrossReference>? ProvidersLinkedFromThisProvider { get; set; }
    [Parameter(Mandatory = true)] public required object ProviderTypeFormData { get; set; }
    [Parameter(Mandatory = true)] public required Guid ProviderTypeId { get; set; }
    [Parameter(Mandatory = true)] public required int RunScriptPriority { get; set; }
    [Parameter(Mandatory = false)] public ICollection<Schedule>? Schedules { get; set; }
    [Parameter(Mandatory = false)] public ICollection<TargetAssignment>? TargetAssignments { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }
    [Parameter(Mandatory = true)] public required int UnhealthyCount { get; set; }
    [Parameter(Mandatory = false)] public int? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required User UpdatedByUser { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDate { get; set; }

    protected override void ProcessRecord() {
        ProviderLink outputObject = new(Agents, CreatedBy, CreatedByUser, CreatedDate, Disabled, DisabledOrUnhealthy, ExcludedCapabilities, HealthStatus, HealthStatusMessage, Id, LinkedFromProviders, Name, OwnerTenant, ProviderClients, ProviderInternalData, ProvidersLinkedFromThisProvider, ProviderTypeFormData, ProviderTypeId, RunScriptPriority, Schedules, TargetAssignments, TenantId, UnhealthyCount, UpdatedBy, UpdatedByUser, UpdatedDate);
        WriteObject(outputObject);
    }
}
