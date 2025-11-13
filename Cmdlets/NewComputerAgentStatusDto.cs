using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ComputerAgentStatusDto")]
public class NewComputerAgentStatusDto : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<AgentStatusDto>? Agents { get; set; }
    [Parameter(Mandatory = true)] public required bool AllAgentsConnected { get; set; }
    [Parameter(Mandatory = false)] public string? ComputerName { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required bool SomeConnected { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }
    [Parameter(Mandatory = false)] public string? TenantName { get; set; }

    protected override void ProcessRecord() {
        ComputerAgentStatusDto outputObject = new(Agents, AllAgentsConnected, ComputerName, Id, SomeConnected, TenantId, TenantName);
        WriteObject(outputObject);
    }
}
