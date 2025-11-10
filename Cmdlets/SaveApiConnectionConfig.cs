using System.Management.Automation;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsData.Save, "ApiConnectionConfig")]
public class SaveApiConnectionConfig : Cmdlet {
    [Parameter(Mandatory = true, Position = 0)]
    private string AzureTenantDomain { get; set; } = string.Empty;

    [Parameter(Mandatory = true, Position = 1)]
    private string AzureClientId { get; set; } = string.Empty;

    [Parameter(Mandatory = true, Position = 2)]
    private string AzureClientSecret { get; set; } = string.Empty;

    [Parameter(Mandatory = true, Position = 3)]
    private string ImmySubdomain { get; set; } = string.Empty;

    protected override void ProcessRecord() {
        Models.ApiConnectionConfig config = new Models.ApiConnectionConfig {
            AzureTenantDomain = AzureTenantDomain,
            AzureClientId = AzureClientId,
            AzureClientSecret = AzureClientSecret,
            ImmySubdomain = ImmySubdomain
        };
        Models.ApiConnectionConfig savedConfig = Globals.SaveApiConnectionConfig(config);
        WriteObject(savedConfig);
    }
}
