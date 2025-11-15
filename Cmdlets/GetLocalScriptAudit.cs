using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "LocalScriptAudit")]
public class GetLocalScriptAudit : Cmdlet
{
    [Parameter(Mandatory = true)]
    public int ScriptId { get; set; }

    [Parameter(Mandatory = false)]
    public int? Skip { get; set; }


    protected override void ProcessRecord()
    {
        string endpoint = $"/api/v1/scripts/local/{ScriptId}/audit?";
        endpoint += Globals.ConvertToQueryParameters(Skip, "skip");

        ScriptActionAuditResult response = ImmyBotApiService.Get<ScriptActionAuditResult>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
