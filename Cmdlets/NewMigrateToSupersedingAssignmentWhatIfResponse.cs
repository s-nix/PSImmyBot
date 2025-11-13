using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "MigrateToSupersedingAssignmentWhatIfResponse")]
public class NewMigrateToSupersedingAssignmentWhatIfResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required LocalTargetAssignmentResource Assignment { get; set; }
    [Parameter(Mandatory = true)] public required bool IsNew { get; set; }
    [Parameter(Mandatory = false)] public string? PolicyDescription { get; set; }

    protected override void ProcessRecord() {
        MigrateToSupersedingAssignmentWhatIfResponse outputObject = new(Assignment, IsNew, PolicyDescription);
        WriteObject(outputObject);
    }
}
