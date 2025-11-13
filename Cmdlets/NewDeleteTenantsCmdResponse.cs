using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "DeleteTenantsCmdResponse")]
public class NewDeleteTenantsCmdResponse : Cmdlet {
    [Parameter(Mandatory = false)] public string? Message { get; set; }
    [Parameter(Mandatory = true)] public required bool Success { get; set; }
    [Parameter(Mandatory = false)] public ICollection<DeleteTenantResult>? TenantResults { get; set; }

    protected override void ProcessRecord() {
        DeleteTenantsCmdResponse outputObject = new(Message, Success, TenantResults);
        WriteObject(outputObject);
    }
}
