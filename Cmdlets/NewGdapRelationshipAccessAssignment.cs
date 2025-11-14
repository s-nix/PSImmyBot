using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GdapRelationshipAccessAssignment")]
public class NewGdapRelationshipAccessAssignment : Cmdlet {
    [Parameter(Mandatory = false)] public string? AccessContainerId { get; set; }
    [Parameter(Mandatory = false)] public string? AccessContainerType { get; set; }

    protected override void ProcessRecord() {
        GdapRelationshipAccessAssignment outputObject = new(AccessContainerId, AccessContainerType);
        WriteObject(outputObject);
    }
}
