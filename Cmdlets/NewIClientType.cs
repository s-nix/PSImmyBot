using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "IClientType")]
public class NewIClientType : Cmdlet {
    [Parameter(Mandatory = false)] public string? ClientTypeDisplayName { get; set; }
    [Parameter(Mandatory = false)] public string? ClientTypeId { get; set; }

    protected override void ProcessRecord() {
        IClientType outputObject = new(ClientTypeDisplayName, ClientTypeId);
        WriteObject(outputObject);
    }
}
