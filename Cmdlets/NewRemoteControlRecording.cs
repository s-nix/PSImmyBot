using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "RemoteControlRecording")]
public class NewRemoteControlRecording : Cmdlet {
    [Parameter(Mandatory = false)] public string? BlobName { get; set; }
    [Parameter(Mandatory = true)] public required Computer Computer { get; set; }
    [Parameter(Mandatory = true)] public required int ComputerId { get; set; }
    [Parameter(Mandatory = false)] public int? CreatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDate { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? MimeContentType { get; set; }
    [Parameter(Mandatory = true)] public required Tenant Tenant { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }
    [Parameter(Mandatory = false)] public int? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDate { get; set; }
    [Parameter(Mandatory = true)] public required User User { get; set; }
    [Parameter(Mandatory = true)] public required int UserId { get; set; }

    protected override void ProcessRecord() {
        RemoteControlRecording outputObject = new(BlobName, Computer, ComputerId, CreatedBy, CreatedDate, Id, MimeContentType, Tenant, TenantId, UpdatedBy, UpdatedDate, User, UserId);
        WriteObject(outputObject);
    }
}
