using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "LocalSoftwareVersion")]
public class GetLocalSoftwareVersion : Cmdlet {
    [Parameter(Mandatory = true)]
    public required string SoftwareIdentifier { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/software/local/{SoftwareIdentifier}/latest?";

        GetLocalSoftwareVersionResponse response = ImmyBotApiService.Get<GetLocalSoftwareVersionResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
