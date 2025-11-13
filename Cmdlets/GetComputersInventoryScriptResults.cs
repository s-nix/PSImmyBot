using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Text.Json;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "ComputersInventoryScriptResults")]
public class GetComputersInventoryScriptResults : Cmdlet {
    [Parameter(Mandatory = true)]
    public int ComputerId { get; set; }

    [Parameter(Mandatory = true)]
    public required string InventoryKey { get; set; }

    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/computers/{ComputerId}/inventory-script-results/{InventoryKey}?";
        JsonDocument response = ImmyBotApiService.Get<JsonDocument>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        PowerShell ps = PowerShell.Create();
        ps.AddCommand("ConvertFrom-Json");
        ps.AddParameter("InputObject", response.RootElement.GetRawText());
        Collection<PSObject>? result = ps.Invoke();
        WriteObject(result);
    }
}
