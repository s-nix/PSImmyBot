using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ParentTenantInfo")]
public class NewParentTenantInfo : Cmdlet {
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }

    protected override void ProcessRecord() {
        ParentTenantInfo outputObject = new(Id, Name);
        WriteObject(outputObject);
    }
}
