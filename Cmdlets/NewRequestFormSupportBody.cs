using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "RequestFormSupportBody")]
public class NewRequestFormSupportBody : Cmdlet {
    [Parameter(Mandatory = false)] public bool? AllowTechnicianAccess { get; set; }
    [Parameter(Mandatory = false)] public ICollection<string>? BlobNames { get; set; }
    [Parameter(Mandatory = false)] public string? Notes { get; set; }
    [Parameter(Mandatory = false)] public string? RequesterEmail { get; set; }
    [Parameter(Mandatory = false)] public string? Subject { get; set; }

    protected override void ProcessRecord() {
        RequestFormSupportBody outputObject = new(AllowTechnicianAccess, BlobNames, Notes, RequesterEmail, Subject);
        WriteObject(outputObject);
    }
}
