using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "ImpersonationRequest")]
public class SendImpersonationRequest : Cmdlet {
    [Parameter(Mandatory = true)]
    public int UserId { get; set; }


    [Parameter(Mandatory = true)] public required ImpersonationRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/users/{UserId}/impersonate?";

        OpResult response = ImmyBotApiService.Post<ImpersonationRequest, OpResult>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
