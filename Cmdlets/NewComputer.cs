using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "Computer")]
public class NewComputer : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<ComputerPerson>? AdditionalPersons { get; set; }
    [Parameter(Mandatory = false)] public ICollection<AgentIdentificationFailure>? AgentIdentificationFailures { get; set; }
    [Parameter(Mandatory = false)] public ICollection<ProviderAgent>? Agents { get; set; }
    [Parameter(Mandatory = false)] public ICollection<int>? ChassisTypes { get; set; }
    [Parameter(Mandatory = false)] public string? ComputerName { get; set; }
    [Parameter(Mandatory = true)] public required ComputerNote ComputerNote { get; set; }
    [Parameter(Mandatory = false)] public ICollection<ComputerTag>? ComputerTags { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDate { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? DeletedAt { get; set; }
    [Parameter(Mandatory = false)] public string? DeletedReason { get; set; }
    [Parameter(Mandatory = false)] public ICollection<DetectedComputerSoftware>? DetectedSoftware { get; set; }
    [Parameter(Mandatory = true)] public required bool DetectionOutdated { get; set; }
    [Parameter(Mandatory = true)] public required Guid DeviceId { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? DevLabVmClaimExpirationDateUtc { get; set; }
    [Parameter(Mandatory = false)] public string? DevLabVmName { get; set; }
    [Parameter(Mandatory = true)] public required bool DevLabVmUnclaimed { get; set; }
    [Parameter(Mandatory = false)] public string? Domain { get; set; }
    [Parameter(Mandatory = false)] public int? DomainRole { get; set; }
    [Parameter(Mandatory = true)] public required bool ExcludedFromUserAffinity { get; set; }
    [Parameter(Mandatory = true)] public required bool ExcludeFromMaintenance { get; set; }
    [Parameter(Mandatory = false)] public string? ExternalIpAddress { get; set; }
    [Parameter(Mandatory = false)] public bool? HasPendingReboot { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? InternalIpAddress { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? InventoryStartedDate { get; set; }
    [Parameter(Mandatory = true)] public required bool IsSandbox { get; set; }
    [Parameter(Mandatory = false)] public string? LastBootTimeUtc { get; set; }
    [Parameter(Mandatory = false)] public string? LastLoggedOnUser { get; set; }
    [Parameter(Mandatory = false)] public ICollection<ComputerInventoryTaskScriptResult>? LatestInventoryScriptResults { get; set; }
    [Parameter(Mandatory = true)] public required ComputerLatestProviderEvent LatestProviderEvent { get; set; }
    [Parameter(Mandatory = false)] public string? Manufacturer { get; set; }
    [Parameter(Mandatory = false)] public string? Model { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? OnboardedDateUtc { get; set; }
    [Parameter(Mandatory = true)] public required ComputerOnboardingStatus OnboardingStatus { get; set; }
    [Parameter(Mandatory = false)] public string? OperatingSystem { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? OsInstallDate { get; set; }
    [Parameter(Mandatory = true)] public required Tenant OwnerTenant { get; set; }
    [Parameter(Mandatory = false)] public ICollection<Computer>? PredecessorComputers { get; set; }
    [Parameter(Mandatory = true)] public required Person PrimaryPerson { get; set; }
    [Parameter(Mandatory = false)] public int? PrimaryPersonId { get; set; }
    [Parameter(Mandatory = false)] public ICollection<RemoteControlRecording>? RemoteControlRecordings { get; set; }
    [Parameter(Mandatory = false)] public ICollection<Schedule>? Schedules { get; set; }
    [Parameter(Mandatory = false)] public string? SerialNumber { get; set; }
    [Parameter(Mandatory = false)] public ICollection<MaintenanceSession>? Sessions { get; set; }
    [Parameter(Mandatory = true)] public required Computer SuccessorComputer { get; set; }
    [Parameter(Mandatory = false)] public int? SuccessorComputerId { get; set; }
    [Parameter(Mandatory = false)] public ICollection<Tag>? Tags { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDate { get; set; }
    [Parameter(Mandatory = false)] public ICollection<UserAffinity>? UserAffinities { get; set; }

    protected override void ProcessRecord() {
        Computer outputObject = new(AdditionalPersons, AgentIdentificationFailures, Agents, ChassisTypes, ComputerName, ComputerNote, ComputerTags, CreatedDate, DeletedAt, DeletedReason, DetectedSoftware, DetectionOutdated, DeviceId, DevLabVmClaimExpirationDateUtc, DevLabVmName, DevLabVmUnclaimed, Domain, DomainRole, ExcludedFromUserAffinity, ExcludeFromMaintenance, ExternalIpAddress, HasPendingReboot, Id, InternalIpAddress, InventoryStartedDate, IsSandbox, LastBootTimeUtc, LastLoggedOnUser, LatestInventoryScriptResults, LatestProviderEvent, Manufacturer, Model, OnboardedDateUtc, OnboardingStatus, OperatingSystem, OsInstallDate, OwnerTenant, PredecessorComputers, PrimaryPerson, PrimaryPersonId, RemoteControlRecordings, Schedules, SerialNumber, Sessions, SuccessorComputer, SuccessorComputerId, Tags, TenantId, UpdatedDate, UserAffinities);
        WriteObject(outputObject);
    }
}
