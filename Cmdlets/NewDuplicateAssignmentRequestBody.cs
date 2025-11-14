using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "DuplicateAssignmentRequestBody")]
public class NewDuplicateAssignmentRequestBody : Cmdlet {
    [Parameter(Mandatory = true)] public required DatabaseType DatabaseType { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }

    protected override void ProcessRecord() {
        DuplicateAssignmentRequestBody outputObject = new(DatabaseType, Id);
        WriteObject(outputObject);
    }
}
