using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "UpdateApplicationLogSourceContextRequestRequest")]
public class SendUpdateApplicationLogSourceContextRequestRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required UpdateApplicationLogSourceContextRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/application-logs/source-context?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
    }

}
