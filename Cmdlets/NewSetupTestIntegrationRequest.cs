using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "SetupTestIntegrationRequest")]
public class NewSetupTestIntegrationRequest : Cmdlet {
    [Parameter(Mandatory = false)] public string? Script { get; set; }

    protected override void ProcessRecord() {
        SetupTestIntegrationRequest outputObject = new(Script);
        WriteObject(outputObject);
    }
}
