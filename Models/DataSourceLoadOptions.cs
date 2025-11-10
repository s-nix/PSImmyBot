using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record DataSourceLoadOptions(
    [property: JsonPropertyName("allowAsyncOverSync")]
    bool AllowAsyncOverSync,
    [property: JsonPropertyName("defaultSort")]
    string? DefaultSort,
    [property: JsonPropertyName("expandLinqSumType")]
    bool? ExpandLinqSumType,
    [property: JsonPropertyName("filter")] ICollection<object>? Filter,
    [property: JsonPropertyName("group")] ICollection<GroupingInfo>? Group,
    [property: JsonPropertyName("groupSummary")]
    ICollection<SummaryInfo>? GroupSummary,
    [property: JsonPropertyName("isCountQuery")]
    bool IsCountQuery,
    [property: JsonPropertyName("isSummaryQuery")]
    bool IsSummaryQuery,
    [property: JsonPropertyName("paginateViaPrimaryKey")]
    bool? PaginateViaPrimaryKey,
    [property: JsonPropertyName("preSelect")]
    ICollection<string>? PreSelect,
    [property: JsonPropertyName("primaryKey")]
    ICollection<string>? PrimaryKey,
    [property: JsonPropertyName("remoteGrouping")]
    bool? RemoteGrouping,
    [property: JsonPropertyName("remoteSelect")]
    bool? RemoteSelect,
    [property: JsonPropertyName("requireGroupCount")]
    bool RequireGroupCount,
    [property: JsonPropertyName("requireTotalCount")]
    bool RequireTotalCount,
    [property: JsonPropertyName("select")] ICollection<string>? Select,
    [property: JsonPropertyName("skip")] int Skip,
    [property: JsonPropertyName("sort")] ICollection<SortingInfo>? Sort,
    [property: JsonPropertyName("sortByPrimaryKey")]
    bool? SortByPrimaryKey,
    [property: JsonPropertyName("stringToLower")]
    bool? StringToLower,
    [property: JsonPropertyName("take")] int Take,
    [property: JsonPropertyName("totalSummary")]
    ICollection<SummaryInfo>? TotalSummary);
