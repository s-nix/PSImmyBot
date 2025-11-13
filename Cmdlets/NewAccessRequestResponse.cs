using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "AccessRequestResponse")]
public class NewAccessRequestResponse : Cmdlet {
    [Parameter(Mandatory = false)] public string? AzurePrincipalId { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset DateRequestedUtc { get; set; }
    [Parameter(Mandatory = false)] public string? EmailAddress { get; set; }
    [Parameter(Mandatory = false)] public string? FullName { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required int PersonId { get; set; }

    protected override void ProcessRecord() {
        AccessRequestResponse outputObject = new(AzurePrincipalId, DateRequestedUtc, EmailAddress, FullName, Id, PersonId);
        WriteObject(outputObject);
    }
}
