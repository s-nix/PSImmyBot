using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetScriptVariablesAndParametersResponse")]
public class NewGetScriptVariablesAndParametersResponse : Cmdlet {
    [Parameter(Mandatory = false)] public IDictionary<string, object?>? Parameters { get; set; }
    [Parameter(Mandatory = false)] public IDictionary<string, object?>? Variables { get; set; }

    protected override void ProcessRecord() {
        GetScriptVariablesAndParametersResponse outputObject = new(Parameters, Variables);
        WriteObject(outputObject);
    }
}
