using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "Schedules")]
public class GetSchedules : Cmdlet
{
    [Parameter(Mandatory = false)]
    public int? TenantId { get; set; }


    protected override void ProcessRecord()
    {
        string endpoint = "/api/v1/schedules?";
        endpoint += Globals.ConvertToQueryParameters(TenantId, "tenantId");

        List<GetScheduleResponse> response = ImmyBotApiService.Get<List<GetScheduleResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
