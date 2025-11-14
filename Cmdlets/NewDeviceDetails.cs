using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "DeviceDetails")]
public class NewDeviceDetails : Cmdlet {
    [Parameter(Mandatory = false)] public string? AzureTenantId { get; set; }
    [Parameter(Mandatory = false)] public ICollection<int>? ChassisTypes { get; set; }
    [Parameter(Mandatory = false)] public Guid? DeviceId { get; set; }
    [Parameter(Mandatory = false)] public string? DeviceName { get; set; }
    [Parameter(Mandatory = false)] public string? Domain { get; set; }
    [Parameter(Mandatory = false)] public int? DomainRole { get; set; }
    [Parameter(Mandatory = true)] public required bool IsSandbox { get; set; }
    [Parameter(Mandatory = false)] public string? MachineId { get; set; }
    [Parameter(Mandatory = false)] public string? Manufacturer { get; set; }
    [Parameter(Mandatory = false)] public string? OperatingSystemName { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? OsInstallDateUtc { get; set; }
    [Parameter(Mandatory = false)] public string? SerialNumber { get; set; }

    protected override void ProcessRecord() {
        DeviceDetails outputObject = new(AzureTenantId, ChassisTypes, DeviceId, DeviceName, Domain, DomainRole, IsSandbox, MachineId, Manufacturer, OperatingSystemName, OsInstallDateUtc, SerialNumber);
        WriteObject(outputObject);
    }
}
