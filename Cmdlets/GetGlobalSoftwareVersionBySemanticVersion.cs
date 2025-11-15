using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "GlobalSoftwareVersionBySemanticVersion")]
public class GetGlobalSoftwareVersionBySemanticVersion : Cmdlet
{
    [Parameter(Mandatory = true)]
    public required string SoftwareIdentifier { get; set; }

    [Parameter(Mandatory = true)]
    public required SemanticVersion SemanticVersion { get; set; }


    protected override void ProcessRecord()
    {
        string endpoint = $"/api/v1/software/global/{SoftwareIdentifier}/versions/{SemanticVersion}?";

        GetGlobalSoftwareVersionResponse response = ImmyBotApiService.Get<GetGlobalSoftwareVersionResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
