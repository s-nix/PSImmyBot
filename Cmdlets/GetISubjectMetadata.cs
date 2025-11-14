using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "ISubjectMetadata")]
public class GetISubjectMetadata : Cmdlet {

    protected override void ProcessRecord() {
        string endpoint = "/api/v1/roles/permissions?";

        List<ISubjectMetadata> response = ImmyBotApiService.Get<List<ISubjectMetadata>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
