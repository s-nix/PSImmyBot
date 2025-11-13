using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "SubscriptionFeatureLevelInfo")]
public class NewSubscriptionFeatureLevelInfo : Cmdlet {
    [Parameter(Mandatory = true)] public required bool IsUnlimited { get; set; }
    [Parameter(Mandatory = true)] public required int Level { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = false)] public string? Value { get; set; }

    protected override void ProcessRecord() {
        SubscriptionFeatureLevelInfo outputObject = new(IsUnlimited, Level, Name, Value);
        WriteObject(outputObject);
    }
}
