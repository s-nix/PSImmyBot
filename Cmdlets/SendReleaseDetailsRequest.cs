using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "ReleaseDetailsRequest")]
public class SendReleaseDetailsRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required ReleaseDetails PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/manager/update-release?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
    }

}
