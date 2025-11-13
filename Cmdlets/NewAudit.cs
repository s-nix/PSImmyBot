using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "Audit")]
public class NewAudit : Cmdlet {
    [Parameter(Mandatory = false)] public string? AffectedProperties { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset DateTimeUtc { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? Message { get; set; }
    [Parameter(Mandatory = false)] public string? NewValues { get; set; }
    [Parameter(Mandatory = false)] public string? ObjectName { get; set; }
    [Parameter(Mandatory = false)] public string? ObjectType { get; set; }
    [Parameter(Mandatory = false)] public string? OldValues { get; set; }
    [Parameter(Mandatory = false)] public string? PrimaryKey { get; set; }
    [Parameter(Mandatory = false)] public string? Type { get; set; }
    [Parameter(Mandatory = false)] public string? UserAzureId { get; set; }
    [Parameter(Mandatory = false)] public string? UserDisplayName { get; set; }
    [Parameter(Mandatory = false)] public int? UserId { get; set; }

    protected override void ProcessRecord() {
        Audit outputObject = new(AffectedProperties, DateTimeUtc, Id, Message, NewValues, ObjectName, ObjectType, OldValues, PrimaryKey, Type, UserAzureId, UserDisplayName, UserId);
        WriteObject(outputObject);
    }
}
