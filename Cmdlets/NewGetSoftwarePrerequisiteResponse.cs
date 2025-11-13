using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetSoftwarePrerequisiteResponse")]
public class NewGetSoftwarePrerequisiteResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required ActionToPerform ActionToPerform { get; set; }
    [Parameter(Mandatory = true)] public required Condition Condition { get; set; }
    [Parameter(Mandatory = false)] public ICollection<GetSpecifiedSoftwareResponse>? SoftwaresForCondition { get; set; }
    [Parameter(Mandatory = false)] public ICollection<GetSpecifiedSoftwareResponse>? SoftwaresToPerformActionOn { get; set; }
    [Parameter(Mandatory = true)] public required SubjectQualifier SubjectQualifier { get; set; }

    protected override void ProcessRecord() {
        GetSoftwarePrerequisiteResponse outputObject = new(ActionToPerform, Condition, SoftwaresForCondition, SoftwaresToPerformActionOn, SubjectQualifier);
        WriteObject(outputObject);
    }
}
