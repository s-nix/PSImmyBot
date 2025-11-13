using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ComputerLatestProviderEvent")]
public class NewComputerLatestProviderEvent : Cmdlet {
    [Parameter(Mandatory = true)] public required Computer Computer { get; set; }
    [Parameter(Mandatory = true)] public required int ComputerId { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset LastProviderAgentEventDateUtc { get; set; }

    protected override void ProcessRecord() {
        ComputerLatestProviderEvent outputObject = new(Computer, ComputerId, LastProviderAgentEventDateUtc);
        WriteObject(outputObject);
    }
}
