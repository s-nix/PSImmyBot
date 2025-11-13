using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "ResolveAssignmentsForMaintenanceItemRequestRequest")]
public class SendResolveAssignmentsForMaintenanceItemRequestRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required ResolveAssignmentsForMaintenanceItemRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/tenants/resolve-assignments-for-maintenance-item?";

        ResolveAssignmentsForMaintenanceItemResult response = ImmyBotApiService.Post<ResolveAssignmentsForMaintenanceItemRequest, ResolveAssignmentsForMaintenanceItemResult>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
