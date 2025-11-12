using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "AddChangeRequestCommentBodyRequest")]
public class SendAddChangeRequestCommentBodyRequest : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }


    [Parameter(Mandatory = true)] public required AddChangeRequestCommentBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/change-requests/{Id}/comment?";

        ChangeRequestCommentResponse response = ImmyBotApiService.Post<AddChangeRequestCommentBody, ChangeRequestCommentResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
