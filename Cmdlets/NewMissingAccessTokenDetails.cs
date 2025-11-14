using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "MissingAccessTokenDetails")]
public class NewMissingAccessTokenDetails : Cmdlet {
    [Parameter(Mandatory = false)] public string? RequiredScopes { get; set; }
    [Parameter(Mandatory = false)] public string? TenantId { get; set; }

    protected override void ProcessRecord() {
        MissingAccessTokenDetails outputObject = new(RequiredScopes, TenantId);
        WriteObject(outputObject);
    }
}
