using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "SendTestBrandingEmailRequest")]
public class SendSendTestBrandingEmailRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required SendTestBrandingEmailRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/brandings/send-test-email?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
    }

}
