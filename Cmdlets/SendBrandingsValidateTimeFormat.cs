using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "BrandingsValidateTimeFormat")]
public class SendBrandingsValidateTimeFormat : Cmdlet {
    [Parameter(Mandatory = true)]
    public required string TimeFormat { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/brandings/validate-time-format/{TimeFormat}?";

        string response = ImmyBotApiService.Post<string>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
