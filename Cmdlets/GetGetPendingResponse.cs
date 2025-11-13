using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "GetPendingResponse")]
public class GetGetPendingResponse : Cmdlet {
    [Parameter(Mandatory = false)]
    public string? Filter { get; set; }

    [Parameter(Mandatory = false)]
    public string? Sort { get; set; }

    [Parameter(Mandatory = false)]
    public int? Take { get; set; }

    [Parameter(Mandatory = false)]
    public int? Skip { get; set; }

    [Parameter(Mandatory = false)]
    public bool? SortDesc { get; set; }

    [Parameter(Mandatory = false)]
    public bool? IncludeOffline { get; set; }

    [Parameter(Mandatory = false)]
    public int? TenantId { get; set; }

    [Parameter(Mandatory = false)]
    public int? ProviderLinkId { get; set; }

    [Parameter(Mandatory = false)]
    public ProviderAgentFilter? AgentFilter { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/provider-agents/pending?";
        endpoint += Globals.ConvertToQueryParameters(Filter, "filter");
        endpoint += Globals.ConvertToQueryParameters(Sort, "sort");
        endpoint += Globals.ConvertToQueryParameters(Take, "take");
        endpoint += Globals.ConvertToQueryParameters(Skip, "skip");
        endpoint += Globals.ConvertToQueryParameters(SortDesc, "sortDesc");
        endpoint += Globals.ConvertToQueryParameters(IncludeOffline, "includeOffline");
        endpoint += Globals.ConvertToQueryParameters(TenantId, "tenantId");
        endpoint += Globals.ConvertToQueryParameters(ProviderLinkId, "providerLinkId");
        endpoint += Globals.ConvertToQueryParameters(AgentFilter, "agentFilter");

        GetPendingResponse response = ImmyBotApiService.Get<GetPendingResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
