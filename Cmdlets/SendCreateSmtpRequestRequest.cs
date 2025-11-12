using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "CreateSmtpRequestRequest")]
public class SendCreateSmtpRequestRequest : Cmdlet {
    [Parameter(Mandatory = true)]
    public int TenantId { get; set; }


    [Parameter(Mandatory = true)] public required CreateSmtpRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/smtp-configs/{TenantId}?";

        GetSmtpConfigResponse response = ImmyBotApiService.Post<CreateSmtpRequest, GetSmtpConfigResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
