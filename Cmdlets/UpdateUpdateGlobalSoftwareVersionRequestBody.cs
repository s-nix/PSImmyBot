using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Update", "UpdateGlobalSoftwareVersionRequestBody")]
public class UpdateUpdateGlobalSoftwareVersionRequestBody : Cmdlet {
    [Parameter(Mandatory = true)]
    public required string SoftwareIdentifier { get; set; }

     [Parameter(Mandatory = true)]
    public required SemanticVersion SemanticVersion { get; set; }


    [Parameter(Mandatory = true)] public required UpdateGlobalSoftwareVersionRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/software/global/{SoftwareIdentifier}/versions/{SemanticVersion}?";

        GetGlobalSoftwareVersionResponse response = ImmyBotApiService.Patch<UpdateGlobalSoftwareVersionRequestBody, GetGlobalSoftwareVersionResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
