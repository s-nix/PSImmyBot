using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "AzureTenantCustomerICollectionAzureErrorOneOf")]
public class NewAzureTenantCustomerICollectionAzureErrorOneOf : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<AzureTenantCustomer>? AsT0 { get; set; }
    [Parameter(Mandatory = true)] public required AzureError AsT1 { get; set; }
    [Parameter(Mandatory = true)] public required int Index { get; set; }
    [Parameter(Mandatory = true)] public required bool IsT0 { get; set; }
    [Parameter(Mandatory = true)] public required bool IsT1 { get; set; }
    [Parameter(Mandatory = false)] public object? Value { get; set; }

    protected override void ProcessRecord() {
        AzureTenantCustomerICollectionAzureErrorOneOf outputObject = new(AsT0, AsT1, Index, IsT0, IsT1, Value);
        WriteObject(outputObject);
    }
}
