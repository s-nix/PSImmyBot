using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ImmyIpAndHostnamesResponse")]
public class NewImmyIpAndHostnamesResponse : Cmdlet {
    [Parameter(Mandatory = false)] public string? GlobalBlobStorageEndpoint { get; set; }
    [Parameter(Mandatory = true)] public required GetIpAddressesResponse IpInfo { get; set; }
    [Parameter(Mandatory = false)] public string? LocalBlobStorageEndpoint { get; set; }

    protected override void ProcessRecord() {
        ImmyIpAndHostnamesResponse outputObject = new(GlobalBlobStorageEndpoint, IpInfo, LocalBlobStorageEndpoint);
        WriteObject(outputObject);
    }
}
