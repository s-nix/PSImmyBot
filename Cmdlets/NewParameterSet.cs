using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ParameterSet")]
public class NewParameterSet : Cmdlet {
    [Parameter(Mandatory = true)] public required bool IsDefault { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = false)] public ICollection<Parameter>? Parameters { get; set; }

    protected override void ProcessRecord() {
        ParameterSet outputObject = new(IsDefault, Name, Parameters);
        WriteObject(outputObject);
    }
}
