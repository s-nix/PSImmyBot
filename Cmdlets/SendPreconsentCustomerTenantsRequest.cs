using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "PreconsentCustomerTenantsRequest")]
public class SendPreconsentCustomerTenantsRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required PreconsentCustomerTenantsRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/azure/preconsent-customer-tenants?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
    }

}
