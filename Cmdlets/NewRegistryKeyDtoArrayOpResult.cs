using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "RegistryKeyDtoArrayOpResult")]
public class NewRegistryKeyDtoArrayOpResult : Cmdlet {
    [Parameter(Mandatory = true)] public required DateTimeOffset DateCreatedUtc { get; set; }
    [Parameter(Mandatory = true)] public required bool IsSuccess { get; set; }
    [Parameter(Mandatory = false)] public string? Reason { get; set; }
    [Parameter(Mandatory = false)] public ICollection<RegistryKeyDto>? Value { get; set; }

    protected override void ProcessRecord() {
        RegistryKeyDtoArrayOpResult outputObject = new(DateCreatedUtc, IsSuccess, Reason, Value);
        WriteObject(outputObject);
    }
}
