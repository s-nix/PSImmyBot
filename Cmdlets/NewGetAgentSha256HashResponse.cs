using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetAgentSha256HashResponse")]
public class NewGetAgentSha256HashResponse : Cmdlet {
    [Parameter(Mandatory = false)] public string? AgentSha256Hash { get; set; }
    [Parameter(Mandatory = false)] public Uri? DownloadUrl { get; set; }

    protected override void ProcessRecord() {
        GetAgentSha256HashResponse outputObject = new(AgentSha256Hash, DownloadUrl);
        WriteObject(outputObject);
    }
}
