using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "MaintenanceEmailConfiguration")]
public class NewMaintenanceEmailConfiguration : Cmdlet {
    [Parameter(Mandatory = true)] public required bool SendDetectionEmail { get; set; }
    [Parameter(Mandatory = true)] public required bool SendDetectionEmailWhenAllActionsAreCompliant { get; set; }
    [Parameter(Mandatory = true)] public required bool SendFollowUpEmail { get; set; }
    [Parameter(Mandatory = true)] public required bool SendFollowUpOnlyIfActionNeeded { get; set; }
    [Parameter(Mandatory = true)] public required bool ShowMaintenanceActions { get; set; }
    [Parameter(Mandatory = true)] public required bool ShowPostponeButton { get; set; }
    [Parameter(Mandatory = true)] public required bool ShowRunNowButton { get; set; }

    protected override void ProcessRecord() {
        MaintenanceEmailConfiguration outputObject = new(SendDetectionEmail, SendDetectionEmailWhenAllActionsAreCompliant, SendFollowUpEmail, SendFollowUpOnlyIfActionNeeded, ShowMaintenanceActions, ShowPostponeButton, ShowRunNowButton);
        WriteObject(outputObject);
    }
}
