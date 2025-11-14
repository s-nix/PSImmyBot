using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "MspInstanceImmySupportAccessGrantDetails")]
public class GetMspInstanceImmySupportAccessGrantDetails : Cmdlet {

    protected override void ProcessRecord() {
        string endpoint = "/api/v1/system/immy-support-access-grant-details?";

        MspInstanceImmySupportAccessGrantDetails response = ImmyBotApiService.Get<MspInstanceImmySupportAccessGrantDetails>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
