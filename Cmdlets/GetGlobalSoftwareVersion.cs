using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "GlobalSoftwareVersion")]
public class GetGlobalSoftwareVersion : Cmdlet {
    [Parameter(Mandatory = true)]
    public required string SoftwareIdentifier { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/software/global/{SoftwareIdentifier}/latest?";

        GetGlobalSoftwareVersionResponse response = ImmyBotApiService.Get<GetGlobalSoftwareVersionResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
