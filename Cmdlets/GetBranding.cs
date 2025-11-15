using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "Branding")]
public class GetBranding : Cmdlet {
    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/brandings?";

        List<GetBrandingResponse> response = ImmyBotApiService.Get<List<GetBrandingResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
