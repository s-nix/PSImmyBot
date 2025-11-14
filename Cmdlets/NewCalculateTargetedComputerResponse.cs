using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "CalculateTargetedComputerResponse")]
public class NewCalculateTargetedComputerResponse : Cmdlet {
    [Parameter(Mandatory = false)] public string? Cn { get; set; }
    [Parameter(Mandatory = false)] public ICollection<int>? Ct { get; set; }
    [Parameter(Mandatory = false)] public int? Dr { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required ComputerOnboardingStatus Obs { get; set; }
    [Parameter(Mandatory = true)] public required bool On { get; set; }
    [Parameter(Mandatory = false)] public string? Os { get; set; }
    [Parameter(Mandatory = false)] public int? Ppi { get; set; }
    [Parameter(Mandatory = false)] public string? Ppn { get; set; }
    [Parameter(Mandatory = true)] public required bool Sb { get; set; }
    [Parameter(Mandatory = false)] public string? Sn { get; set; }
    [Parameter(Mandatory = true)] public required int Ti { get; set; }
    [Parameter(Mandatory = false)] public string? Tn { get; set; }

    protected override void ProcessRecord() {
        CalculateTargetedComputerResponse outputObject = new(Cn, Ct, Dr, Id, Obs, On, Os, Ppi, Ppn, Sb, Sn, Ti, Tn);
        WriteObject(outputObject);
    }
}
