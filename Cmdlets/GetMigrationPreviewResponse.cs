using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "MigrationPreviewResponse")]
public class GetMigrationPreviewResponse : Cmdlet {
    [Parameter(Mandatory = true)]
    public int SoftwareIdentifier { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/software/local/{SoftwareIdentifier}/migrate-local-to-global-what-if?";

        MigrationPreviewResponse response = ImmyBotApiService.Get<MigrationPreviewResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
