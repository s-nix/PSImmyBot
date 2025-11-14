using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetSmtpConfigResponse")]
public class NewGetSmtpConfigResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required bool Enabled { get; set; }
    [Parameter(Mandatory = true)] public required bool EnableSsl { get; set; }
    [Parameter(Mandatory = false)] public string? Host { get; set; }
    [Parameter(Mandatory = true)] public required int Port { get; set; }
    [Parameter(Mandatory = false)] public int? TenantId { get; set; }
    [Parameter(Mandatory = false)] public string? TenantName { get; set; }
    [Parameter(Mandatory = true)] public required int Timeout { get; set; }
    [Parameter(Mandatory = true)] public required bool UseAuthentication { get; set; }
    [Parameter(Mandatory = false)] public string? Username { get; set; }

    protected override void ProcessRecord() {
        GetSmtpConfigResponse outputObject = new(Enabled, EnableSsl, Host, Port, TenantId, TenantName, Timeout, UseAuthentication, Username);
        WriteObject(outputObject);
    }
}
