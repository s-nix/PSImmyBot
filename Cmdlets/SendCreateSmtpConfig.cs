using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "CreateSmtpConfig")]
public class SendCreateSmtpConfig : Cmdlet
{
    [Parameter(Mandatory = true)]
    public required CreateSmtpRequest PayloadBody { get; set; }

    protected override void ProcessRecord()
    {
        string endpoint = "/api/v1/smtp-configs?";
        GetSmtpConfigResponse response = ImmyBotApiService
            .Post<CreateSmtpRequest, GetSmtpConfigResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody)
            .GetAwaiter()
            .GetResult();
        WriteObject(response);
    }
}
