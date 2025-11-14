using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "ParentTenantInfo")]
public class GetParentTenantInfo : Cmdlet {
    [Parameter(Mandatory = true)]
    public int ComputerId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/computers/{ComputerId}/parent-tenant-info?";

        ParentTenantInfo response = ImmyBotApiService.Get<ParentTenantInfo>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
