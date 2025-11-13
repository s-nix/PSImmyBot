using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "RequestFormSupportBody")]
public class SendRequestFormSupportBody : Cmdlet {

    [Parameter(Mandatory = true)] public required RequestFormSupportBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/system/request-form-support?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
    }

}
