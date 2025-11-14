using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ResolveFailuresRequestBody")]
public class NewResolveFailuresRequestBody : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<int>? AgentIds { get; set; }
    [Parameter(Mandatory = true)] public required bool AllAgents { get; set; }

    protected override void ProcessRecord() {
        ResolveFailuresRequestBody outputObject = new(AgentIds, AllAgents);
        WriteObject(outputObject);
    }
}
