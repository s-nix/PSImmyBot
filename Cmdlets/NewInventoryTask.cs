using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "InventoryTask")]
public class NewInventoryTask : Cmdlet {
    [Parameter(Mandatory = false)] public int? CreatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDate { get; set; }
    [Parameter(Mandatory = true)] public required InventoryTaskFrequency Frequency { get; set; }
    [Parameter(Mandatory = true)] public required string FrequencyTimespan { get; set; }
    [Parameter(Mandatory = true)] public required bool FromProvider { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType InventoryTaskType { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = false)] public ICollection<InventoryTaskScript>? Scripts { get; set; }
    [Parameter(Mandatory = false)] public int? SpecifiedNumMinutes { get; set; }
    [Parameter(Mandatory = false)] public int? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDate { get; set; }

    protected override void ProcessRecord() {
        InventoryTask outputObject = new(CreatedBy, CreatedDate, Frequency, FrequencyTimespan, FromProvider, Id, InventoryTaskType, Name, Scripts, SpecifiedNumMinutes, UpdatedBy, UpdatedDate);
        WriteObject(outputObject);
    }
}
