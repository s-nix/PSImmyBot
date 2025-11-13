using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "CreatePersonPayloadRequest")]
public class SendCreatePersonPayloadRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required CreatePersonPayload PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/persons?";

        GetSimplePersonResponse response = ImmyBotApiService.Post<CreatePersonPayload, GetSimplePersonResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
