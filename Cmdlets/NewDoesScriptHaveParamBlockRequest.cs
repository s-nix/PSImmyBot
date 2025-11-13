using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "DoesScriptHaveParamBlockRequest")]
public class NewDoesScriptHaveParamBlockRequest : Cmdlet {
    [Parameter(Mandatory = false)] public string? Script { get; set; }

    protected override void ProcessRecord() {
        DoesScriptHaveParamBlockRequest outputObject = new(Script);
        WriteObject(outputObject);
    }
}
