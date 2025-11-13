using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "DefaultEmailBccList")]
public class NewDefaultEmailBccList : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<string>? Emails { get; set; }

    protected override void ProcessRecord() {
        DefaultEmailBccList outputObject = new(Emails);
        WriteObject(outputObject);
    }
}
