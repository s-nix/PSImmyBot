using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "RegistryKeyDto")]
public class NewRegistryKeyDto : Cmdlet {
    [Parameter(Mandatory = false)] public string? DisplayName { get; set; }
    [Parameter(Mandatory = false)] public string? FullPath { get; set; }
    [Parameter(Mandatory = true)] public required int SubKeyCount { get; set; }
    [Parameter(Mandatory = true)] public required int ValueCount { get; set; }

    protected override void ProcessRecord() {
        RegistryKeyDto outputObject = new(DisplayName, FullPath, SubKeyCount, ValueCount);
        WriteObject(outputObject);
    }
}
