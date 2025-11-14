using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ComputerPageResponse")]
public class NewComputerPageResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required int Count { get; set; }
    [Parameter(Mandatory = false)] public ICollection<ComputerListViewModel>? Results { get; set; }

    protected override void ProcessRecord() {
        ComputerPageResponse outputObject = new(Count, Results);
        WriteObject(outputObject);
    }
}
