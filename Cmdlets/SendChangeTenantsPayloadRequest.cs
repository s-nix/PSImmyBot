using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "ChangeTenantsPayloadRequest")]
public class SendChangeTenantsPayloadRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required ChangeTenantsPayload PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/computers/change-tenant?";

        CommandResult response = ImmyBotApiService.Post<ChangeTenantsPayload, CommandResult>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
