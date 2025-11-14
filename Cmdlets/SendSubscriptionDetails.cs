using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "SubscriptionDetails")]
public class SendSubscriptionDetails : Cmdlet {

    [Parameter(Mandatory = true)] public required SubscriptionDetails PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v2/manager/update-subscription?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
    }

}
