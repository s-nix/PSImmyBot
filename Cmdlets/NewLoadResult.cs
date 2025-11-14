using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "LoadResult")]
public class NewLoadResult : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<object>? Data { get; set; }
    [Parameter(Mandatory = true)] public required int GroupCount { get; set; }
    [Parameter(Mandatory = false)] public ICollection<object>? Summary { get; set; }
    [Parameter(Mandatory = true)] public required int TotalCount { get; set; }

    protected override void ProcessRecord() {
        LoadResult outputObject = new(Data, GroupCount, Summary, TotalCount);
        WriteObject(outputObject);
    }
}
