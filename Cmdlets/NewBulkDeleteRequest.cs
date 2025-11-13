using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "BulkDeleteRequest")]
public class NewBulkDeleteRequest : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<int>? Ids { get; set; }
    [Parameter(Mandatory = true)] public required bool Permanent { get; set; }

    protected override void ProcessRecord() {
        BulkDeleteRequest outputObject = new(Ids, Permanent);
        WriteObject(outputObject);
    }
}
