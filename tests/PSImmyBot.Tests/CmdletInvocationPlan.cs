using System.Collections.Generic;
using System.Management.Automation;

namespace PSImmyBot.Tests;

internal sealed record CmdletInvocationPlan(
    string CommandName,
    string? ParameterSetName,
    IReadOnlyDictionary<string, object> Parameters,
    Type CmdletType,
    IReadOnlyCollection<string> Artifacts
);
