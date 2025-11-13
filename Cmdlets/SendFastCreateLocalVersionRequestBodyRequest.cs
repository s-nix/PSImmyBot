using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "FastCreateLocalVersionRequestBodyRequest")]
public class SendFastCreateLocalVersionRequestBodyRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required FastCreateLocalVersionRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/software/local/fast-create?";

        GetLocalSoftwareResponse response = ImmyBotApiService.Post<FastCreateLocalVersionRequestBody, GetLocalSoftwareResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
