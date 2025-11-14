using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "RequestSessionSupportRequestBody")]
public class NewRequestSessionSupportRequestBody : Cmdlet {
    [Parameter(Mandatory = false)] public bool? AllowTechnicianAccess { get; set; }
    [Parameter(Mandatory = true)] public required bool IncludeSessionData { get; set; }
    [Parameter(Mandatory = true)] public required int SessionId { get; set; }
    [Parameter(Mandatory = false)] public string? TicketNotes { get; set; }
    [Parameter(Mandatory = false)] public string? TicketSubject { get; set; }

    protected override void ProcessRecord() {
        RequestSessionSupportRequestBody outputObject = new(AllowTechnicianAccess, IncludeSessionData, SessionId, TicketNotes, TicketSubject);
        WriteObject(outputObject);
    }
}
