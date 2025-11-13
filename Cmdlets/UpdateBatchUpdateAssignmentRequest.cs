using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Update", "BatchUpdateAssignmentRequest")]
public class UpdateBatchUpdateAssignmentRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required BatchUpdateAssignmentRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/target-assignments/batch-update?";

        ImmyBotApiService.Patch(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
    }
}
