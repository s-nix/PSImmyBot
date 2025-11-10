using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record SoftwareFileUploadData(
    [property: JsonPropertyName("fileBlobName")]
    string? FileBlobName,
    [property: JsonPropertyName("installerFile")]
    string? InstallerFile,
    [property: JsonPropertyName("installerType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<SoftwareVersionInstallerType>))]
    SoftwareVersionInstallerType InstallerType,
    [property: JsonPropertyName("md5Hash")]
    string? Md5Hash,
    [property: JsonPropertyName("packageType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<PackageType>))]
    PackageType PackageType,
    [property: JsonPropertyName("relativeCacheSourcePath")]
    Guid RelativeCacheSourcePath);
