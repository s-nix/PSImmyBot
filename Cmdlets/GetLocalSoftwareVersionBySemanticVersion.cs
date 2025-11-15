using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "LocalSoftwareVersionBySemanticVersion")]
public class GetLocalSoftwareVersionBySemanticVersion : Cmdlet
{
    [Parameter(Mandatory = true)]
    public required string SoftwareIdentifier { get; set; }

    [Parameter(Mandatory = true)]
    public required SemanticVersion SemanticVersion { get; set; }


    protected override void ProcessRecord()
    {
        string endpoint = $"/api/v1/software/local/{SoftwareIdentifier}/versions/{SemanticVersion}?";

        GetLocalSoftwareVersionResponse response = ImmyBotApiService.Get<GetLocalSoftwareVersionResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
