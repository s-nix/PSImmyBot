using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "BillingCreateCustomerPortalSessionRequest")]
public class SendBillingCreateCustomerPortalSessionRequest : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/billing/create-customer-portal-session?";

        GetCustomerPortalSessionResult response = ImmyBotApiService.Post<GetCustomerPortalSessionResult>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
