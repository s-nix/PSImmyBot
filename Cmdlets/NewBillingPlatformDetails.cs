using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "BillingPlatformDetails")]
public class NewBillingPlatformDetails : Cmdlet {
    [Parameter(Mandatory = false)] public string? SiteName { get; set; }

    protected override void ProcessRecord() {
        BillingPlatformDetails outputObject = new(SiteName);
        WriteObject(outputObject);
    }
}
