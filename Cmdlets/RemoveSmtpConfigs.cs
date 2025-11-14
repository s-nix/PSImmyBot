using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Remove", "SmtpConfigs")]
public class RemoveSmtpConfigs : Cmdlet {
    [Parameter(Mandatory = true)]
    public int TenantId { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/smtp-configs/{TenantId}?";

        ImmyBotApiService.Delete(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
