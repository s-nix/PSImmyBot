using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "GlobalSoftwareList")]
public class GetGlobalSoftwareList : Cmdlet
{
    [Parameter(Mandatory = false)]
    public string? Include { get; set; }


    protected override void ProcessRecord()
    {
        string endpoint = "/api/v1/software/global?";
        endpoint += Globals.ConvertToQueryParameters(Include, "include");

        List<GetGlobalSoftwareResponse> response = ImmyBotApiService.Get<List<GetGlobalSoftwareResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
