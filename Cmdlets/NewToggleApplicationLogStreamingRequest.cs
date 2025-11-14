using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ToggleApplicationLogStreamingRequest")]
public class NewToggleApplicationLogStreamingRequest : Cmdlet {
    [Parameter(Mandatory = true)] public required bool Enabled { get; set; }

    protected override void ProcessRecord() {
        ToggleApplicationLogStreamingRequest outputObject = new(Enabled);
        WriteObject(outputObject);
    }
}
