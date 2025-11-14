using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "SoftwarePrerequisite")]
public class NewSoftwarePrerequisite : Cmdlet {
    [Parameter(Mandatory = true)] public required ActionToPerform ActionToPerform { get; set; }
    [Parameter(Mandatory = true)] public required Condition Condition { get; set; }
    [Parameter(Mandatory = false)] public ICollection<SoftwareSpecifier>? SoftwaresForCondition { get; set; }
    [Parameter(Mandatory = false)] public ICollection<SoftwareSpecifier>? SoftwareSpecifiers { get; set; }
    [Parameter(Mandatory = false)] public ICollection<SoftwareSpecifier>? SoftwaresToPerformActionOn { get; set; }
    [Parameter(Mandatory = true)] public required SubjectQualifier SubjectQualifier { get; set; }

    protected override void ProcessRecord() {
        SoftwarePrerequisite outputObject = new(ActionToPerform, Condition, SoftwaresForCondition, SoftwareSpecifiers, SoftwaresToPerformActionOn, SubjectQualifier);
        WriteObject(outputObject);
    }
}
