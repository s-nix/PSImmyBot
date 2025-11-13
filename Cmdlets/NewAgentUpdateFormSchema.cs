using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "AgentUpdateFormSchema")]
public class NewAgentUpdateFormSchema : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<AgentUpdateFormSchemaInput>? Inputs { get; set; }

    protected override void ProcessRecord() {
        AgentUpdateFormSchema outputObject = new(Inputs);
        WriteObject(outputObject);
    }
}
