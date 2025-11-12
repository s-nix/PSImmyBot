using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "CreateLocalSoftwareRequestBodyRequest")]
public class SendCreateLocalSoftwareRequestBodyRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required CreateLocalSoftwareRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/software/local?";

        GetLocalSoftwareResponse response = ImmyBotApiService.Post<CreateLocalSoftwareRequestBody, GetLocalSoftwareResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
