using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "ComputersRestoreRequest")]
public class SendComputersRestoreRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required object PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/computers/restore?";

        bool response = ImmyBotApiService.Post<object, bool>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
