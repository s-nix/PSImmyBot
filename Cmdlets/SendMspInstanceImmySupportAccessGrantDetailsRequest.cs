using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "MspInstanceImmySupportAccessGrantDetailsRequest")]
public class SendMspInstanceImmySupportAccessGrantDetailsRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required MspInstanceImmySupportAccessGrantDetails PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/manager/update-immy-support-access-grant-details?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
    }

}
