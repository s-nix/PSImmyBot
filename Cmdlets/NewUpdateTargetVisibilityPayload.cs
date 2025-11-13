using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "UpdateTargetVisibilityPayload")]
public class NewUpdateTargetVisibilityPayload : Cmdlet {
    [Parameter(Mandatory = true)] public required TargetVisibility TargetVisibility { get; set; }
    [Parameter(Mandatory = false)] public bool? UpdateStatus { get; set; }

    protected override void ProcessRecord() {
        UpdateTargetVisibilityPayload outputObject = new(TargetVisibility, UpdateStatus);
        WriteObject(outputObject);
    }
}
