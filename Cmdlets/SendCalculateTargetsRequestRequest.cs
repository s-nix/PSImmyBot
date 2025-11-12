using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "CalculateTargetsRequestRequest")]
public class SendCalculateTargetsRequestRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required CalculateTargetsRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/target-assignments/persons-target-preview?";

        List<TargetedPerson> response = ImmyBotApiService.Post<CalculateTargetsRequest, List<TargetedPerson>>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
