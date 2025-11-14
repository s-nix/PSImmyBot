using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetFunctionSyntaxRequest")]
public class NewGetFunctionSyntaxRequest : Cmdlet {
    [Parameter(Mandatory = false)] public string? FunctionName { get; set; }

    protected override void ProcessRecord() {
        GetFunctionSyntaxRequest outputObject = new(FunctionName);
        WriteObject(outputObject);
    }
}
