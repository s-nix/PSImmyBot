using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "CreateGlobalSoftwareRequestBodyRequest")]
public class SendCreateGlobalSoftwareRequestBodyRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required CreateGlobalSoftwareRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/software/global?";

        GetGlobalSoftwareResponse response = ImmyBotApiService.Post<CreateGlobalSoftwareRequestBody, GetGlobalSoftwareResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
