using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "UpdateExpirationRequest")]
public class NewUpdateExpirationRequest : Cmdlet {
    [Parameter(Mandatory = true)] public required ExpirationTime ExpiresIn { get; set; }
    [Parameter(Mandatory = false)] public ICollection<int>? PersonIds { get; set; }

    protected override void ProcessRecord() {
        UpdateExpirationRequest outputObject = new(ExpiresIn, PersonIds);
        WriteObject(outputObject);
    }
}
