using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetClaimsResponse")]
public class NewGetClaimsResponse : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<ClaimResponse>? Claims { get; set; }

    protected override void ProcessRecord() {
        GetClaimsResponse outputObject = new(Claims);
        WriteObject(outputObject);
    }
}
