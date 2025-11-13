using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "MsalErrorDetails")]
public class NewMsalErrorDetails : Cmdlet {
    [Parameter(Mandatory = false)] public string? CorrelationId { get; set; }
    [Parameter(Mandatory = false)] public string? Error { get; set; }
    [Parameter(Mandatory = false)] public ICollection<int>? ErrorCodes { get; set; }
    [Parameter(Mandatory = false)] public string? ErrorDescription { get; set; }
    [Parameter(Mandatory = false)] public string? Timestamp { get; set; }
    [Parameter(Mandatory = false)] public string? TraceId { get; set; }

    protected override void ProcessRecord() {
        MsalErrorDetails outputObject = new(CorrelationId, Error, ErrorCodes, ErrorDescription, Timestamp, TraceId);
        WriteObject(outputObject);
    }
}
