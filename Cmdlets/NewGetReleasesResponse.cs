using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetReleasesResponse")]
public class NewGetReleasesResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required ReleaseDetails CurrentRelease { get; set; }
    [Parameter(Mandatory = false)] public ICollection<ReleaseDetails>? LatestReleases { get; set; }

    protected override void ProcessRecord() {
        GetReleasesResponse outputObject = new(CurrentRelease, LatestReleases);
        WriteObject(outputObject);
    }
}
