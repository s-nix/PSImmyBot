using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "ChangeRequestDiff")]
public class GetChangeRequestDiff : Cmdlet {
    [Parameter(Mandatory = true)]
    public int ChangeRequestId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/target-assignments/change-request/{ChangeRequestId}/diff?";

        ChangeRequestDiff response = ImmyBotApiService.Get<ChangeRequestDiff>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
