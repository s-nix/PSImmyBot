using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "IdentifyAgentRequest")]
public class NewIdentifyAgentRequest : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<int>? AgentIds { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }

    protected override void ProcessRecord() {
        IdentifyAgentRequest outputObject = new(AgentIds, TenantId);
        WriteObject(outputObject);
    }
}
