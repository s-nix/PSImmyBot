namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. All = 1, Computer = 2, Metascript = 5, Person = 7, AzureGroup = 8, TenantMetascript = 20, AllForTenant = 21, ProviderDeviceGroup = 22, ProviderClientGroup = 23, TenantFilterScript = 24, FilterScript = 25, AllTenants = 28, SpecificTenant = 29, Tag = 30, TenantTag = 31, CloudTag = 40, CloudProviderClientGroup = 42
/// </summary>

public enum TargetType {

    All = 0,

    Computer = 1,

    Metascript = 2,

    Person = 3,

    AzureGroup = 4,

    TenantMetascript = 5,

    AllForTenant = 6,

    ProviderDeviceGroup = 7,

    ProviderClientGroup = 8,

    TenantFilterScript = 9,

    FilterScript = 10,

    AllTenants = 11,

    SpecificTenant = 12,

    Tag = 13,

    TenantTag = 14,

    CloudTag = 15,

    CloudProviderClientGroup = 16,

}
