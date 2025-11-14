using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "DevInstanceDetails")]
public class NewDevInstanceDetails : Cmdlet {
    [Parameter(Mandatory = false)] public string? BackendVersion { get; set; }
    [Parameter(Mandatory = true)] public required bool IsHangfireServerRunning { get; set; }
    [Parameter(Mandatory = false)] public IDictionary<string, string>? PostRoutes { get; set; }

    protected override void ProcessRecord() {
        DevInstanceDetails outputObject = new(BackendVersion, IsHangfireServerRunning, PostRoutes);
        WriteObject(outputObject);
    }
}
