using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "IpAndHostnames")]
public class GetIpAndHostnames : Cmdlet {

    protected override void ProcessRecord() {
        string endpoint = "/api/v1/auth/get-ip-addresses?";

        ImmyIpAndHostnamesResponse response = ImmyBotApiService.Get<ImmyIpAndHostnamesResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
