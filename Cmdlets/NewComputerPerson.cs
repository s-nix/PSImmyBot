using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ComputerPerson")]
public class NewComputerPerson : Cmdlet {
    [Parameter(Mandatory = true)] public required Computer Computer { get; set; }
    [Parameter(Mandatory = true)] public required int ComputerId { get; set; }
    [Parameter(Mandatory = true)] public required Person Person { get; set; }
    [Parameter(Mandatory = true)] public required int PersonId { get; set; }

    protected override void ProcessRecord() {
        ComputerPerson outputObject = new(Computer, ComputerId, Person, PersonId);
        WriteObject(outputObject);
    }
}
