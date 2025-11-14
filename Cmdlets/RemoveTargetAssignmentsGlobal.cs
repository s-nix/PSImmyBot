using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Remove", "TargetAssignmentsGlobal")]
public class RemoveTargetAssignmentsGlobal : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/target-assignments/global/{Id}?";

        ImmyBotApiService.Delete(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
