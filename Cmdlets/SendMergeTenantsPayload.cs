using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "MergeTenantsPayload")]
public class SendMergeTenantsPayload : Cmdlet {

    [Parameter(Mandatory = true)] public required MergeTenantsPayload PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/tenants/bulk-merge?";

        CommandResult response = ImmyBotApiService.Post<MergeTenantsPayload, CommandResult>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
