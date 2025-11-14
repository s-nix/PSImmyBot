using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "Oauth2AuthCodeErrorResponse")]
public class NewOauth2AuthCodeErrorResponse : Cmdlet {
    [Parameter(Mandatory = false)] public string? Error { get; set; }
    [Parameter(Mandatory = false)] public string? ErrorDescription { get; set; }
    [Parameter(Mandatory = false)] public string? ErrorDescription2 { get; set; }

    protected override void ProcessRecord() {
        Oauth2AuthCodeErrorResponse outputObject = new(Error, ErrorDescription, ErrorDescription2);
        WriteObject(outputObject);
    }
}
