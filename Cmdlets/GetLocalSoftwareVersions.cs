using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "LocalSoftwareVersions")]
public class GetLocalSoftwareVersions : Cmdlet
{
    [Parameter(Mandatory = true)]
    public required string SoftwareIdentifier { get; set; }


    protected override void ProcessRecord()
    {
        string endpoint = $"/api/v1/software/local/{SoftwareIdentifier}/versions?";

        List<GetLocalSoftwareVersionResponse> response = ImmyBotApiService.Get<List<GetLocalSoftwareVersionResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
