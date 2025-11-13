using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "TestIntegrationMethodRequest")]
public class NewTestIntegrationMethodRequest : Cmdlet {
    [Parameter(Mandatory = true)] public required object ProviderTypeFormData { get; set; }

    protected override void ProcessRecord() {
        TestIntegrationMethodRequest outputObject = new(ProviderTypeFormData);
        WriteObject(outputObject);
    }
}
