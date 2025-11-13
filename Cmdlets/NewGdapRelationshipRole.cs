using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GdapRelationshipRole")]
public class NewGdapRelationshipRole : Cmdlet {
    [Parameter(Mandatory = false)] public string? RoleDefinitionId { get; set; }
    [Parameter(Mandatory = false)] public string? RoleDefinitionName { get; set; }

    protected override void ProcessRecord() {
        GdapRelationshipRole outputObject = new(RoleDefinitionId, RoleDefinitionName);
        WriteObject(outputObject);
    }
}
