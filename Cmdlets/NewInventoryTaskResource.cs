using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "InventoryTaskResource")]
public class NewInventoryTaskResource : Cmdlet {
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDate { get; set; }
    [Parameter(Mandatory = true)] public required InventoryTaskFrequency Frequency { get; set; }
    [Parameter(Mandatory = true)] public required bool FromProvider { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType InventoryTaskType { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = false)] public ICollection<InventoryTaskScriptResource>? Scripts { get; set; }
    [Parameter(Mandatory = false)] public int? SpecifiedNumMinutes { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDate { get; set; }

    protected override void ProcessRecord() {
        InventoryTaskResource outputObject = new(CreatedDate, Frequency, FromProvider, Id, InventoryTaskType, Name, Scripts, SpecifiedNumMinutes, UpdatedDate);
        WriteObject(outputObject);
    }
}
