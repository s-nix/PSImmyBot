using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "AgentStartupInfo")]
public class NewAgentStartupInfo : Cmdlet {
    [Parameter(Mandatory = true)] public required AgentInstallationDetails InstalledAgentState { get; set; }
    [Parameter(Mandatory = true)] public required int Pid { get; set; }

    protected override void ProcessRecord() {
        AgentStartupInfo outputObject = new(InstalledAgentState, Pid);
        WriteObject(outputObject);
    }
}
