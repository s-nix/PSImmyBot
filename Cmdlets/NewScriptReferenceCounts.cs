using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ScriptReferenceCounts")]
public class NewScriptReferenceCounts : Cmdlet {
    [Parameter(Mandatory = true)] public required int GlobalMaintenanceTaskCount { get; set; }
    [Parameter(Mandatory = true)] public required int GlobalSoftwareCount { get; set; }
    [Parameter(Mandatory = true)] public required int GlobalSoftwareVersionCount { get; set; }
    [Parameter(Mandatory = true)] public required int LocalMaintenanceTaskCount { get; set; }
    [Parameter(Mandatory = true)] public required int LocalSoftwareCount { get; set; }
    [Parameter(Mandatory = true)] public required int LocalSoftwareVersionCount { get; set; }
    [Parameter(Mandatory = true)] public required int Total { get; set; }

    protected override void ProcessRecord() {
        ScriptReferenceCounts outputObject = new(GlobalMaintenanceTaskCount, GlobalSoftwareCount, GlobalSoftwareVersionCount, LocalMaintenanceTaskCount, LocalSoftwareCount, LocalSoftwareVersionCount, Total);
        WriteObject(outputObject);
    }
}
