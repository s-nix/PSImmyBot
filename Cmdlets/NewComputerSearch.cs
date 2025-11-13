using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ComputerSearch")]
public class NewComputerSearch : Cmdlet {
    [Parameter(Mandatory = true)] public required bool ExcludeFromMaintenance { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = true)] public required bool Online { get; set; }
    [Parameter(Mandatory = false)] public string? Tenant { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDate { get; set; }

    protected override void ProcessRecord() {
        ComputerSearch outputObject = new(ExcludeFromMaintenance, Id, Name, Online, Tenant, TenantId, UpdatedDate);
        WriteObject(outputObject);
    }
}
