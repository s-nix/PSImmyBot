using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "ComputerInventorySoftware")]
public class GetComputerInventorySoftware : Cmdlet {
    [Parameter(Mandatory = false)]
    public string? SoftwareName { get; set; }

    [Parameter(Mandatory = false)]
    public SoftwareTableNameSearchMode? SearchMode { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/computers/inventory-software/search-by-name?";
        endpoint += Globals.ConvertToQueryParameters(SoftwareName, "q");
        endpoint += Globals.ConvertToQueryParameters(SearchMode, "searchMode");

        List<ComputerInventorySoftware> response = ImmyBotApiService.Get<List<ComputerInventorySoftware>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
