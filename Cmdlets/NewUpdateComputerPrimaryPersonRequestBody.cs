using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "UpdateComputerPrimaryPersonRequestBody")]
public class NewUpdateComputerPrimaryPersonRequestBody : Cmdlet {
    [Parameter(Mandatory = false)] public int? PrimaryPersonId { get; set; }

    protected override void ProcessRecord() {
        UpdateComputerPrimaryPersonRequestBody outputObject = new(PrimaryPersonId);
        WriteObject(outputObject);
    }
}
