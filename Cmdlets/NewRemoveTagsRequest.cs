using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "RemoveTagsRequest")]
public class NewRemoveTagsRequest : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<int>? EntityIds { get; set; }
    [Parameter(Mandatory = false)] public ICollection<int>? TagIds { get; set; }

    protected override void ProcessRecord() {
        RemoveTagsRequest outputObject = new(EntityIds, TagIds);
        WriteObject(outputObject);
    }
}
