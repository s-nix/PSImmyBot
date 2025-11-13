using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "SmtpConfig")]
public class NewSmtpConfig : Cmdlet {
    [Parameter(Mandatory = true)] public required bool Enabled { get; set; }
    [Parameter(Mandatory = true)] public required bool EnableSsl { get; set; }
    [Parameter(Mandatory = false)] public string? Host { get; set; }
    [Parameter(Mandatory = true)] public required Tenant OwnerTenant { get; set; }
    [Parameter(Mandatory = false)] public string? PasswordHash { get; set; }
    [Parameter(Mandatory = true)] public required int Port { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }
    [Parameter(Mandatory = true)] public required int Timeout { get; set; }
    [Parameter(Mandatory = true)] public required bool UseAuthentication { get; set; }
    [Parameter(Mandatory = false)] public string? Username { get; set; }

    protected override void ProcessRecord() {
        SmtpConfig outputObject = new(Enabled, EnableSsl, Host, OwnerTenant, PasswordHash, Port, TenantId, Timeout, UseAuthentication, Username);
        WriteObject(outputObject);
    }
}
