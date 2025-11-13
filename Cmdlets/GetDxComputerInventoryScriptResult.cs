using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "DxComputerInventoryScriptResult")]
public class GetDxComputerInventoryScriptResult : Cmdlet {
    [Parameter(Mandatory = false)]
    public DataSourceLoadOptions? LoadOptions { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/computers/inventory?";
        endpoint += Globals.ConvertToQueryParameters(LoadOptions);

        List<DxComputerInventoryScriptResult> response = ImmyBotApiService.Get<List<DxComputerInventoryScriptResult>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
