using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetSourceContextsResponse")]
public class NewGetSourceContextsResponse : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<SourceContextLogLevel>? SourceContextLogLevels { get; set; }
    [Parameter(Mandatory = true)] public required bool StreamingEnabled { get; set; }

    protected override void ProcessRecord() {
        GetSourceContextsResponse outputObject = new(SourceContextLogLevels, StreamingEnabled);
        WriteObject(outputObject);
    }
}
