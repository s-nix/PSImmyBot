using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "OauthConsentData")]
public class NewOauthConsentData : Cmdlet {
    [Parameter(Mandatory = false)] public Uri? AuthorizationEndpoint { get; set; }
    [Parameter(Mandatory = false)] public string? ClientId { get; set; }
    [Parameter(Mandatory = false)] public IDictionary<string, string>? ExtraQueryParameters { get; set; }
    [Parameter(Mandatory = false)] public string? Resource { get; set; }
    [Parameter(Mandatory = false)] public string? Scopes { get; set; }
    [Parameter(Mandatory = false)] public Uri? TokenEndpoint { get; set; }

    protected override void ProcessRecord() {
        OauthConsentData outputObject = new(AuthorizationEndpoint, ClientId, ExtraQueryParameters, Resource, Scopes, TokenEndpoint);
        WriteObject(outputObject);
    }
}
