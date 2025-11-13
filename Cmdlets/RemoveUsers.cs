using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Remove", "Users")]
public class RemoveUsers : Cmdlet {
    [Parameter(Mandatory = true)]
    public int UserId { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/users/{UserId}?";

        ImmyBotApiService.Delete(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
