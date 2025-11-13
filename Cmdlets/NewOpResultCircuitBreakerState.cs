using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "OpResultCircuitBreakerState")]
public class NewOpResultCircuitBreakerState : Cmdlet {
    [Parameter(Mandatory = false)] public string? CircuitState { get; set; }
    [Parameter(Mandatory = true)] public required LastException LastException { get; set; }
    [Parameter(Mandatory = true)] public required OpResult LastResult { get; set; }
    [Parameter(Mandatory = false)] public string? PolicyName { get; set; }

    protected override void ProcessRecord() {
        OpResultCircuitBreakerState outputObject = new(CircuitState, LastException, LastResult, PolicyName);
        WriteObject(outputObject);
    }
}
