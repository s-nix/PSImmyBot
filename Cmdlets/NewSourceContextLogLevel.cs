using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "SourceContextLogLevel")]
public class NewSourceContextLogLevel : Cmdlet {
    [Parameter(Mandatory = true)] public required LogLevel LogLevel { get; set; }
    [Parameter(Mandatory = false)] public string? SourceContext { get; set; }

    protected override void ProcessRecord() {
        SourceContextLogLevel outputObject = new(LogLevel, SourceContext);
        WriteObject(outputObject);
    }
}
