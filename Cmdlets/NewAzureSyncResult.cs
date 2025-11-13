using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "AzureSyncResult")]
public class NewAzureSyncResult : Cmdlet {
    [Parameter(Mandatory = true)] public required DateTimeOffset AttemptDateUtc { get; set; }
    [Parameter(Mandatory = false)] public Guid? AttemptFailedErrorId { get; set; }

    protected override void ProcessRecord() {
        AzureSyncResult outputObject = new(AttemptDateUtc, AttemptFailedErrorId);
        WriteObject(outputObject);
    }
}
