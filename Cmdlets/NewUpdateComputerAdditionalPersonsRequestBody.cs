using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "UpdateComputerAdditionalPersonsRequestBody")]
public class NewUpdateComputerAdditionalPersonsRequestBody : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<int>? AdditionalPersonIds { get; set; }

    protected override void ProcessRecord() {
        UpdateComputerAdditionalPersonsRequestBody outputObject = new(AdditionalPersonIds);
        WriteObject(outputObject);
    }
}
