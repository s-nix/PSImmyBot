using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "ClearApplicationLogSourceContextRequest")]
public class SendClearApplicationLogSourceContextRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required ClearApplicationLogSourceContextRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/application-logs/source-context/clear?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
    }

}
