using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ComputerNameResponse")]
public class NewComputerNameResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }

    protected override void ProcessRecord() {
        ComputerNameResponse outputObject = new(Id, Name);
        WriteObject(outputObject);
    }
}
