using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "ComputerInventorySoftwareByUpgradeCode")]
public class GetComputerInventorySoftwareByUpgradeCode : Cmdlet
{
    [Parameter(Mandatory = true)]
    public required string UpgradeCode { get; set; }


    protected override void ProcessRecord()
    {
        string endpoint = "/api/v1/computers/inventory-software/search-by-upgrade-code?";
        endpoint += Globals.ConvertToQueryParameters(UpgradeCode, "q");

        List<ComputerInventorySoftware> response = ImmyBotApiService.Get<List<ComputerInventorySoftware>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
