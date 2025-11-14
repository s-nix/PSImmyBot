using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetReleasesResponse(
    [property: JsonPropertyName("currentRelease")]
    ReleaseDetails CurrentRelease,
    [property: JsonPropertyName("latestReleases")]
    ICollection<ReleaseDetails>? LatestReleases);
