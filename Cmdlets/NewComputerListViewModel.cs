using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ComputerListViewModel")]
public class NewComputerListViewModel : Cmdlet {
    [Parameter(Mandatory = false)] public int? ActiveSessionId { get; set; }
    [Parameter(Mandatory = true)] public required SessionStatus ActiveSessionStatus { get; set; }
    [Parameter(Mandatory = false)] public ICollection<int>? ChassisTypes { get; set; }
    [Parameter(Mandatory = false)] public string? ComputerName { get; set; }
    [Parameter(Mandatory = false)] public ICollection<int>? ComputerTagIds { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDate { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? DeletedAt { get; set; }
    [Parameter(Mandatory = true)] public required Guid DeviceId { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? DevLabVmClaimExpirationDateUtc { get; set; }
    [Parameter(Mandatory = false)] public string? DevLabVmName { get; set; }
    [Parameter(Mandatory = true)] public required bool DevLabVmUnclaimed { get; set; }
    [Parameter(Mandatory = false)] public string? Domain { get; set; }
    [Parameter(Mandatory = false)] public int? DomainRole { get; set; }
    [Parameter(Mandatory = true)] public required bool ExcludeFromMaintenance { get; set; }
    [Parameter(Mandatory = false)] public string? ExternalIpAddress { get; set; }
    [Parameter(Mandatory = false)] public bool? HasPendingReboot { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? InternalIpAddress { get; set; }
    [Parameter(Mandatory = true)] public required bool IsDevLab { get; set; }
    [Parameter(Mandatory = false)] public bool? IsOnline { get; set; }
    [Parameter(Mandatory = true)] public required bool IsSandbox { get; set; }
    [Parameter(Mandatory = false)] public string? LastBootTimeUtc { get; set; }
    [Parameter(Mandatory = false)] public string? LastLoggedOnUser { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? LastProviderAgentEventDateUtc { get; set; }
    [Parameter(Mandatory = false)] public bool? Licensed { get; set; }
    [Parameter(Mandatory = false)] public string? Manufacturer { get; set; }
    [Parameter(Mandatory = false)] public string? Model { get; set; }
    [Parameter(Mandatory = false)] public string? Notes { get; set; }
    [Parameter(Mandatory = true)] public required ComputerOnboardingStatus OnboardingStatus { get; set; }
    [Parameter(Mandatory = false)] public string? OperatingSystem { get; set; }
    [Parameter(Mandatory = false)] public int? PrimaryPersonId { get; set; }
    [Parameter(Mandatory = false)] public string? PrimaryUserEmail { get; set; }
    [Parameter(Mandatory = false)] public string? PrimaryUserFirstName { get; set; }
    [Parameter(Mandatory = false)] public string? PrimaryUserLastName { get; set; }
    [Parameter(Mandatory = false)] public ICollection<int>? ProviderLinkIds { get; set; }
    [Parameter(Mandatory = false)] public string? SerialNumber { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }
    [Parameter(Mandatory = false)] public string? TenantName { get; set; }

    protected override void ProcessRecord() {
        ComputerListViewModel outputObject = new(ActiveSessionId, ActiveSessionStatus, ChassisTypes, ComputerName, ComputerTagIds, CreatedDate, DeletedAt, DeviceId, DevLabVmClaimExpirationDateUtc, DevLabVmName, DevLabVmUnclaimed, Domain, DomainRole, ExcludeFromMaintenance, ExternalIpAddress, HasPendingReboot, Id, InternalIpAddress, IsDevLab, IsOnline, IsSandbox, LastBootTimeUtc, LastLoggedOnUser, LastProviderAgentEventDateUtc, Licensed, Manufacturer, Model, Notes, OnboardingStatus, OperatingSystem, PrimaryPersonId, PrimaryUserEmail, PrimaryUserFirstName, PrimaryUserLastName, ProviderLinkIds, SerialNumber, TenantId, TenantName);
        WriteObject(outputObject);
    }
}
