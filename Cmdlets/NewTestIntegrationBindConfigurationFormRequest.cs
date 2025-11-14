using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "TestIntegrationBindConfigurationFormRequest")]
public class NewTestIntegrationBindConfigurationFormRequest : Cmdlet {
    [Parameter(Mandatory = false)] public IDictionary<string, ParameterValue>? ParameterValues { get; set; }

    protected override void ProcessRecord() {
        TestIntegrationBindConfigurationFormRequest outputObject = new(ParameterValues);
        WriteObject(outputObject);
    }
}
