using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetPowerShellInstallScriptParameters")]
public class NewGetPowerShellInstallScriptParameters : Cmdlet {
    [Parameter(Mandatory = true)] public required Platform Platform { get; set; }
    [Parameter(Mandatory = false)] public string? TargetExternalClientId { get; set; }

    protected override void ProcessRecord() {
        GetPowerShellInstallScriptParameters outputObject = new(Platform, TargetExternalClientId);
        WriteObject(outputObject);
    }
}
