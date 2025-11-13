using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "SendTestEmailRequest")]
public class NewSendTestEmailRequest : Cmdlet {
    [Parameter(Mandatory = true)] public required bool Enabled { get; set; }
    [Parameter(Mandatory = true)] public required bool EnableSsl { get; set; }
    [Parameter(Mandatory = false)] public string? From { get; set; }
    [Parameter(Mandatory = false)] public string? Host { get; set; }
    [Parameter(Mandatory = false)] public string? Password { get; set; }
    [Parameter(Mandatory = true)] public required int Port { get; set; }
    [Parameter(Mandatory = false)] public int? TenantId { get; set; }
    [Parameter(Mandatory = true)] public required int Timeout { get; set; }
    [Parameter(Mandatory = false)] public string? To { get; set; }
    [Parameter(Mandatory = true)] public required bool UseAuthentication { get; set; }
    [Parameter(Mandatory = false)] public string? Username { get; set; }

    protected override void ProcessRecord() {
        SendTestEmailRequest outputObject = new(Enabled, EnableSsl, From, Host, Password, Port, TenantId, Timeout, To, UseAuthentication, Username);
        WriteObject(outputObject);
    }
}
