using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "UpdateNotesPayload")]
public class NewUpdateNotesPayload : Cmdlet {
    [Parameter(Mandatory = false)] public string? Notes { get; set; }

    protected override void ProcessRecord() {
        UpdateNotesPayload outputObject = new(Notes);
        WriteObject(outputObject);
    }
}
