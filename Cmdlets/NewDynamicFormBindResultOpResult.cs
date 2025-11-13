using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "DynamicFormBindResultOpResult")]
public class NewDynamicFormBindResultOpResult : Cmdlet {
    [Parameter(Mandatory = true)] public required DateTimeOffset DateCreatedUtc { get; set; }
    [Parameter(Mandatory = true)] public required bool IsSuccess { get; set; }
    [Parameter(Mandatory = false)] public string? Reason { get; set; }
    [Parameter(Mandatory = true)] public required DynamicFormBindResult Value { get; set; }

    protected override void ProcessRecord() {
        DynamicFormBindResultOpResult outputObject = new(DateCreatedUtc, IsSuccess, Reason, Value);
        WriteObject(outputObject);
    }
}
