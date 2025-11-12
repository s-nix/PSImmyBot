using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "GetGlobalSoftwareResponse")]
public class GetGetGlobalSoftwareResponse : Cmdlet {
    [Parameter(Mandatory = true)]
    public required string SoftwareIdentifier { get; set; }

     [Parameter(Mandatory = false)]
    public string? Include { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/software/global/{SoftwareIdentifier}?";
        endpoint += Globals.ConvertToQueryParameters(Include);

        GetGlobalSoftwareResponse response = ImmyBotApiService.Get<GetGlobalSoftwareResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
