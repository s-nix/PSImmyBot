using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "NuGetVersion")]
public class NewNuGetVersion : Cmdlet {
    [Parameter(Mandatory = true)] public required bool HasMetadata { get; set; }
    [Parameter(Mandatory = true)] public required bool IsLegacyVersion { get; set; }
    [Parameter(Mandatory = true)] public required bool IsPrerelease { get; set; }
    [Parameter(Mandatory = true)] public required bool IsSemVer2 { get; set; }
    [Parameter(Mandatory = true)] public required int Major { get; set; }
    [Parameter(Mandatory = false)] public string? Metadata { get; set; }
    [Parameter(Mandatory = true)] public required int Minor { get; set; }
    [Parameter(Mandatory = false)] public string? OriginalVersion { get; set; }
    [Parameter(Mandatory = true)] public required int Patch { get; set; }
    [Parameter(Mandatory = false)] public string? Release { get; set; }
    [Parameter(Mandatory = false)] public ICollection<string>? ReleaseLabels { get; set; }
    [Parameter(Mandatory = true)] public required int Revision { get; set; }
    [Parameter(Mandatory = false)] public string? Version { get; set; }

    protected override void ProcessRecord() {
        NuGetVersion outputObject = new(HasMetadata, IsLegacyVersion, IsPrerelease, IsSemVer2, Major, Metadata, Minor, OriginalVersion, Patch, Release, ReleaseLabels, Revision, Version);
        WriteObject(outputObject);
    }
}
