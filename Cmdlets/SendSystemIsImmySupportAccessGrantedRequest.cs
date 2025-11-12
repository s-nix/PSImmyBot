using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "SystemIsImmySupportAccessGrantedRequest")]
public class SendSystemIsImmySupportAccessGrantedRequest : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/system/is-immy-support-access-granted?";

        bool response = ImmyBotApiService.Post<bool>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
