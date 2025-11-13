using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ODataErrorDetails")]
public class NewODataErrorDetails : Cmdlet {
    [Parameter(Mandatory = false)] public string? ClientRequestId { get; set; }
    [Parameter(Mandatory = false)] public string? Code { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? Date { get; set; }
    [Parameter(Mandatory = false)] public string? OdataType { get; set; }
    [Parameter(Mandatory = false)] public string? RequestId { get; set; }

    protected override void ProcessRecord() {
        ODataErrorDetails outputObject = new(ClientRequestId, Code, Date, OdataType, RequestId);
        WriteObject(outputObject);
    }
}
