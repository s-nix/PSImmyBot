using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "CreateScheduleRequest")]
public class NewCreateScheduleRequest : Cmdlet {
    [Parameter(Mandatory = true)] public required bool AllowAccessToMspResources { get; set; }
    [Parameter(Mandatory = true)] public required bool AllowAccessToParentTenant { get; set; }
    [Parameter(Mandatory = true)] public required bool ApplyWindowsUpdates { get; set; }
    [Parameter(Mandatory = true)] public required bool AutoConsentToReboots { get; set; }
    [Parameter(Mandatory = false)] public string? CustomCronExpression { get; set; }
    [Parameter(Mandatory = false)] public int? Day { get; set; }
    [Parameter(Mandatory = true)] public required bool Disabled { get; set; }
    [Parameter(Mandatory = false)] public string? MaintenanceIdentifier { get; set; }
    [Parameter(Mandatory = false)] public string? MaintenanceTime { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceType MaintenanceType { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = true)] public required ComputerOfflineMaintenanceSessionBehavior OfflineBehavior { get; set; }
    [Parameter(Mandatory = true)] public required PromptTimeoutAction PromptTimeoutAction { get; set; }
    [Parameter(Mandatory = true)] public required int PromptTimeoutMinutes { get; set; }
    [Parameter(Mandatory = true)] public required bool PropagateToChildTenants { get; set; }
    [Parameter(Mandatory = false)] public Guid? ProviderClientGroupType { get; set; }
    [Parameter(Mandatory = false)] public Guid? ProviderDeviceGroupType { get; set; }
    [Parameter(Mandatory = false)] public int? ProviderLinkId { get; set; }
    [Parameter(Mandatory = true)] public required RebootPreference RebootPreference { get; set; }
    [Parameter(Mandatory = true)] public required bool ScheduleExecutionAfterActiveHours { get; set; }
    [Parameter(Mandatory = true)] public required bool SendDetectionEmail { get; set; }
    [Parameter(Mandatory = true)] public required bool SendDetectionEmailWhenAllActionsAreCompliant { get; set; }
    [Parameter(Mandatory = true)] public required bool SendFollowUpEmail { get; set; }
    [Parameter(Mandatory = true)] public required bool SendFollowUpOnlyIfActionNeeded { get; set; }
    [Parameter(Mandatory = true)] public required bool ShowMaintenanceActions { get; set; }
    [Parameter(Mandatory = true)] public required bool ShowPostponeButton { get; set; }
    [Parameter(Mandatory = true)] public required bool ShowRunNowButton { get; set; }
    [Parameter(Mandatory = true)] public required bool SuppressRebootsDuringBusinessHours { get; set; }
    [Parameter(Mandatory = false)] public string? Target { get; set; }
    [Parameter(Mandatory = true)] public required TargetCategory TargetCategory { get; set; }
    [Parameter(Mandatory = true)] public required TargetGroupFilter TargetGroupFilter { get; set; }
    [Parameter(Mandatory = true)] public required TargetType TargetType { get; set; }
    [Parameter(Mandatory = false)] public int? TenantId { get; set; }
    [Parameter(Mandatory = false)] public string? Time { get; set; }
    [Parameter(Mandatory = false)] public string? TimeZoneInfoId { get; set; }
    [Parameter(Mandatory = true)] public required bool UseComputersTimezoneForExecution { get; set; }

    protected override void ProcessRecord() {
        CreateScheduleRequest outputObject = new(AllowAccessToMspResources, AllowAccessToParentTenant, ApplyWindowsUpdates, AutoConsentToReboots, CustomCronExpression, Day, Disabled, MaintenanceIdentifier, MaintenanceTime, MaintenanceType, Name, OfflineBehavior, PromptTimeoutAction, PromptTimeoutMinutes, PropagateToChildTenants, ProviderClientGroupType, ProviderDeviceGroupType, ProviderLinkId, RebootPreference, ScheduleExecutionAfterActiveHours, SendDetectionEmail, SendDetectionEmailWhenAllActionsAreCompliant, SendFollowUpEmail, SendFollowUpOnlyIfActionNeeded, ShowMaintenanceActions, ShowPostponeButton, ShowRunNowButton, SuppressRebootsDuringBusinessHours, Target, TargetCategory, TargetGroupFilter, TargetType, TenantId, Time, TimeZoneInfoId, UseComputersTimezoneForExecution);
        WriteObject(outputObject);
    }
}
