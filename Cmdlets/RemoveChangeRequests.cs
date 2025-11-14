using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Remove", "ChangeRequests")]
public class RemoveChangeRequests : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/change-requests/{Id}?";

        ImmyBotApiService.Delete(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
