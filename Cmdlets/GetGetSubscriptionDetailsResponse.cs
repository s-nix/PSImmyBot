using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "GetSubscriptionDetailsResponse")]
public class GetGetSubscriptionDetailsResponse : Cmdlet {

    protected override void ProcessRecord() {
        string endpoint = "/api/v1/billing/subscription-details?";

        GetSubscriptionDetailsResponse response = ImmyBotApiService.Get<GetSubscriptionDetailsResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
