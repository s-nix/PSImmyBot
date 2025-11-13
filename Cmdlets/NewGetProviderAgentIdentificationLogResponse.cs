using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetProviderAgentIdentificationLogResponse")]
public class NewGetProviderAgentIdentificationLogResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required AgentIdentificationLogType LogType { get; set; }
    [Parameter(Mandatory = false)] public string? Message { get; set; }
    [Parameter(Mandatory = true)] public required int ProviderAgentId { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset TimeUtc { get; set; }

    protected override void ProcessRecord() {
        GetProviderAgentIdentificationLogResponse outputObject = new(Id, LogType, Message, ProviderAgentId, TimeUtc);
        WriteObject(outputObject);
    }
}
