using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "RegistryValueDto")]
public class NewRegistryValueDto : Cmdlet {
    [Parameter(Mandatory = false)] public string? BinaryValue { get; set; }
    [Parameter(Mandatory = false)] public int? DWordValue { get; set; }
    [Parameter(Mandatory = true)] public required RegistryValueKindDto Kind { get; set; }
    [Parameter(Mandatory = false)] public ICollection<string>? MultiStringValue { get; set; }
    [Parameter(Mandatory = false)] public string? ParentKeyPath { get; set; }
    [Parameter(Mandatory = false)] public long? QWordValue { get; set; }
    [Parameter(Mandatory = false)] public string? StringValue { get; set; }
    [Parameter(Mandatory = false)] public string? ValueName { get; set; }

    protected override void ProcessRecord() {
        RegistryValueDto outputObject = new(BinaryValue, DWordValue, Kind, MultiStringValue, ParentKeyPath, QWordValue, StringValue, ValueName);
        WriteObject(outputObject);
    }
}
