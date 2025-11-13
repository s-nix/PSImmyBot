using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "UpdateReleaseChannelRequest")]
public class NewUpdateReleaseChannelRequest : Cmdlet {
    [Parameter(Mandatory = true)] public required ReleaseChannel ReleaseChannel { get; set; }

    protected override void ProcessRecord() {
        UpdateReleaseChannelRequest outputObject = new(ReleaseChannel);
        WriteObject(outputObject);
    }
}
