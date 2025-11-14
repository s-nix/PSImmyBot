using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "TenantPreferences")]
public class NewTenantPreferences : Cmdlet {
    [Parameter(Mandatory = false)] public string? BusinessHoursEnd { get; set; }
    [Parameter(Mandatory = false)] public string? BusinessHoursStart { get; set; }
    [Parameter(Mandatory = true)] public required DefaultEmailBccList DefaultEmailBccList { get; set; }
    [Parameter(Mandatory = false)] public bool? EnableImmyBotRemoteControl { get; set; }
    [Parameter(Mandatory = false)] public bool? EnableImmyBotRemoteControlRecording { get; set; }
    [Parameter(Mandatory = true)] public required bool EnableOnboarding { get; set; }
    [Parameter(Mandatory = true)] public required bool EnableOnboardingPatching { get; set; }
    [Parameter(Mandatory = true)] public required bool EnableSessionEmails { get; set; }
    [Parameter(Mandatory = true)] public required bool EnableUserAffinitySync { get; set; }
    [Parameter(Mandatory = true)] public required bool ExcludeFromCrossTenantDeploymentsAndSchedules { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required bool OverwriteExistingDeviceIfOsIsNew { get; set; }
    [Parameter(Mandatory = true)] public required Tenant OwnerTenant { get; set; }
    [Parameter(Mandatory = false)] public bool? RequireConsentForExternalSessionProviders { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }
    [Parameter(Mandatory = false)] public string? TimeZoneInfoId { get; set; }

    protected override void ProcessRecord() {
        TenantPreferences outputObject = new(BusinessHoursEnd, BusinessHoursStart, DefaultEmailBccList, EnableImmyBotRemoteControl, EnableImmyBotRemoteControlRecording, EnableOnboarding, EnableOnboardingPatching, EnableSessionEmails, EnableUserAffinitySync, ExcludeFromCrossTenantDeploymentsAndSchedules, Id, OverwriteExistingDeviceIfOsIsNew, OwnerTenant, RequireConsentForExternalSessionProviders, TenantId, TimeZoneInfoId);
        WriteObject(outputObject);
    }
}
