using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "ComputerAgentStatusDto")]
public class GetComputerAgentStatusDto : Cmdlet {
    [Parameter(Mandatory = false)]
    public DataSourceLoadOptions? LoadOptions { get; set; }

    [Parameter(Mandatory = false)]
    public int? TenantId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/computers/agent-status?";
        endpoint += Globals.ConvertToQueryParameters(LoadOptions);
        endpoint += Globals.ConvertToQueryParameters(TenantId, "tenantId");

        List<ComputerAgentStatusDto> response = ImmyBotApiService.Get<List<ComputerAgentStatusDto>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
