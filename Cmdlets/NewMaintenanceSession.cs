using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "MaintenanceSession")]
public class NewMaintenanceSession : Cmdlet {
    [Parameter(Mandatory = true)] public required ActiveSession ActiveSession { get; set; }
    [Parameter(Mandatory = false)] public ICollection<MaintenanceActionActivity>? Activities { get; set; }
    [Parameter(Mandatory = true)] public required Computer Computer { get; set; }
    [Parameter(Mandatory = false)] public int? ComputerId { get; set; }
    [Parameter(Mandatory = false)] public int? CreatedBy { get; set; }
    [Parameter(Mandatory = true)] public required User CreatedByUser { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDate { get; set; }
    [Parameter(Mandatory = false)] public string? Duration { get; set; }
    [Parameter(Mandatory = true)] public required bool FullMaintenance { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required SessionJobArgs JobArgs { get; set; }
    [Parameter(Mandatory = false)] public string? JobId { get; set; }
    [Parameter(Mandatory = false)] public ICollection<SessionLog>? Logs { get; set; }
    [Parameter(Mandatory = false)] public ICollection<MaintenanceAction>? MaintenanceActions { get; set; }
    [Parameter(Mandatory = true)] public required bool Onboarding { get; set; }
    [Parameter(Mandatory = true)] public required Tenant OwnerTenant { get; set; }
    [Parameter(Mandatory = true)] public required Person Person { get; set; }
    [Parameter(Mandatory = false)] public int? PersonId { get; set; }
    [Parameter(Mandatory = false)] public ICollection<SessionPhase>? Phases { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? ScheduledExecutionDate { get; set; }
    [Parameter(Mandatory = false)] public int? ScheduledId { get; set; }
    [Parameter(Mandatory = true)] public required SessionStatus SessionStatus { get; set; }
    [Parameter(Mandatory = false)] public ICollection<MaintenanceSessionStage>? Stages { get; set; }
    [Parameter(Mandatory = false)] public int? TenantId { get; set; }
    [Parameter(Mandatory = false)] public int? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDate { get; set; }
    [Parameter(Mandatory = true)] public required bool UsingActiveHours { get; set; }

    protected override void ProcessRecord() {
        MaintenanceSession outputObject = new(ActiveSession, Activities, Computer, ComputerId, CreatedBy, CreatedByUser, CreatedDate, Duration, FullMaintenance, Id, JobArgs, JobId, Logs, MaintenanceActions, Onboarding, OwnerTenant, Person, PersonId, Phases, ScheduledExecutionDate, ScheduledId, SessionStatus, Stages, TenantId, UpdatedBy, UpdatedDate, UsingActiveHours);
        WriteObject(outputObject);
    }
}
