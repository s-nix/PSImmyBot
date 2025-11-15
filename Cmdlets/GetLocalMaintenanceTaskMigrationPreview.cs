using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "LocalMaintenanceTaskMigrationPreview")]
public class GetLocalMaintenanceTaskMigrationPreview : Cmdlet
{
    [Parameter(Mandatory = true)]
    public int Id { get; set; }


    protected override void ProcessRecord()
    {
        string endpoint = $"/api/v1/maintenance-tasks/local/{Id}/migrate-local-to-global-what-if?";

        MigrationPreviewResponse response = ImmyBotApiService.Get<MigrationPreviewResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
