using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "IntegrationBindParametersRequest")]
public class NewIntegrationBindParametersRequest : Cmdlet {
    [Parameter(Mandatory = false)] public IDictionary<string, ParameterValue>? ParameterValues { get; set; }
    [Parameter(Mandatory = false)] public int? ProviderLinkId { get; set; }

    protected override void ProcessRecord() {
        IntegrationBindParametersRequest outputObject = new(ParameterValues, ProviderLinkId);
        WriteObject(outputObject);
    }
}
