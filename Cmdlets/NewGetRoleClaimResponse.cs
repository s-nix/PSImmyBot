using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetRoleClaimResponse")]
public class NewGetRoleClaimResponse : Cmdlet {
    [Parameter(Mandatory = false)] public string? ClaimType { get; set; }
    [Parameter(Mandatory = false)] public string? ClaimValue { get; set; }

    protected override void ProcessRecord() {
        GetRoleClaimResponse outputObject = new(ClaimType, ClaimValue);
        WriteObject(outputObject);
    }
}
