using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Update", "UpdateLocalSoftwareVersionRequestBody")]
public class UpdateUpdateLocalSoftwareVersionRequestBody : Cmdlet {
    [Parameter(Mandatory = true)]
    public required string SoftwareIdentifier { get; set; }

     [Parameter(Mandatory = true)]
    public required SemanticVersion SemanticVersion { get; set; }


    [Parameter(Mandatory = true)] public required UpdateLocalSoftwareVersionRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/software/local/{SoftwareIdentifier}/versions/{SemanticVersion}?";

        GetLocalSoftwareVersionResponse response = ImmyBotApiService.Patch<UpdateLocalSoftwareVersionRequestBody, GetLocalSoftwareVersionResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
