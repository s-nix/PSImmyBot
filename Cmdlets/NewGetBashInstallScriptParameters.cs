using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetBashInstallScriptParameters")]
public class NewGetBashInstallScriptParameters : Cmdlet {
    [Parameter(Mandatory = true)] public required Platform Platform { get; set; }
    [Parameter(Mandatory = false)] public string? TargetExternalClientId { get; set; }

    protected override void ProcessRecord() {
        GetBashInstallScriptParameters outputObject = new(Platform, TargetExternalClientId);
        WriteObject(outputObject);
    }
}
