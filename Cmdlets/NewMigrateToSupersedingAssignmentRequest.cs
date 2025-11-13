using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "MigrateToSupersedingAssignmentRequest")]
public class NewMigrateToSupersedingAssignmentRequest : Cmdlet {
    [Parameter(Mandatory = true)] public required int NewTaskId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType NewTaskType { get; set; }
    [Parameter(Mandatory = true)] public required int OldAssignmentId { get; set; }

    protected override void ProcessRecord() {
        MigrateToSupersedingAssignmentRequest outputObject = new(NewTaskId, NewTaskType, OldAssignmentId);
        WriteObject(outputObject);
    }
}
