using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "ChangeRequestsRequireChanges")]
public class SendChangeRequestsRequireChanges : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/change-requests/{Id}/require-changes?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
