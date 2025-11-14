using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetIpAddressesResponse")]
public class NewGetIpAddressesResponse : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<string>? IpAddresses { get; set; }
    [Parameter(Mandatory = false)] public string? Message { get; set; }
    [Parameter(Mandatory = true)] public required bool Success { get; set; }

    protected override void ProcessRecord() {
        GetIpAddressesResponse outputObject = new(IpAddresses, Message, Success);
        WriteObject(outputObject);
    }
}
