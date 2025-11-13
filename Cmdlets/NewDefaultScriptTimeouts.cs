using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "DefaultScriptTimeouts")]
public class NewDefaultScriptTimeouts : Cmdlet {
    [Parameter(Mandatory = true)] public required int Detection { get; set; }
    [Parameter(Mandatory = true)] public required int Action { get; set; }
    [Parameter(Mandatory = true)] public required int Install { get; set; }
    [Parameter(Mandatory = true)] public required int Uninstall { get; set; }
    [Parameter(Mandatory = true)] public required int Upgrade { get; set; }
    [Parameter(Mandatory = true)] public required int AutoUpdateJob { get; set; }
    [Parameter(Mandatory = true)] public required int DynamicVersions { get; set; }

    protected override void ProcessRecord() {
        DefaultScriptTimeouts outputObject = new(Detection, Action, Install, Uninstall, Upgrade, AutoUpdateJob, DynamicVersions);
        WriteObject(outputObject);
    }
}
