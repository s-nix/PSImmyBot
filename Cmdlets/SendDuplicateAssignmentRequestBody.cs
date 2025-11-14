using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "DuplicateAssignmentRequestBody")]
public class SendDuplicateAssignmentRequestBody : Cmdlet {

    [Parameter(Mandatory = true)] public required DuplicateAssignmentRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/target-assignments/duplicate?";

        int response = ImmyBotApiService.Post<DuplicateAssignmentRequestBody, int>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
