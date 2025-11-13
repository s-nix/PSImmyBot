using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "DynamicProviderTypesReload")]
public class SendDynamicProviderTypesReload : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/dynamic-provider-types/reload?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
