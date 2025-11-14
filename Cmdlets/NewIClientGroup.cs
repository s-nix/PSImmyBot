using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "IClientGroup")]
public class NewIClientGroup : Cmdlet {
    [Parameter(Mandatory = false)] public string? ClientGroupDisplayName { get; set; }
    [Parameter(Mandatory = false)] public string? ClientGroupId { get; set; }

    protected override void ProcessRecord() {
        IClientGroup outputObject = new(ClientGroupDisplayName, ClientGroupId);
        WriteObject(outputObject);
    }
}
