using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ShowCommandInfo")]
public class NewShowCommandInfo : Cmdlet {
    [Parameter(Mandatory = false)] public string? Definition { get; set; }
    [Parameter(Mandatory = false)] public ICollection<ParameterSet>? ParameterSets { get; set; }

    protected override void ProcessRecord() {
        ShowCommandInfo outputObject = new(Definition, ParameterSets);
        WriteObject(outputObject);
    }
}
