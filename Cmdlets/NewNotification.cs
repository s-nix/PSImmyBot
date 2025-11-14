using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "Notification")]
public class NewNotification : Cmdlet {
    [Parameter(Mandatory = false)] public string? AcknowledgedByUserAzureId { get; set; }
    [Parameter(Mandatory = false)] public string? AcknowledgedByUserDisplayName { get; set; }
    [Parameter(Mandatory = false)] public int? AcknowledgedByUserId { get; set; }
    [Parameter(Mandatory = true)] public required NotificationAcknowledgement Acknowledgement { get; set; }
    [Parameter(Mandatory = true)] public required bool AdminOnly { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDate { get; set; }
    [Parameter(Mandatory = false)] public string? Description { get; set; }
    [Parameter(Mandatory = true)] public required Guid Id { get; set; }
    [Parameter(Mandatory = false)] public object? InputData { get; set; }
    [Parameter(Mandatory = false)] public string? ObjectId { get; set; }
    [Parameter(Mandatory = false)] public int? OnlyForUserId { get; set; }
    [Parameter(Mandatory = false)] public object? OutputData { get; set; }
    [Parameter(Mandatory = true)] public required bool Resolved { get; set; }
    [Parameter(Mandatory = true)] public required NotificationSeverity Severity { get; set; }
    [Parameter(Mandatory = false)] public int? TenantId { get; set; }
    [Parameter(Mandatory = false)] public string? Title { get; set; }
    [Parameter(Mandatory = false)] public int? TriggeredByUserId { get; set; }
    [Parameter(Mandatory = true)] public required NotificationType Type { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDate { get; set; }

    protected override void ProcessRecord() {
        Notification outputObject = new(AcknowledgedByUserAzureId, AcknowledgedByUserDisplayName, AcknowledgedByUserId, Acknowledgement, AdminOnly, CreatedDate, Description, Id, InputData, ObjectId, OnlyForUserId, OutputData, Resolved, Severity, TenantId, Title, TriggeredByUserId, Type, UpdatedDate);
        WriteObject(outputObject);
    }
}
