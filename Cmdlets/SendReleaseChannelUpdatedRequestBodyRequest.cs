using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "ReleaseChannelUpdatedRequestBodyRequest")]
public class SendReleaseChannelUpdatedRequestBodyRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required ReleaseChannelUpdatedRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/manager/release-channel-updated?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
    }

}
