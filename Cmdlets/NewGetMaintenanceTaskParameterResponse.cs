using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetMaintenanceTaskParameterResponse")]
public class NewGetMaintenanceTaskParameterResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required MaintenanceTaskParameterType DataType { get; set; }
    [Parameter(Mandatory = true)] public required MediaResponseBase DefaultMedia { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType DefaultMediaDatabaseType { get; set; }
    [Parameter(Mandatory = false)] public int? DefaultMediaId { get; set; }
    [Parameter(Mandatory = false)] public string? DefaultValue { get; set; }
    [Parameter(Mandatory = true)] public required bool Hidden { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required int MaintenanceTaskId { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = false)] public string? Notes { get; set; }
    [Parameter(Mandatory = true)] public required int Order { get; set; }
    [Parameter(Mandatory = true)] public required bool Required { get; set; }
    [Parameter(Mandatory = false)] public ICollection<string>? SelectableValues { get; set; }

    protected override void ProcessRecord() {
        GetMaintenanceTaskParameterResponse outputObject = new(DataType, DefaultMedia, DefaultMediaDatabaseType, DefaultMediaId, DefaultValue, Hidden, Id, MaintenanceTaskId, Name, Notes, Order, Required, SelectableValues);
        WriteObject(outputObject);
    }
}
