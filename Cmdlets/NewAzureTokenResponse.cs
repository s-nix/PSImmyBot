using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "AzureTokenResponse")]
public class NewAzureTokenResponse : Cmdlet {


    protected override void ProcessRecord() {
        AzureTokenResponse outputObject = new();
        WriteObject(outputObject);
    }
}
