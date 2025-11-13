using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "UserImpersonation")]
public class NewUserImpersonation : Cmdlet {
    [Parameter(Mandatory = true)] public required DateTimeOffset ExpiresAtUtc { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required User ImpersonatingUser { get; set; }
    [Parameter(Mandatory = true)] public required int ImpersonatingUserId { get; set; }
    [Parameter(Mandatory = true)] public required User ImpersonatorUser { get; set; }
    [Parameter(Mandatory = true)] public required int ImpersonatorUserId { get; set; }

    protected override void ProcessRecord() {
        UserImpersonation outputObject = new(ExpiresAtUtc, Id, ImpersonatingUser, ImpersonatingUserId, ImpersonatorUser, ImpersonatorUserId);
        WriteObject(outputObject);
    }
}
