using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "UpdateReleaseChannelRequestRequest")]
public class SendUpdateReleaseChannelRequestRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required UpdateReleaseChannelRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/system/update-release-channel?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
    }

}
