using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "AzureError")]
public class NewAzureError : Cmdlet {
    [Parameter(Mandatory = true)] public required ApiResponseErrorContent ApiResponseContent { get; set; }
    [Parameter(Mandatory = true)] public required AzureTenantTokenCredentialDetails CredentialDetails { get; set; }
    [Parameter(Mandatory = false)] public string? FormattedErrorMessage { get; set; }
    [Parameter(Mandatory = false)] public string? Message { get; set; }
    [Parameter(Mandatory = true)] public required MissingAccessTokenDetails MissingAccessToken { get; set; }
    [Parameter(Mandatory = true)] public required MsalErrorDetails MsalError { get; set; }
    [Parameter(Mandatory = true)] public required Oauth2AccessTokenErrorResponse OauthAccessTokenErrorResponse { get; set; }
    [Parameter(Mandatory = true)] public required ODataErrorDetails ODataError { get; set; }
    [Parameter(Mandatory = true)] public required ApiResponseErrorContent PartnerCenterApiResponseDetails { get; set; }

    protected override void ProcessRecord() {
        AzureError outputObject = new(ApiResponseContent, CredentialDetails, FormattedErrorMessage, Message, MissingAccessToken, MsalError, OauthAccessTokenErrorResponse, ODataError, PartnerCenterApiResponseDetails);
        WriteObject(outputObject);
    }
}
