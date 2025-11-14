using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "IClientStatus")]
public class NewIClientStatus : Cmdlet {
    [Parameter(Mandatory = false)] public string? ClientStatusDisplayName { get; set; }
    [Parameter(Mandatory = false)] public string? ClientStatusId { get; set; }

    protected override void ProcessRecord() {
        IClientStatus outputObject = new(ClientStatusDisplayName, ClientStatusId);
        WriteObject(outputObject);
    }
}
