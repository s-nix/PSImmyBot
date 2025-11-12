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
        endpoint += Globals.ConvertToQueryParameters(Filter);
         endpoint += Globals.ConvertToQueryParameters(Skip);
         endpoint += Globals.ConvertToQueryParameters(Sort);
         endpoint += Globals.ConvertToQueryParameters(Take);
         endpoint += Globals.ConvertToQueryParameters(SortDesc);
         endpoint += Globals.ConvertToQueryParameters(OnboardingOnly);
         endpoint += Globals.ConvertToQueryParameters(StaleOnly);
         endpoint += Globals.ConvertToQueryParameters(DevLabOnly);
         endpoint += Globals.ConvertToQueryParameters(IncludeOffline);
         endpoint += Globals.ConvertToQueryParameters(TenantId);
         endpoint += Globals.ConvertToQueryParameters(LicensedOnly);
         endpoint += Globals.ConvertToQueryParameters(DeletedOnly);

        ComputerPageResponse response = ImmyBotApiService.Get<ComputerPageResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
