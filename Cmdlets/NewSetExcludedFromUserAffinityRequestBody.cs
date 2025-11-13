using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "SetExcludedFromUserAffinityRequestBody")]
public class NewSetExcludedFromUserAffinityRequestBody : Cmdlet {
    [Parameter(Mandatory = true)] public required bool IsExcluded { get; set; }

    protected override void ProcessRecord() {
        SetExcludedFromUserAffinityRequestBody outputObject = new(IsExcluded);
        WriteObject(outputObject);
    }
}
