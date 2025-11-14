using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "AzureGdapRelationshipDetails")]
public class NewAzureGdapRelationshipDetails : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<GdapRelationshipAccessAssignment>? AccessAssignments { get; set; }
    [Parameter(Mandatory = false)] public string? AutoExtendDuration { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? CreatedDateTimeUtc { get; set; }
    [Parameter(Mandatory = false)] public string? DisplayName { get; set; }
    [Parameter(Mandatory = false)] public int? DurationNumDays { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? EndDateTimeUtc { get; set; }
    [Parameter(Mandatory = false)] public string? Id { get; set; }
    [Parameter(Mandatory = false)] public ICollection<GdapRelationshipRole>? Roles { get; set; }
    [Parameter(Mandatory = false)] public string? Status { get; set; }

    protected override void ProcessRecord() {
        AzureGdapRelationshipDetails outputObject = new(AccessAssignments, AutoExtendDuration, CreatedDateTimeUtc, DisplayName, DurationNumDays, EndDateTimeUtc, Id, Roles, Status);
        WriteObject(outputObject);
    }
}
