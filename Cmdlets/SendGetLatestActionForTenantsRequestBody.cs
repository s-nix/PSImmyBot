using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "GetLatestActionForTenantsRequestBody")]
public class SendGetLatestActionForTenantsRequestBody : Cmdlet {

    [Parameter(Mandatory = true)] public required GetLatestActionForTenantsRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/maintenance-actions/latest-action-for-tenants?";

        object response = ImmyBotApiService.Post<GetLatestActionForTenantsRequestBody, object>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
