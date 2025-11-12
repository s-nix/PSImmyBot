using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "SendTestEmailRequestRequest")]
public class SendSendTestEmailRequestRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required SendTestEmailRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/smtp-configs/send-test-email?";

        string response = ImmyBotApiService.Post<SendTestEmailRequest, string>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
