using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "ComputerInventoryAllSoftware")]
public class GetComputerInventoryAllSoftware : Cmdlet {
    [Parameter(Mandatory = false)]
    public string? Q { get; set; }

     [Parameter(Mandatory = false)]
    public int? TenantId { get; set; }

     [Parameter(Mandatory = false)]
    public SoftwareTableNameSearchMode? SearchMode { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/computers/all-inventory-software/search-by-name?";
        endpoint += Globals.ConvertToQueryParameters(Q);
         endpoint += Globals.ConvertToQueryParameters(TenantId);
         endpoint += Globals.ConvertToQueryParameters(SearchMode);

        List<ComputerInventoryAllSoftware> response = ImmyBotApiService.Get<List<ComputerInventoryAllSoftware>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
