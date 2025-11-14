using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "RegistryPayload")]
public class NewRegistryPayload : Cmdlet {
    [Parameter(Mandatory = false)] public string? KeyPath { get; set; }

    protected override void ProcessRecord() {
        RegistryPayload outputObject = new(KeyPath);
        WriteObject(outputObject);
    }
}
