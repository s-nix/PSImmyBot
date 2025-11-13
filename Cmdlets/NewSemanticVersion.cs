using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "SemanticVersion")]
public class NewSemanticVersion : Cmdlet {
    [Parameter(Mandatory = true)] public required bool HasMetadata { get; set; }
    [Parameter(Mandatory = true)] public required bool IsPrerelease { get; set; }
    [Parameter(Mandatory = true)] public required int Major { get; set; }
    [Parameter(Mandatory = false)] public string? Metadata { get; set; }
    [Parameter(Mandatory = true)] public required int Minor { get; set; }
    [Parameter(Mandatory = true)] public required int Patch { get; set; }
    [Parameter(Mandatory = false)] public string? Release { get; set; }
    [Parameter(Mandatory = false)] public ICollection<string>? ReleaseLabels { get; set; }

    protected override void ProcessRecord() {
        SemanticVersion outputObject = new(HasMetadata, IsPrerelease, Major, Metadata, Minor, Patch, Release, ReleaseLabels);
        WriteObject(outputObject);
    }
}
