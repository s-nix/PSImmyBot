using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ICustomAttributeProvider")]
public class NewICustomAttributeProvider : Cmdlet {


    protected override void ProcessRecord() {
        ICustomAttributeProvider outputObject = new();
        WriteObject(outputObject);
    }
}
