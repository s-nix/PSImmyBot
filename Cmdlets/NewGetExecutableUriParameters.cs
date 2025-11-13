using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetExecutableUriParameters")]
public class NewGetExecutableUriParameters : Cmdlet {
    [Parameter(Mandatory = false)] public string? TargetExternalClientId { get; set; }

    protected override void ProcessRecord() {
        GetExecutableUriParameters outputObject = new(TargetExternalClientId);
        WriteObject(outputObject);
    }
}
