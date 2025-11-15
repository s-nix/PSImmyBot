using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "LocalScriptMigrationPreview")]
public class GetLocalScriptMigrationPreview : Cmdlet
{
    [Parameter(Mandatory = true)]
    public int ScriptId { get; set; }


    protected override void ProcessRecord()
    {
        string endpoint = $"/api/v1/scripts/local/{ScriptId}/migrate-local-to-global-what-if?";

        MigrationPreviewResponse response = ImmyBotApiService.Get<MigrationPreviewResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
