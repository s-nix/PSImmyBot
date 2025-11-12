using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "ComputerSearch")]
public class GetComputerSearch : Cmdlet {
    [Parameter(Mandatory = false)]
    public string? Name { get; set; }

    [Parameter(Mandatory = false)]
    public int? TenantId { get; set; }

    [Parameter(Mandatory = false)]
    public bool? OrderByUpdatedDate { get; set; }

    [Parameter(Mandatory = false)]
    public int? PageSize { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/computers?";
        endpoint += Globals.ConvertToQueryParameters(Name, "name");
        endpoint += Globals.ConvertToQueryParameters(TenantId, "tenantId");
        endpoint += Globals.ConvertToQueryParameters(OrderByUpdatedDate, "orderByUpdatedDate");
        endpoint += Globals.ConvertToQueryParameters(PageSize, "pageSize");

        List<ComputerSearch> response = ImmyBotApiService.Get<List<ComputerSearch>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
