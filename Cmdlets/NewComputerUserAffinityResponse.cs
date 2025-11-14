using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ComputerUserAffinityResponse")]
public class NewComputerUserAffinityResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required int ComputerId { get; set; }
    [Parameter(Mandatory = false)] public string? ComputerName { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset Date { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required int PersonId { get; set; }
    [Parameter(Mandatory = false)] public string? PersonName { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }
    [Parameter(Mandatory = false)] public string? TenantName { get; set; }

    protected override void ProcessRecord() {
        ComputerUserAffinityResponse outputObject = new(ComputerId, ComputerName, Date, Id, PersonId, PersonName, TenantId, TenantName);
        WriteObject(outputObject);
    }
}
