using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ClearApplicationLogSourceContextRequest")]
public class NewClearApplicationLogSourceContextRequest : Cmdlet {
    [Parameter(Mandatory = false)] public string? SourceContext { get; set; }

    protected override void ProcessRecord() {
        ClearApplicationLogSourceContextRequest outputObject = new(SourceContext);
        WriteObject(outputObject);
    }
}
