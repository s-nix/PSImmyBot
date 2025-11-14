using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetCustomerPortalSessionResult")]
public class NewGetCustomerPortalSessionResult : Cmdlet {
    [Parameter(Mandatory = false)] public string? AccessUrl { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedAt { get; set; }
    [Parameter(Mandatory = false)] public string? CustomerId { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? ExpiresAt { get; set; }
    [Parameter(Mandatory = false)] public string? PortalSessionId { get; set; }
    [Parameter(Mandatory = true)] public required CustomerPortalSessionStatus Status { get; set; }
    [Parameter(Mandatory = false)] public string? Token { get; set; }

    protected override void ProcessRecord() {
        GetCustomerPortalSessionResult outputObject = new(AccessUrl, CreatedAt, CustomerId, ExpiresAt, PortalSessionId, Status, Token);
        WriteObject(outputObject);
    }
}
