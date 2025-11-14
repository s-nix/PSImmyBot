using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Remove", "UsersBulkDelete")]
public class RemoveUsersBulkDelete : Cmdlet {
    [Parameter(Mandatory = false)]
    public object? UserIds { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/users/bulk-delete?";
        endpoint += Globals.ConvertToQueryParameters(UserIds, "userIds");

        ImmyBotApiService.Delete(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }
}
