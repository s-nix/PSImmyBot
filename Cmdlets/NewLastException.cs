using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "LastException")]
public class NewLastException : Cmdlet {
    [Parameter(Mandatory = false)] public IDictionary<string, object>? Data { get; set; }
    [Parameter(Mandatory = false)] public string? HelpLink { get; set; }
    [Parameter(Mandatory = true)] public required int HResult { get; set; }
    [Parameter(Mandatory = true)] public required LastException InnerException { get; set; }
    [Parameter(Mandatory = false)] public string? Message { get; set; }
    [Parameter(Mandatory = false)] public string? Source { get; set; }
    [Parameter(Mandatory = false)] public string? StackTrace { get; set; }
    [Parameter(Mandatory = true)] public required MethodBase TargetSite { get; set; }

    protected override void ProcessRecord() {
        LastException outputObject = new(Data, HelpLink, HResult, InnerException, Message, Source, StackTrace, TargetSite);
        WriteObject(outputObject);
    }
}
