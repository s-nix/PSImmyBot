using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "AppRegistrationOption")]
public class NewAppRegistrationOption : Cmdlet {
    [Parameter(Mandatory = false)] public string? ClientId { get; set; }
    [Parameter(Mandatory = false)] public string? DisplayName { get; set; }

    protected override void ProcessRecord() {
        AppRegistrationOption outputObject = new(ClientId, DisplayName);
        WriteObject(outputObject);
    }
}
