using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "MaintenanceActionsDxForComputer")]
public class GetMaintenanceActionsDxForComputer : Cmdlet
{
    [Parameter(Mandatory = true)]
    public int ComputerId { get; set; }

    [Parameter(Mandatory = false)]
    public DataSourceLoadOptions? LoadOptions { get; set; }


    protected override void ProcessRecord()
    {
        string endpoint = $"/api/v1/maintenance-actions/dx-for-computer/{ComputerId}?";
        endpoint += Globals.ConvertToQueryParameters(LoadOptions);

        LoadResult response = ImmyBotApiService.Get<LoadResult>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
