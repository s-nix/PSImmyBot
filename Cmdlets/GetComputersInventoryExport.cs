using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "ComputersInventoryExport")]
public class GetComputersInventoryExport : Cmdlet {
    [Parameter(Mandatory = false)]
    public DataSourceLoadOptions? LoadOptions { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/computers/inventory/export?";
        endpoint += Globals.ConvertToQueryParameters(LoadOptions);

        byte[] response = ImmyBotApiService.Get<byte[]>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
