using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "ProviderTypeDto")]
public class GetProviderTypeDto : Cmdlet {
    [Parameter(Mandatory = false)]
    public bool? IncludeLinkFormSchemas { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/provider-types?";
        endpoint += Globals.ConvertToQueryParameters(IncludeLinkFormSchemas, "includeLinkFormSchemas");

        List<ProviderTypeDto> response = ImmyBotApiService.Get<List<ProviderTypeDto>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
