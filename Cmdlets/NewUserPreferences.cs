using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "UserPreferences")]
public class NewUserPreferences : Cmdlet {
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required bool MaskPiiData { get; set; }
    [Parameter(Mandatory = true)] public required int UserId { get; set; }

    protected override void ProcessRecord() {
        UserPreferences outputObject = new(Id, MaskPiiData, UserId);
        WriteObject(outputObject);
    }
}
