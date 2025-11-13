using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "MigrateToSupersedingAssignmentRequest")]
public class SendMigrateToSupersedingAssignmentRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required MigrateToSupersedingAssignmentRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/target-assignments/migrate-to-superseding-assignment-what-if?";

        MigrateToSupersedingAssignmentWhatIfResponseOpResult response = ImmyBotApiService.Post<MigrateToSupersedingAssignmentRequest, MigrateToSupersedingAssignmentWhatIfResponseOpResult>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
