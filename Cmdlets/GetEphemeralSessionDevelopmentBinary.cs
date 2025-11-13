using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "EphemeralSessionDevelopmentBinary")]
public class GetEphemeralSessionDevelopmentBinary : Cmdlet {

    protected override void ProcessRecord() {
        string endpoint = "/api/v1/ephemeral-session/development/latest-ephemeral-binary?";

        byte[] response = ImmyBotApiService.Get<byte[]>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
