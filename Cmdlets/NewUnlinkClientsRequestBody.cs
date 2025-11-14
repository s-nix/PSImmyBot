using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "UnlinkClientsRequestBody")]
public class NewUnlinkClientsRequestBody : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<string>? ClientIds { get; set; }

    protected override void ProcessRecord() {
        UnlinkClientsRequestBody outputObject = new(ClientIds);
        WriteObject(outputObject);
    }
}
