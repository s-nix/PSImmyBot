using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "DeploymentParameterValue")]
public class NewDeploymentParameterValue : Cmdlet {
    [Parameter(Mandatory = false)] public bool? AllowOverride { get; set; }
    [Parameter(Mandatory = false)] public bool? RequiresOverride { get; set; }
    [Parameter(Mandatory = false)] public object? Value { get; set; }

    protected override void ProcessRecord() {
        DeploymentParameterValue outputObject = new(AllowOverride, RequiresOverride, Value);
        WriteObject(outputObject);
    }
}
