using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "MaintenanceSchedulingConfiguration")]
public class NewMaintenanceSchedulingConfiguration : Cmdlet {
    [Parameter(Mandatory = false)] public string? MaintenanceTime { get; set; }
    [Parameter(Mandatory = true)] public required ComputerOfflineMaintenanceSessionBehavior OfflineBehavior { get; set; }
    [Parameter(Mandatory = true)] public required bool ScheduleExecutionAfterActiveHours { get; set; }
    [Parameter(Mandatory = false)] public string? Time { get; set; }
    [Parameter(Mandatory = false)] public string? TimeZoneInfoId { get; set; }
    [Parameter(Mandatory = true)] public required bool UseComputersTimezoneForExecution { get; set; }

    protected override void ProcessRecord() {
        MaintenanceSchedulingConfiguration outputObject = new(MaintenanceTime, OfflineBehavior, ScheduleExecutionAfterActiveHours, Time, TimeZoneInfoId, UseComputersTimezoneForExecution);
        WriteObject(outputObject);
    }
}
