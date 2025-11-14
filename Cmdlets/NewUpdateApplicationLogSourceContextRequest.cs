using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "UpdateApplicationLogSourceContextRequest")]
public class NewUpdateApplicationLogSourceContextRequest : Cmdlet {
    [Parameter(Mandatory = true)] public required LogLevel MinimumLevel { get; set; }
    [Parameter(Mandatory = false)] public string? SourceContext { get; set; }

    protected override void ProcessRecord() {
        UpdateApplicationLogSourceContextRequest outputObject = new(MinimumLevel, SourceContext);
        WriteObject(outputObject);
    }
}
