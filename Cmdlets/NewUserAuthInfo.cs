using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "UserAuthInfo")]
public class NewUserAuthInfo : Cmdlet {
    [Parameter(Mandatory = true)] public required DateTimeOffset ExpirationDate { get; set; }
    [Parameter(Mandatory = true)] public required long ExpirationSecondsSinceEpoch { get; set; }
    [Parameter(Mandatory = false)] public string? UserDisplayName { get; set; }
    [Parameter(Mandatory = false)] public string? UserEmailAddress { get; set; }

    protected override void ProcessRecord() {
        UserAuthInfo outputObject = new(ExpirationDate, ExpirationSecondsSinceEpoch, UserDisplayName, UserEmailAddress);
        WriteObject(outputObject);
    }
}
