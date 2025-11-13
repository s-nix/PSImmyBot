using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Update", "UpdateLocalSoftwareRequestBody")]
public class UpdateUpdateLocalSoftwareRequestBody : Cmdlet {
    [Parameter(Mandatory = true)]
    public required string SoftwareIdentifier { get; set; }


    [Parameter(Mandatory = true)] public required UpdateLocalSoftwareRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/software/local/{SoftwareIdentifier}?";

        GetLocalSoftwareResponse response = ImmyBotApiService.Patch<UpdateLocalSoftwareRequestBody, GetLocalSoftwareResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
