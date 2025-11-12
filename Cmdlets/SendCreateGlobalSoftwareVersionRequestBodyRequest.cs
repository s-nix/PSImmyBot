using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "CreateGlobalSoftwareVersionRequestBodyRequest")]
public class SendCreateGlobalSoftwareVersionRequestBodyRequest : Cmdlet {
    [Parameter(Mandatory = true)]
    public required string SoftwareIdentifier { get; set; }


    [Parameter(Mandatory = true)] public required CreateGlobalSoftwareVersionRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/software/global/{SoftwareIdentifier}/versions?";

        GetGlobalSoftwareVersionResponse response = ImmyBotApiService.Post<CreateGlobalSoftwareVersionRequestBody, GetGlobalSoftwareVersionResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
