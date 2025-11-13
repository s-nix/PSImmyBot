using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetMaintenanceSessionResponse")]
public class NewGetMaintenanceSessionResponse : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<MaintenanceActionActivityResponse>? Activities { get; set; }
    [Parameter(Mandatory = true)] public required SessionStatus AgentUpdatesStageStatus { get; set; }
    [Parameter(Mandatory = true)] public required GetComputerResponse Computer { get; set; }
    [Parameter(Mandatory = false)] public int? ComputerId { get; set; }
    [Parameter(Mandatory = false)] public string? ComputerName { get; set; }
    [Parameter(Mandatory = false)] public string? CreatedBy { get; set; }
    [Parameter(Mandatory = false)] public int? CreatedById { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDateUtc { get; set; }
    [Parameter(Mandatory = true)] public required SessionStatus DetectionStageStatus { get; set; }
    [Parameter(Mandatory = false)] public string? Duration { get; set; }
    [Parameter(Mandatory = true)] public required SessionStatus ExecutionStageStatus { get; set; }
    [Parameter(Mandatory = true)] public required bool FullMaintenance { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required SessionStatus InventoryStageStatus { get; set; }
    [Parameter(Mandatory = false)] public string? JobId { get; set; }
    [Parameter(Mandatory = false)] public ICollection<GetSessionLogResponse>? Logs { get; set; }
    [Parameter(Mandatory = false)] public ICollection<GetMaintenanceActionResponse>? MaintenanceActions { get; set; }
    [Parameter(Mandatory = true)] public required bool Onboarding { get; set; }
    [Parameter(Mandatory = true)] public required SessionStatus OnboardingStageStatus { get; set; }
    [Parameter(Mandatory = false)] public int? PersonId { get; set; }
    [Parameter(Mandatory = true)] public required SessionStatus ResolutionStageStatus { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? ScheduledExecutionDate { get; set; }
    [Parameter(Mandatory = false)] public int? ScheduledId { get; set; }
    [Parameter(Mandatory = true)] public required SessionJobArgs SessionJobArgs { get; set; }
    [Parameter(Mandatory = true)] public required SessionStatus SessionStatus { get; set; }
    [Parameter(Mandatory = false)] public ICollection<GetMaintenanceSessionStageResponse>? Stages { get; set; }
    [Parameter(Mandatory = true)] public required GetTenantResponse Tenant { get; set; }
    [Parameter(Mandatory = false)] public int? TenantId { get; set; }
    [Parameter(Mandatory = false)] public string? TenantName { get; set; }
    [Parameter(Mandatory = false)] public int? UpdatedById { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDateUtc { get; set; }

    protected override void ProcessRecord() {
        GetMaintenanceSessionResponse outputObject = new(Activities, AgentUpdatesStageStatus, Computer, ComputerId, ComputerName, CreatedBy, CreatedById, CreatedDateUtc, DetectionStageStatus, Duration, ExecutionStageStatus, FullMaintenance, Id, InventoryStageStatus, JobId, Logs, MaintenanceActions, Onboarding, OnboardingStageStatus, PersonId, ResolutionStageStatus, ScheduledExecutionDate, ScheduledId, SessionJobArgs, SessionStatus, Stages, Tenant, TenantId, TenantName, UpdatedById, UpdatedDateUtc);
        WriteObject(outputObject);
    }
}
