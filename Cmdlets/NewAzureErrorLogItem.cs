using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "AzureErrorLogItem")]
public class NewAzureErrorLogItem : Cmdlet {
    [Parameter(Mandatory = true)] public required AzureError AzureError { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDateUtc { get; set; }
    [Parameter(Mandatory = true)] public required Guid Id { get; set; }
    [Parameter(Mandatory = false)] public int? Oauth2AccessTokenId { get; set; }
    [Parameter(Mandatory = false)] public string? SourceMessage { get; set; }
    [Parameter(Mandatory = false)] public string? TenantPrincipalId { get; set; }

    protected override void ProcessRecord() {
        AzureErrorLogItem outputObject = new(AzureError, CreatedDateUtc, Id, Oauth2AccessTokenId, SourceMessage, TenantPrincipalId);
        WriteObject(outputObject);
    }
}
