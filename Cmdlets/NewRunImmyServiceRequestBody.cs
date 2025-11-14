using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "RunImmyServiceRequestBody")]
public class NewRunImmyServiceRequestBody : Cmdlet {
    [Parameter(Mandatory = true)] public required bool AllowAccessToParentTenant { get; set; }
    [Parameter(Mandatory = true)] public required bool AutoConsentToReboots { get; set; }
    [Parameter(Mandatory = true)] public required bool CacheOnly { get; set; }
    [Parameter(Mandatory = false)] public ICollection<RunImmybotComputerRequestBody>? Computers { get; set; }
    [Parameter(Mandatory = false)] public int? DeploymentId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType DeploymentType { get; set; }
    [Parameter(Mandatory = true)] public required bool DetectionOnly { get; set; }
    [Parameter(Mandatory = true)] public required bool FullMaintenance { get; set; }
    [Parameter(Mandatory = true)] public required bool InventoryOnly { get; set; }
    [Parameter(Mandatory = false)] public int? LicenseId { get; set; }
    [Parameter(Mandatory = true)] public required RunImmybotMaintenanceRequestBody MaintenanceParams { get; set; }
    [Parameter(Mandatory = true)] public required ComputerOfflineMaintenanceSessionBehavior OfflineBehavior { get; set; }
    [Parameter(Mandatory = false)] public ICollection<RunImmybotPersonRequestBody>? Persons { get; set; }
    [Parameter(Mandatory = true)] public required PromptTimeoutAction PromptTimeoutAction { get; set; }
    [Parameter(Mandatory = true)] public required int PromptTimeoutMinutes { get; set; }
    [Parameter(Mandatory = true)] public required bool PropagateToChildTenants { get; set; }
    [Parameter(Mandatory = false)] public int? ProviderLinkIdForAgentUpdates { get; set; }
    [Parameter(Mandatory = true)] public required RebootPreference RebootPreference { get; set; }
    [Parameter(Mandatory = true)] public required bool ResolutionOnly { get; set; }
    [Parameter(Mandatory = true)] public required bool RunInventoryInDetection { get; set; }
    [Parameter(Mandatory = true)] public required bool ScheduleExecutionAfterActiveHours { get; set; }
    [Parameter(Mandatory = true)] public required bool SendDetectionEmail { get; set; }
    [Parameter(Mandatory = true)] public required bool SendDetectionEmailWhenAllActionsAreCompliant { get; set; }
    [Parameter(Mandatory = true)] public required bool SendFollowUpEmail { get; set; }
    [Parameter(Mandatory = true)] public required bool SendFollowUpOnlyIfActionNeeded { get; set; }
    [Parameter(Mandatory = false)] public Guid? SessionGroupId { get; set; }
    [Parameter(Mandatory = true)] public required bool ShowMaintenanceActions { get; set; }
    [Parameter(Mandatory = true)] public required bool ShowPostponeButton { get; set; }
    [Parameter(Mandatory = true)] public required bool ShowRunNowButton { get; set; }
    [Parameter(Mandatory = true)] public required bool SkipBackgroundJob { get; set; }
    [Parameter(Mandatory = true)] public required bool SuppressRebootsDuringBusinessHours { get; set; }
    [Parameter(Mandatory = false)] public ICollection<RunImmybotTenantRequestBody>? Tenants { get; set; }
    [Parameter(Mandatory = false)] public string? TimeZoneInfoId { get; set; }
    [Parameter(Mandatory = false)] public string? UpdateTime { get; set; }
    [Parameter(Mandatory = true)] public required bool UseComputersTimezoneForExecution { get; set; }
    [Parameter(Mandatory = true)] public required bool UseWinningDeployment { get; set; }

    protected override void ProcessRecord() {
        RunImmyServiceRequestBody outputObject = new(AllowAccessToParentTenant, AutoConsentToReboots, CacheOnly, Computers, DeploymentId, DeploymentType, DetectionOnly, FullMaintenance, InventoryOnly, LicenseId, MaintenanceParams, OfflineBehavior, Persons, PromptTimeoutAction, PromptTimeoutMinutes, PropagateToChildTenants, ProviderLinkIdForAgentUpdates, RebootPreference, ResolutionOnly, RunInventoryInDetection, ScheduleExecutionAfterActiveHours, SendDetectionEmail, SendDetectionEmailWhenAllActionsAreCompliant, SendFollowUpEmail, SendFollowUpOnlyIfActionNeeded, SessionGroupId, ShowMaintenanceActions, ShowPostponeButton, ShowRunNowButton, SkipBackgroundJob, SuppressRebootsDuringBusinessHours, Tenants, TimeZoneInfoId, UpdateTime, UseComputersTimezoneForExecution, UseWinningDeployment);
        WriteObject(outputObject);
    }
}
