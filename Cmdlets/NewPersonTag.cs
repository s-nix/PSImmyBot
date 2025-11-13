using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "PersonTag")]
public class NewPersonTag : Cmdlet {
    [Parameter(Mandatory = true)] public required int EntityId { get; set; }
    [Parameter(Mandatory = true)] public required Person Person { get; set; }
    [Parameter(Mandatory = true)] public required Tag Tag { get; set; }
    [Parameter(Mandatory = true)] public required int TagId { get; set; }

    protected override void ProcessRecord() {
        PersonTag outputObject = new(EntityId, Person, Tag, TagId);
        WriteObject(outputObject);
    }
}
