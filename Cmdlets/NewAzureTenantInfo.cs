using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "AzureTenantInfo")]
public class NewAzureTenantInfo : Cmdlet {
    [Parameter(Mandatory = false)] public string? DefaultDomainName { get; set; }
    [Parameter(Mandatory = false)] public ICollection<string>? DomainNames { get; set; }
    [Parameter(Mandatory = false)] public string? TenantName { get; set; }

    protected override void ProcessRecord() {
        AzureTenantInfo outputObject = new(DefaultDomainName, DomainNames, TenantName);
        WriteObject(outputObject);
    }
}
