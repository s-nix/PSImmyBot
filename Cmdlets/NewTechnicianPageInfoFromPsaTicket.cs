using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "TechnicianPageInfoFromPsaTicket")]
public class NewTechnicianPageInfoFromPsaTicket : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<UnifiedComputerInfo>? Computers { get; set; }
    [Parameter(Mandatory = false)] public int? PersonId { get; set; }
    [Parameter(Mandatory = false)] public string? PersonName { get; set; }
    [Parameter(Mandatory = false)] public int? TenantId { get; set; }
    [Parameter(Mandatory = false)] public string? TenantName { get; set; }
    [Parameter(Mandatory = false)] public string? TicketClientId { get; set; }
    [Parameter(Mandatory = false)] public string? TicketEmailAddress { get; set; }

    protected override void ProcessRecord() {
        TechnicianPageInfoFromPsaTicket outputObject = new(Computers, PersonId, PersonName, TenantId, TenantName, TicketClientId, TicketEmailAddress);
        WriteObject(outputObject);
    }
}
