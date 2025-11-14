using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ChocoSearchResult")]
public class NewChocoSearchResult : Cmdlet {
    [Parameter(Mandatory = false)] public string? Id { get; set; }
    [Parameter(Mandatory = false)] public string? Title { get; set; }

    protected override void ProcessRecord() {
        ChocoSearchResult outputObject = new(Id, Title);
        WriteObject(outputObject);
    }
}
