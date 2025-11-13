using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "GetSupportBrandingResponse")]
public class GetGetSupportBrandingResponse : Cmdlet {

    protected override void ProcessRecord() {
        string endpoint = "/api/v1/brandings/support-branding?";

        GetSupportBrandingResponse response = ImmyBotApiService.Get<GetSupportBrandingResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
