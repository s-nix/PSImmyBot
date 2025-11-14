using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "MigratorDataDto")]
public class NewMigratorDataDto : Cmdlet {
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }

    protected override void ProcessRecord() {
        MigratorDataDto outputObject = new(Id, Name);
        WriteObject(outputObject);
    }
}
