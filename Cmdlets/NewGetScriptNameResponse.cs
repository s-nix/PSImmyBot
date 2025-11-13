using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetScriptNameResponse")]
public class NewGetScriptNameResponse : Cmdlet {
    [Parameter(Mandatory = false)] public string? Action { get; set; }
    [Parameter(Mandatory = true)] public required ScriptCategory Category { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = false)] public string? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDateUtc { get; set; }

    protected override void ProcessRecord() {
        GetScriptNameResponse outputObject = new(Action, Category, Id, Name, UpdatedBy, UpdatedDateUtc);
        WriteObject(outputObject);
    }
}
