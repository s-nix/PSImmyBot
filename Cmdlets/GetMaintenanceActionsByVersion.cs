using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "MaintenanceActionsByVersion")]
public class GetMaintenanceActionsByVersion : Cmdlet
{
    [Parameter(Mandatory = true)]
    public SoftwareType SoftwareType { get; set; }

    [Parameter(Mandatory = true)]
    public required string SoftwareIdentifier { get; set; }

    [Parameter(Mandatory = true)]
    public required string Version { get; set; }


    protected override void ProcessRecord()
    {
        string endpoint = "/api/v1/maintenance-actions/version?";
        endpoint += Globals.ConvertToQueryParameters(SoftwareType, "softwareType");
        endpoint += Globals.ConvertToQueryParameters(SoftwareIdentifier, "softwareIdentifier");
        endpoint += Globals.ConvertToQueryParameters(Version, "version");

        List<GetMaintenanceActionResponse> response = ImmyBotApiService.Get<List<GetMaintenanceActionResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
