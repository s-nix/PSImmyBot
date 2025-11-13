using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "BatchSetExcludedFromUserAffinityRequestBody")]
public class NewBatchSetExcludedFromUserAffinityRequestBody : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<int>? ComputerIds { get; set; }
    [Parameter(Mandatory = true)] public required bool IsExcluded { get; set; }

    protected override void ProcessRecord() {
        BatchSetExcludedFromUserAffinityRequestBody outputObject = new(ComputerIds, IsExcluded);
        WriteObject(outputObject);
    }
}
