using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "ScriptsLanguageServiceLanguage")]
public class GetScriptsLanguageServiceLanguage : Cmdlet {
    [Parameter(Mandatory = true)]
    public required string TerminalId { get; set; }
    
    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/scripts/language-service/{TerminalId}/language?";

        byte[] response = ImmyBotApiService.Get<byte[]>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
