using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "MaintenanceSessionsCancelForSchedule")]
public class GetMaintenanceSessionsCancelForSchedule : Cmdlet {
    [Parameter(Mandatory = true)]
    public int ScheduleId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/maintenance-sessions/cancel-for-schedule/{ScheduleId}?";

        byte[] response = ImmyBotApiService.Get<byte[]>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
