using System.Management.Automation;
using System.Text.Json;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

/// <summary>
/// This is a test
/// </summary>
[Cmdlet("Connect", "Api")]
public class ConnectApi : Cmdlet {
    [Parameter(Mandatory = true, ParameterSetName = "Saved")]
    public SwitchParameter UseSavedConfig { get; set; } = false;

    [Parameter(Mandatory = true, Position = 0, ParameterSetName = "Direct")]
    public string AzureTenantDomain { get; set; } = string.Empty;

    [Parameter(Mandatory = true, Position = 1, ParameterSetName = "Direct")]
    public string AzureClientId { get; set; } = string.Empty;

    [Parameter(Mandatory = true, Position = 2, ParameterSetName = "Direct")]
    public string AzureClientSecret { get; set; } = string.Empty;

    [Parameter(Mandatory = true, Position = 3, ParameterSetName = "Direct")]
    public string ImmySubdomain { get; set; } = string.Empty;

    [Parameter(Mandatory = false, ParameterSetName = "Direct")]
    public SwitchParameter Save { get; set; } = false;

    [Parameter(Mandatory = false, ParameterSetName = "Saved")]
    [Parameter(Mandatory = false, ParameterSetName = "Direct")]
    public SwitchParameter Force { get; set; } = false;

    protected override void ProcessRecord() {
        if (Globals.Token != null && !Force) {
            WriteInformation($"An API connection is already established. Expiration time: {Globals.Token.ExpirationTime:yyyy-MM-ddThh:mm:sszzz}", null);
            return;
        }

        if (UseSavedConfig.IsPresent) {
            ApiConnectionConfig config;
            try {
                config = Globals.GetApiConnectionConfig();
            } catch (Exception ex) {
                throw new Exception("Failed to load saved API connection configuration. " +
                    "Please provide connection details directly or save a configuration first.", ex);
            }
            AzureTenantDomain = config.AzureTenantDomain;
            AzureClientId = config.AzureClientId;
            AzureClientSecret = config.AzureClientSecret;
            ImmySubdomain = config.ImmySubdomain;
        }

        string tenantId = GetTenantId(AzureTenantDomain);
        string immyUrl = $"https://{ImmySubdomain}.immy.bot";
        string accessTokenUri = $"https://login.microsoftonline.com/{tenantId}/oauth2/v2.0/token";
        FormUrlEncodedContent body = new([
            new KeyValuePair<string, string>("client_id", AzureClientId),
            new KeyValuePair<string, string>("scope", $"{immyUrl}/.default"),
            new KeyValuePair<string, string>("client_secret", AzureClientSecret),
            new KeyValuePair<string, string>("grant_type", "client_credentials")
        ]);

        HttpClient client = new();
        HttpResponseMessage response = client.PostAsync(accessTokenUri, body).Result;
        if (!response.IsSuccessStatusCode) {
            throw new Exception($"Failed to retrieve Azure access token: {response.ReasonPhrase}");
        }
        string content = response.Content.ReadAsStringAsync().Result;
        AzureTokenResponse azureTokenResponse = JsonSerializer.Deserialize<AzureTokenResponse>(content) ?? throw new Exception("Failed to deserialize Azure token response.");
        Globals.SaveApiToken(azureTokenResponse);

        if (!UseSavedConfig && Save) {
            ApiConnectionConfig config = new() {
                AzureTenantDomain = AzureTenantDomain, AzureClientId = AzureClientId, AzureClientSecret = AzureClientSecret, ImmySubdomain = ImmySubdomain
            };
            _ = Globals.SaveApiConnectionConfig(config);
        }
        WriteInformation("API connection established successfully.", null);
    }

    private static string GetTenantId(string azureDomain) {
        HttpClient client = new();
        string url = $"https://login.windows.net/{azureDomain}/.well-known/openid-configuration";
        HttpResponseMessage response = client.GetAsync(url).Result;
        if (!response.IsSuccessStatusCode) {
            throw new Exception($"Failed to retrieve Azure token endpoint: {response.ReasonPhrase}");
        }
        string content = response.Content.ReadAsStringAsync().Result;
        AzureTokenEndpointMetadataResponse azureTokenEndpointResponse = JsonSerializer.Deserialize<AzureTokenEndpointMetadataResponse>(content) ?? throw new Exception("Failed to deserialize Azure token endpoint response.");
        return azureTokenEndpointResponse.TokenEndpoint.Segments[1].Trim('/');
    }
}
