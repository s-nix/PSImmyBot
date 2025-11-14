using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "GetPowerShellInstallScriptParameters")]
public class SendGetPowerShellInstallScriptParameters : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }


    [Parameter(Mandatory = true)] public required GetPowerShellInstallScriptParameters PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/provider-links/{Id}/agents/powershell-install-script?";

        IScript response = ImmyBotApiService.Post<GetPowerShellInstallScriptParameters, IScript>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
