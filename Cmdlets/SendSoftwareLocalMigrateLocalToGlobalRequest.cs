using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "SoftwareLocalMigrateLocalToGlobalRequest")]
public class SendSoftwareLocalMigrateLocalToGlobalRequest : Cmdlet {
    [Parameter(Mandatory = true)]
    public int SoftwareIdentifier { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/software/local/{SoftwareIdentifier}/migrate-local-to-global?";

        int response = ImmyBotApiService.Post<int>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
