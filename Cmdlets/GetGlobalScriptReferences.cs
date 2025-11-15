using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "GlobalScriptReferences")]
public class GetGlobalScriptReferences : Cmdlet
{
    [Parameter(Mandatory = true)]
    public int ScriptId { get; set; }


    protected override void ProcessRecord()
    {
        string endpoint = $"/api/v1/scripts/global/{ScriptId}/references?";

        List<ScriptReference> response = ImmyBotApiService.Get<List<ScriptReference>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
