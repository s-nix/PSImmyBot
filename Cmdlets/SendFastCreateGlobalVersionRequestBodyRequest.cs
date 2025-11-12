using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "FastCreateGlobalVersionRequestBodyRequest")]
public class SendFastCreateGlobalVersionRequestBodyRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required FastCreateGlobalVersionRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/software/global/fast-create?";

        GetGlobalSoftwareResponse response = ImmyBotApiService.Post<FastCreateGlobalVersionRequestBody, GetGlobalSoftwareResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
