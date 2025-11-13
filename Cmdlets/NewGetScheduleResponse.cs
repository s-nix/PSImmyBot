using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetScheduleResponse")]
public class NewGetScheduleResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required bool AllowAccessToMspResources { get; set; }
    [Parameter(Mandatory = true)] public required bool AllowAccessToParentTenant { get; set; }
    [Parameter(Mandatory = true)] public required bool ApplyWindowsUpdates { get; set; }
    [Parameter(Mandatory = true)] public required bool AutoConsentToReboots { get; set; }
    [Parameter(Mandatory = false)] public int? CreatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDateUtc { get; set; }
    [Parameter(Mandatory = false)] public string? CustomCronExpression { get; set; }
    [Parameter(Mandatory = false)] public int? Day { get; set; }
    [Parameter(Mandatory = true)] public required bool Disabled { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? MaintenanceIdentifier { get; set; }
    [Parameter(Mandatory = false)] public string? MaintenanceTime { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceType MaintenanceType { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? NextOccurenceDate { get; set; }
    [Parameter(Mandatory = true)] public required ComputerOfflineMaintenanceSessionBehavior OfflineBehavior { get; set; }
    [Parameter(Mandatory = true)] public required bool OnboardingOnly { get; set; }
    [Parameter(Mandatory = true)] public required PromptTimeoutAction PromptTimeoutAction { get; set; }
    [Parameter(Mandatory = true)] public required int PromptTimeoutMinutes { get; set; }
    [Parameter(Mandatory = true)] public required bool PropagateToChildTenants { get; set; }
    [Parameter(Mandatory = false)] public Guid? ProviderClientGroupType { get; set; }
    [Parameter(Mandatory = false)] public Guid? ProviderDeviceGroupType { get; set; }
    [Parameter(Mandatory = true)] public required GetProviderLinkResponse ProviderLink { get; set; }
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
    [Parameter(Mandatory = false)] public string? TargetGroupFilterName { get; set; }
    [Parameter(Mandatory = true)] public required bool TargetMissing { get; set; }
    [Parameter(Mandatory = false)] public string? TargetScopeName { get; set; }
    [Parameter(Mandatory = false)] public string? TargetText { get; set; }
    [Parameter(Mandatory = true)] public required TargetType TargetType { get; set; }
    [Parameter(Mandatory = false)] public string? TargetTypeDescription { get; set; }
    [Parameter(Mandatory = true)] public required bool TargetTypeMissing { get; set; }
    [Parameter(Mandatory = false)] public string? TargetTypeName { get; set; }
    [Parameter(Mandatory = false)] public int? TenantId { get; set; }
    [Parameter(Mandatory = true)] public required bool TenantMissing { get; set; }
    [Parameter(Mandatory = false)] public string? Time { get; set; }
    [Parameter(Mandatory = false)] public string? TimeZoneInfoId { get; set; }
    [Parameter(Mandatory = false)] public int? UpdatedBy { get; set; }
    [Parameter(Mandatory = false)] public string? UpdatedByName { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDateUtc { get; set; }
    [Parameter(Mandatory = true)] public required bool UseComputersTimezoneForExecution { get; set; }

    protected override void ProcessRecord() {
        GetScheduleResponse outputObject = new(AllowAccessToMspResources, AllowAccessToParentTenant, ApplyWindowsUpdates, AutoConsentToReboots, CreatedBy, CreatedDateUtc, CustomCronExpression, Day, Disabled, Id, MaintenanceIdentifier, MaintenanceTime, MaintenanceType, Name, NextOccurenceDate, OfflineBehavior, OnboardingOnly, PromptTimeoutAction, PromptTimeoutMinutes, PropagateToChildTenants, ProviderClientGroupType, ProviderDeviceGroupType, ProviderLink, ProviderLinkId, RebootPreference, ScheduleExecutionAfterActiveHours, SendDetectionEmail, SendDetectionEmailWhenAllActionsAreCompliant, SendFollowUpEmail, SendFollowUpOnlyIfActionNeeded, ShowMaintenanceActions, ShowPostponeButton, ShowRunNowButton, SuppressRebootsDuringBusinessHours, Target, TargetCategory, TargetGroupFilter, TargetGroupFilterName, TargetMissing, TargetScopeName, TargetText, TargetType, TargetTypeDescription, TargetTypeMissing, TargetTypeName, TenantId, TenantMissing, Time, TimeZoneInfoId, UpdatedBy, UpdatedByName, UpdatedDateUtc, UseComputersTimezoneForExecution);
        WriteObject(outputObject);
    }
}
