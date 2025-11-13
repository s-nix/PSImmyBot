using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "CancelApplicationLockRequest")]
public class SendCancelApplicationLockRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required CancelApplicationLockRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/application-locks/request-cancellation?";

        OpResult response = ImmyBotApiService.Post<CancelApplicationLockRequest, OpResult>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
