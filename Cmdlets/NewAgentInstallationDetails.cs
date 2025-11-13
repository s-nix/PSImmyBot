using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "AgentInstallationDetails")]
public class NewAgentInstallationDetails : Cmdlet {
    [Parameter(Mandatory = false)] public string? DetectedInstalledVersion { get; set; }
    [Parameter(Mandatory = true)] public required bool IsApplicationRegistryEntryPresent { get; set; }
    [Parameter(Mandatory = true)] public required bool IsServicePresent { get; set; }
    [Parameter(Mandatory = true)] public required bool IsServiceRunning { get; set; }
    [Parameter(Mandatory = false)] public string? RunningBinaryVersion { get; set; }

    protected override void ProcessRecord() {
        AgentInstallationDetails outputObject = new(DetectedInstalledVersion, IsApplicationRegistryEntryPresent, IsServicePresent, IsServiceRunning, RunningBinaryVersion);
        WriteObject(outputObject);
    }
}
