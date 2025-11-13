using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "Feature")]
public class NewFeature : Cmdlet {
    [Parameter(Mandatory = true)] public required bool Enabled { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }

    protected override void ProcessRecord() {
        Feature outputObject = new(Enabled, Name);
        WriteObject(outputObject);
    }
}
