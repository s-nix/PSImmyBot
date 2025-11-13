using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "SmtpConfig")]
public class GetSmtpConfig : Cmdlet {
    [Parameter(Mandatory = true)]
    public int TenantId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/smtp-configs/{TenantId}?";

        GetSmtpConfigResponse response = ImmyBotApiService.Get<GetSmtpConfigResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
