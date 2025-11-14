using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "SubscriptionFeature")]
public class NewSubscriptionFeature : Cmdlet {
    [Parameter(Mandatory = false)] public DateTimeOffset? ExpiresAtUtc { get; set; }
    [Parameter(Mandatory = false)] public string? FeatureId { get; set; }
    [Parameter(Mandatory = true)] public required bool IsEnabled { get; set; }
    [Parameter(Mandatory = true)] public required bool IsUnlimited { get; set; }
    [Parameter(Mandatory = false)] public string? Value { get; set; }

    protected override void ProcessRecord() {
        SubscriptionFeature outputObject = new(ExpiresAtUtc, FeatureId, IsEnabled, IsUnlimited, Value);
        WriteObject(outputObject);
    }
}
