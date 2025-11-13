using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "CircuitBreakerState")]
public class NewCircuitBreakerState : Cmdlet {
    [Parameter(Mandatory = false)] public string? CircuitState { get; set; }
    [Parameter(Mandatory = true)] public required LastException LastException { get; set; }
    [Parameter(Mandatory = false)] public string? PolicyName { get; set; }

    protected override void ProcessRecord() {
        CircuitBreakerState outputObject = new(CircuitState, LastException, PolicyName);
        WriteObject(outputObject);
    }
}
