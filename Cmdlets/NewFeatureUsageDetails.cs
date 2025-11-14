using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "FeatureUsageDetails")]
public class NewFeatureUsageDetails : Cmdlet {
    [Parameter(Mandatory = false)] public DateTimeOffset? FeatureTrackStartDateUtc { get; set; }
    [Parameter(Mandatory = false)] public int? ItemCount { get; set; }
    [Parameter(Mandatory = false)] public int? MaxCount { get; set; }
    [Parameter(Mandatory = false)] public int? MaxCountPerItem { get; set; }
    [Parameter(Mandatory = true)] public required FeatureResetInterval ResetInterval { get; set; }

    protected override void ProcessRecord() {
        FeatureUsageDetails outputObject = new(FeatureTrackStartDateUtc, ItemCount, MaxCount, MaxCountPerItem, ResetInterval);
        WriteObject(outputObject);
    }
}
