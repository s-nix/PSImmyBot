using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "Licenses")]
public class GetLicenses : Cmdlet
{
    [Parameter(Mandatory = false)]
    public string? Filters { get; set; }


    protected override void ProcessRecord()
    {
        string endpoint = "/api/v1/licenses?";
        endpoint += Globals.ConvertToQueryParameters(Filters, "filters");

        List<GetLicenseResponse> response = ImmyBotApiService.Get<List<GetLicenseResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
