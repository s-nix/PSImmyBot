using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetEphemeralAgentResponse")]
public class NewGetEphemeralAgentResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedAt { get; set; }
    [Parameter(Mandatory = true)] public required Guid Id { get; set; }
    [Parameter(Mandatory = true)] public required bool IsConnected { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset LastActivity { get; set; }
    [Parameter(Mandatory = true)] public required AgentStartupInfo StartupInfo { get; set; }
    [Parameter(Mandatory = true)] public required int TotalProcessedScriptCount { get; set; }
    [Parameter(Mandatory = true)] public required int TotalReceievedBytes { get; set; }
    [Parameter(Mandatory = true)] public required int TotalSentBytes { get; set; }

    protected override void ProcessRecord() {
        GetEphemeralAgentResponse outputObject = new(CreatedAt, Id, IsConnected, LastActivity, StartupInfo, TotalProcessedScriptCount, TotalReceievedBytes, TotalSentBytes);
        WriteObject(outputObject);
    }
}
