using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "SessionJobArgs")]
public class NewSessionJobArgs : Cmdlet {
    [Parameter(Mandatory = false)] public int? ActionIdToRerun { get; set; }
    [Parameter(Mandatory = true)] public required bool AllowAccessToParentTenant { get; set; }
    [Parameter(Mandatory = true)] public required bool AppliedOnConnect { get; set; }
    [Parameter(Mandatory = true)] public required bool AutoConsentToReboots { get; set; }
    [Parameter(Mandatory = false)] public Guid? CacheGroupId { get; set; }
    [Parameter(Mandatory = true)] public required bool CacheOnly { get; set; }
    [Parameter(Mandatory = false)] public int? ComputerId { get; set; }
    [Parameter(Mandatory = false)] public int? DeploymentId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType DeploymentType { get; set; }
    [Parameter(Mandatory = true)] public required bool DetectionOnly { get; set; }
    [Parameter(Mandatory = true)] public required EnqueuedSessionType EnqueuedSessionType { get; set; }
    [Parameter(Mandatory = true)] public required bool HasSessionFeatureBeenTracked { get; set; }
    [Parameter(Mandatory = true)] public required bool InstallWindowsUpdates { get; set; }
    [Parameter(Mandatory = true)] public required bool InventoryOnly { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceAgentUpdatesConfiguration MaintenanceAgentUpdatesConfiguration { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceEmailConfiguration MaintenanceEmailConfiguration { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceItem MaintenanceItem { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceOnboardingConfiguration MaintenanceOnboardingConfiguration { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceSchedulingConfiguration MaintenanceSchedulingConfiguration { get; set; }
    [Parameter(Mandatory = true)] public required bool ManuallyResumed { get; set; }
    [Parameter(Mandatory = false)] public int? ManuallyResumedByPersonId { get; set; }
    [Parameter(Mandatory = false)] public int? ManuallyTriggeredByUserId { get; set; }
    [Parameter(Mandatory = true)] public required ComputerOfflineMaintenanceSessionBehavior OfflineBehavior { get; set; }
    [Parameter(Mandatory = false)] public int? PersonId { get; set; }
    [Parameter(Mandatory = true)] public required PromptTimeoutAction PromptTimeoutAction { get; set; }
    [Parameter(Mandatory = true)] public required int PromptTimeoutMinutes { get; set; }
    [Parameter(Mandatory = true)] public required bool PropagateToChildTenants { get; set; }
    [Parameter(Mandatory = true)] public required RebootPreference RebootPreference { get; set; }
    [Parameter(Mandatory = true)] public required bool Repair { get; set; }
    [Parameter(Mandatory = false)] public int? RerunFromScheduleId { get; set; }
    [Parameter(Mandatory = true)] public required bool RerunningAction { get; set; }
    [Parameter(Mandatory = true)] public required bool ResolutionOnly { get; set; }
    [Parameter(Mandatory = true)] public required bool RunInventoryInDetection { get; set; }
    [Parameter(Mandatory = false)] public int? ScheduledId { get; set; }
    [Parameter(Mandatory = false)] public Guid? SessionGroupId { get; set; }
    [Parameter(Mandatory = true)] public required bool SuppressRebootsDuringBusinessHours { get; set; }
    [Parameter(Mandatory = false)] public int? TenantId { get; set; }
    [Parameter(Mandatory = false)] public Guid? TerminalId { get; set; }
    [Parameter(Mandatory = true)] public required bool UseWinningDeployment { get; set; }

    protected override void ProcessRecord() {
        SessionJobArgs outputObject = new(ActionIdToRerun, AllowAccessToParentTenant, AppliedOnConnect, AutoConsentToReboots, CacheGroupId, CacheOnly, ComputerId, DeploymentId, DeploymentType, DetectionOnly, EnqueuedSessionType, HasSessionFeatureBeenTracked, InstallWindowsUpdates, InventoryOnly, MaintenanceAgentUpdatesConfiguration, MaintenanceEmailConfiguration, MaintenanceItem, MaintenanceOnboardingConfiguration, MaintenanceSchedulingConfiguration, ManuallyResumed, ManuallyResumedByPersonId, ManuallyTriggeredByUserId, OfflineBehavior, PersonId, PromptTimeoutAction, PromptTimeoutMinutes, PropagateToChildTenants, RebootPreference, Repair, RerunFromScheduleId, RerunningAction, ResolutionOnly, RunInventoryInDetection, ScheduledId, SessionGroupId, SuppressRebootsDuringBusinessHours, TenantId, TerminalId, UseWinningDeployment);
        WriteObject(outputObject);
    }
}
