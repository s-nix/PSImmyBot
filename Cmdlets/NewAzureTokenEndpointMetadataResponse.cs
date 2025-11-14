using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "AzureTokenEndpointMetadataResponse")]
public class NewAzureTokenEndpointMetadataResponse : Cmdlet {


    protected override void ProcessRecord() {
        AzureTokenEndpointMetadataResponse outputObject = new();
        WriteObject(outputObject);
    }
}
