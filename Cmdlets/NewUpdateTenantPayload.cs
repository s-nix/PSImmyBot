using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "UpdateTenantPayload")]
public class NewUpdateTenantPayload : Cmdlet {
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public bool? IsMsp { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = false)] public int? ParentTenantId { get; set; }
    [Parameter(Mandatory = false)] public string? Slug { get; set; }

    protected override void ProcessRecord() {
        UpdateTenantPayload outputObject = new(Id, IsMsp, Name, ParentTenantId, Slug);
        WriteObject(outputObject);
    }
}
