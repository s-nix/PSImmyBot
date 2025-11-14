using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "MigrateToSupersedingAssignmentWhatIfResponseOpResult")]
public class NewMigrateToSupersedingAssignmentWhatIfResponseOpResult : Cmdlet {
    [Parameter(Mandatory = true)] public required DateTimeOffset DateCreatedUtc { get; set; }
    [Parameter(Mandatory = true)] public required bool IsSuccess { get; set; }
    [Parameter(Mandatory = false)] public string? Reason { get; set; }
    [Parameter(Mandatory = true)] public required MigrateToSupersedingAssignmentWhatIfResponse Value { get; set; }

    protected override void ProcessRecord() {
        MigrateToSupersedingAssignmentWhatIfResponseOpResult outputObject = new(DateCreatedUtc, IsSuccess, Reason, Value);
        WriteObject(outputObject);
    }
}
