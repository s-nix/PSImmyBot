using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Update", "GlobalSoftware")]
public class UpdateGlobalSoftware : Cmdlet {
    [Parameter(Mandatory = true)]
    public required string SoftwareIdentifier { get; set; }
    
    [Parameter(Mandatory = true)] public required UpdateGlobalSoftwareRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/software/global/{SoftwareIdentifier}?";

        GetGlobalSoftwareResponse response = ImmyBotApiService.Patch<UpdateGlobalSoftwareRequestBody, GetGlobalSoftwareResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
