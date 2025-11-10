namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. All = 0, Servers = 1, Workstations = 2, PortableDevices = 3, WorkstationsAndPortableDevices = 4, DomainControllers = 5, PrimaryDomainControllers = 6
/// </summary>

public enum TargetGroupFilter {

    All = 0,

    Servers = 1,

    Workstations = 2,

    PortableDevices = 3,

    WorkstationsAndPortableDevices = 4,

    DomainControllers = 5,

    PrimaryDomainControllers = 6,

}
