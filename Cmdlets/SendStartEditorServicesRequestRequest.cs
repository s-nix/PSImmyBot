using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "StartEditorServicesRequestRequest")]
public class SendStartEditorServicesRequestRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required StartEditorServicesRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/scripts/language-service/start?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
    }

}
