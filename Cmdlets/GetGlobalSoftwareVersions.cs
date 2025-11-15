using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "GlobalSoftwareVersions")]
public class GetGlobalSoftwareVersions : Cmdlet
{
    [Parameter(Mandatory = true)]
    public required string SoftwareIdentifier { get; set; }


    protected override void ProcessRecord()
    {
        string endpoint = $"/api/v1/software/global/{SoftwareIdentifier}/versions?";

        List<GetGlobalSoftwareVersionResponse> response = ImmyBotApiService.Get<List<GetGlobalSoftwareVersionResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
