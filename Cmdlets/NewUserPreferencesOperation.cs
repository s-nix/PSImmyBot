using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "UserPreferencesOperation")]
public class NewUserPreferencesOperation : Cmdlet {
    [Parameter(Mandatory = false)] public string? From { get; set; }
    [Parameter(Mandatory = false)] public string? Op { get; set; }
    [Parameter(Mandatory = true)] public required OperationType OperationType { get; set; }
    [Parameter(Mandatory = false)] public string? Path { get; set; }
    [Parameter(Mandatory = false)] public object? Value { get; set; }

    protected override void ProcessRecord() {
        UserPreferencesOperation outputObject = new(From, Op, OperationType, Path, Value);
        WriteObject(outputObject);
    }
}
