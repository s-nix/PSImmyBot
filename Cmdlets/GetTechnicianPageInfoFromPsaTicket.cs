using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "TechnicianPageInfoFromPsaTicket")]
public class GetTechnicianPageInfoFromPsaTicket : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }

     [Parameter(Mandatory = true)]
    public required string TicketId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/provider-links/{Id}/tickets/{TicketId}?";

        TechnicianPageInfoFromPsaTicket response = ImmyBotApiService.Get<TechnicianPageInfoFromPsaTicket>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
