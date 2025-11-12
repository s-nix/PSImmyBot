using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "ComputerPageResponse")]
public class GetComputerPageResponse : Cmdlet {
    [Parameter(Mandatory = false)]
    public string? Filter { get; set; }

    [Parameter(Mandatory = false)]
    public int? Skip { get; set; }

    [Parameter(Mandatory = false)]
    public string? Sort { get; set; }

    [Parameter(Mandatory = false)]
    public int? Take { get; set; }

    [Parameter(Mandatory = false)]
    public bool? SortDesc { get; set; }

    [Parameter(Mandatory = false)]
    public bool? OnboardingOnly { get; set; }

    [Parameter(Mandatory = false)]
    public bool? StaleOnly { get; set; }

    [Parameter(Mandatory = false)]
    public bool? DevLabOnly { get; set; }

    [Parameter(Mandatory = false)]
    public bool? IncludeOffline { get; set; }

    [Parameter(Mandatory = false)]
    public int? TenantId { get; set; }

    [Parameter(Mandatory = false)]
    public bool? LicensedOnly { get; set; }

    [Parameter(Mandatory = false)]
    public bool? DeletedOnly { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/computers/paged?";
        endpoint += Globals.ConvertToQueryParameters(Filter, "filter");
        endpoint += Globals.ConvertToQueryParameters(Skip, "skip");
        endpoint += Globals.ConvertToQueryParameters(Sort, "sort");
        endpoint += Globals.ConvertToQueryParameters(Take, "take");
        endpoint += Globals.ConvertToQueryParameters(SortDesc, "sortDesc");
        endpoint += Globals.ConvertToQueryParameters(OnboardingOnly, "onboardingOnly");
        endpoint += Globals.ConvertToQueryParameters(StaleOnly, "staleOnly");
        endpoint += Globals.ConvertToQueryParameters(DevLabOnly, "devLabOnly");
        endpoint += Globals.ConvertToQueryParameters(IncludeOffline, "includeOffline");
        endpoint += Globals.ConvertToQueryParameters(TenantId, "tenantId");
        endpoint += Globals.ConvertToQueryParameters(LicensedOnly, "licensedOnly");
        endpoint += Globals.ConvertToQueryParameters(DeletedOnly, "deletedOnly");

        ComputerPageResponse response = ImmyBotApiService.Get<ComputerPageResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
