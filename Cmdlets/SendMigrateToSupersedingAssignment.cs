using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "MigrateToSupersedingAssignment")]
public class SendMigrateToSupersedingAssignment : Cmdlet
{
    [Parameter(Mandatory = true)]
    public required MigrateToSupersedingAssignmentRequest PayloadBody { get; set; }

    protected override void ProcessRecord()
    {
        string endpoint = "/api/v1/target-assignments/migrate-to-superseding-assignment?";
        Int32OpResult response = ImmyBotApiService
            .Post<MigrateToSupersedingAssignmentRequest, Int32OpResult>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody)
            .GetAwaiter()
            .GetResult();
        WriteObject(response);
    }
}
