using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ReleaseDetails")]
public class NewReleaseDetails : Cmdlet {
    [Parameter(Mandatory = false)] public string? ImmyAgentInstallerFileVersion { get; set; }
    [Parameter(Mandatory = true)] public required SemanticVersion ImmyAgentInstallerVersion { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? PublishedDate { get; set; }
    [Parameter(Mandatory = true)] public required ReleaseChannel ReleaseChannel { get; set; }
    [Parameter(Mandatory = false)] public string? ReleaseNotes { get; set; }
    [Parameter(Mandatory = true)] public required SemanticVersion Tag { get; set; }

    protected override void ProcessRecord() {
        ReleaseDetails outputObject = new(ImmyAgentInstallerFileVersion, ImmyAgentInstallerVersion, PublishedDate, ReleaseChannel, ReleaseNotes, Tag);
        WriteObject(outputObject);
    }
}
