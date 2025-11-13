using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "SubmitFeedbackRequestBodyRequest")]
public class SendSubmitFeedbackRequestBodyRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required SubmitFeedbackRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/users/submit-feedback?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
    }

}
