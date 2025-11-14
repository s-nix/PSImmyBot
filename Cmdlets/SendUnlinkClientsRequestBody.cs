using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "UnlinkClientsRequestBody")]
public class SendUnlinkClientsRequestBody : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }


    [Parameter(Mandatory = true)] public required UnlinkClientsRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/provider-links/{Id}/clients/unlink-from-tenants?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
    }

}
