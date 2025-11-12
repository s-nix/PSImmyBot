using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "DataSourceLoadOptions")]
public class NewDataSourceLoadOptions : Cmdlet {
    [Parameter(Mandatory = false)] public bool AllowAsyncOverSync { get; set; }
    [Parameter(Mandatory = false)] public string? DefaultSort { get; set; }
    [Parameter(Mandatory = false)] public bool? ExpandLinqSumType { get; set; }
    [Parameter(Mandatory = false)] public ICollection<object>? Filter { get; set; }
    [Parameter(Mandatory = false)] public ICollection<GroupingInfo>? Group { get; set; }
    [Parameter(Mandatory = false)] public ICollection<SummaryInfo>? GroupSummary { get; set; }
    [Parameter(Mandatory = false)] public bool IsCountQuery { get; set; }
    [Parameter(Mandatory = false)] public bool IsSummaryQuery { get; set; }
    [Parameter(Mandatory = false)] public bool? PaginateViaPrimaryKey { get; set; }
    [Parameter(Mandatory = false)] public ICollection<string>? PreSelect { get; set; }
    [Parameter(Mandatory = false)] public ICollection<string>? PrimaryKey { get; set; }
    [Parameter(Mandatory = false)] public bool? RemoteGrouping { get; set; }
    [Parameter(Mandatory = false)] public bool? RemoteSelect { get; set; }
    [Parameter(Mandatory = false)] public bool RequireGroupCount { get; set; }
    [Parameter(Mandatory = false)] public bool RequireTotalCount { get; set; }
    [Parameter(Mandatory = false)] public ICollection<string>? Select { get; set; }
    [Parameter(Mandatory = false)] public int Skip { get; set; }
    [Parameter(Mandatory = false)] public ICollection<SortingInfo>? Sort { get; set; }
    [Parameter(Mandatory = false)] public bool? SortByPrimaryKey { get; set; }
    [Parameter(Mandatory = false)] public bool? StringToLower { get; set; }
    [Parameter(Mandatory = false)] public int Take { get; set; }
    [Parameter(Mandatory = false)] public ICollection<SummaryInfo>? TotalSummary { get; set; }

    protected override void ProcessRecord() {
        DataSourceLoadOptions loadOptions = new(
            AllowAsyncOverSync,
            DefaultSort,
            ExpandLinqSumType,
            Filter,
            Group,
            GroupSummary,
            IsCountQuery,
            IsSummaryQuery,
            PaginateViaPrimaryKey,
            PreSelect,
            PrimaryKey,
            RemoteGrouping,
            RemoteSelect,
            RequireGroupCount,
            RequireTotalCount,
            Select,
            Skip,
            Sort,
            SortByPrimaryKey,
            StringToLower,
            Take,
            TotalSummary
        );

        WriteObject(loadOptions);
    }
}
