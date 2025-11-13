using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "CreateLocalSoftwareVersionRequestBody")]
public class SendCreateLocalSoftwareVersionRequestBody : Cmdlet {
    [Parameter(Mandatory = true)]
    public required string SoftwareIdentifier { get; set; }


    [Parameter(Mandatory = true)] public required CreateLocalSoftwareVersionRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/software/local/{SoftwareIdentifier}/versions?";

        GetLocalSoftwareVersionResponse response = ImmyBotApiService.Post<CreateLocalSoftwareVersionRequestBody, GetLocalSoftwareVersionResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
