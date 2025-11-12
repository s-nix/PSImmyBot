using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "TargetAssignmentsMigrateDeploymentsToProviderLinksRequest")]
public class SendTargetAssignmentsMigrateDeploymentsToProviderLinksRequest : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/target-assignments/migrate-deployments-to-provider-links?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
