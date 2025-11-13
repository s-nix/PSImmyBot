using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "TenantScript")]
public class NewTenantScript : Cmdlet {
    [Parameter(Mandatory = true)] public required Relationship Relationship { get; set; }
    [Parameter(Mandatory = true)] public required Script Script { get; set; }
    [Parameter(Mandatory = true)] public required int ScriptId { get; set; }
    [Parameter(Mandatory = true)] public required Tenant Tenant { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }

    protected override void ProcessRecord() {
        TenantScript outputObject = new(Relationship, Script, ScriptId, Tenant, TenantId);
        WriteObject(outputObject);
    }
}
