using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "BillingPlatformDetails")]
public class GetBillingPlatformDetails : Cmdlet {

    protected override void ProcessRecord() {
        string endpoint = "/api/v1/billing/billing-platform-details?";

        BillingPlatformDetails response = ImmyBotApiService.Get<BillingPlatformDetails>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
