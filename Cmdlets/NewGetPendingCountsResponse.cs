using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetPendingCountsResponse")]
public class NewGetPendingCountsResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required int Active { get; set; }
    [Parameter(Mandatory = true)] public required int Failed { get; set; }
    [Parameter(Mandatory = true)] public required int Manual { get; set; }
    [Parameter(Mandatory = true)] public required int Offline { get; set; }
    [Parameter(Mandatory = true)] public required int Recent { get; set; }
    [Parameter(Mandatory = true)] public required int Total { get; set; }

    protected override void ProcessRecord() {
        GetPendingCountsResponse outputObject = new(Active, Failed, Manual, Offline, Recent, Total);
        WriteObject(outputObject);
    }
}
