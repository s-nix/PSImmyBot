using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ReleaseChannelUpdatedRequestBody")]
public class NewReleaseChannelUpdatedRequestBody : Cmdlet {
    [Parameter(Mandatory = true)] public required ReleaseChannel ReleaseChannel { get; set; }

    protected override void ProcessRecord() {
        ReleaseChannelUpdatedRequestBody outputObject = new(ReleaseChannel);
        WriteObject(outputObject);
    }
}
