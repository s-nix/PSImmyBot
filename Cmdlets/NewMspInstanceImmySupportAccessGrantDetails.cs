using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "MspInstanceImmySupportAccessGrantDetails")]
public class NewMspInstanceImmySupportAccessGrantDetails : Cmdlet {
    [Parameter(Mandatory = false)] public string? DisabledByEmail { get; set; }
    [Parameter(Mandatory = false)] public string? DisabledByName { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? DisabledDateUtc { get; set; }
    [Parameter(Mandatory = false)] public string? EnabledByEmail { get; set; }
    [Parameter(Mandatory = false)] public string? EnabledByName { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset EnabledDateUtc { get; set; }
    [Parameter(Mandatory = true)] public required bool IsEnabled { get; set; }

    protected override void ProcessRecord() {
        MspInstanceImmySupportAccessGrantDetails outputObject = new(DisabledByEmail, DisabledByName, DisabledDateUtc, EnabledByEmail, EnabledByName, EnabledDateUtc, IsEnabled);
        WriteObject(outputObject);
    }
}
