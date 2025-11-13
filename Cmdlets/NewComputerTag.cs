using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ComputerTag")]
public class NewComputerTag : Cmdlet {
    [Parameter(Mandatory = true)] public required Computer Computer { get; set; }
    [Parameter(Mandatory = true)] public required int EntityId { get; set; }
    [Parameter(Mandatory = true)] public required Tag Tag { get; set; }
    [Parameter(Mandatory = true)] public required int TagId { get; set; }

    protected override void ProcessRecord() {
        ComputerTag outputObject = new(Computer, EntityId, Tag, TagId);
        WriteObject(outputObject);
    }
}
