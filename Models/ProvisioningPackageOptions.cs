using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ProvisioningPackageOptions(
    [property: JsonPropertyName("disableHibernation")]
    bool DisableHibernation,
    [property: JsonPropertyName("downloadISO")]
    bool DownloadIso,
    [property: JsonPropertyName("enableCleanPC")]
    bool EnableCleanPc,
    [property: JsonPropertyName("encryptPackage")]
    bool EncryptPackage,
    [property: JsonPropertyName("hideAdminAccount")]
    bool HideAdminAccount,
    [property: JsonPropertyName("localAdminPassword")]
    string? LocalAdminPassword,
    [property: JsonPropertyName("localAdminUsername")]
    string? LocalAdminUsername,
    [property: JsonPropertyName("packagePassword")]
    string? PackagePassword,
    [property: JsonPropertyName("setupAdmin")]
    bool SetupAdmin,
    [property: JsonPropertyName("setupWireless")]
    bool SetupWireless,
    [property: JsonPropertyName("wirelessKey")]
    string? WirelessKey,
    [property: JsonPropertyName("wirelessOpen")]
    bool? WirelessOpen,
    [property: JsonPropertyName("wirelessSSID")]
    string? WirelessSsid);
