using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "MaintenanceTaskSearchResult")]
public class NewMaintenanceTaskSearchResult : Cmdlet {
    [Parameter(Mandatory = true)] public required DatabaseType DatabaseType { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = true)] public required bool Owned { get; set; }
    [Parameter(Mandatory = true)] public required bool UseScriptParamBlock { get; set; }

    protected override void ProcessRecord() {
        MaintenanceTaskSearchResult outputObject = new(DatabaseType, Id, Name, Owned, UseScriptParamBlock);
        WriteObject(outputObject);
    }
}
