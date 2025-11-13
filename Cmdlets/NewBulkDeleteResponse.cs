using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "BulkDeleteResponse")]
public class NewBulkDeleteResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required int NumDeleted { get; set; }

    protected override void ProcessRecord() {
        BulkDeleteResponse outputObject = new(NumDeleted);
        WriteObject(outputObject);
    }
}
