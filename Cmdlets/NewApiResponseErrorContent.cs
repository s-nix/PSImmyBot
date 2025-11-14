using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ApiResponseErrorContent")]
public class NewApiResponseErrorContent : Cmdlet {
    [Parameter(Mandatory = false)] public string? Content { get; set; }
    [Parameter(Mandatory = false)] public string? HttpMethod { get; set; }
    [Parameter(Mandatory = true)] public required int StatusCode { get; set; }
    [Parameter(Mandatory = false)] public string? Uri { get; set; }

    protected override void ProcessRecord() {
        ApiResponseErrorContent outputObject = new(Content, HttpMethod, StatusCode, Uri);
        WriteObject(outputObject);
    }
}
