using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "LocalSoftwareList")]
public class GetLocalSoftwareList : Cmdlet
{
    [Parameter(Mandatory = false)]
    public string? Include { get; set; }


    protected override void ProcessRecord()
    {
        string endpoint = "/api/v1/software/local?";
        endpoint += Globals.ConvertToQueryParameters(Include, "include");

        List<GetLocalSoftwareResponse> response = ImmyBotApiService.Get<List<GetLocalSoftwareResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
