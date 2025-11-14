using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "MediaSearchResponse")]
public class NewMediaSearchResponse : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<GlobalMediaResponse>? Global { get; set; }
    [Parameter(Mandatory = false)] public ICollection<LocalMediaResponse>? Local { get; set; }

    protected override void ProcessRecord() {
        MediaSearchResponse outputObject = new(Global, Local);
        WriteObject(outputObject);
    }
}
