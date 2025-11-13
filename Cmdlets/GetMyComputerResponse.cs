using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "MyComputerResponse")]
public class GetMyComputerResponse : Cmdlet {

    protected override void ProcessRecord() {
        string endpoint = "/api/v1/computers/my?";

        List<MyComputerResponse> response = ImmyBotApiService.Get<List<MyComputerResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
