namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. DetectInstalledAgentVersion = 0, UpdateAgentVersion = 1, VerifyAgentVersionUpdated = 2, DetectInstalledVersion = 200, DetermineDesiredVersion = 201, TestSoftware = 202, CheckForSoftwareLicense = 203, AddConfigTask = 204, TestTask = 205, MonitorTask = 206, AuditTask = 207, FetchDesiredVersion = 301, EnforceTask = 302, ApplyWindowsPatch = 305, DownloadConfigTaskFiles = 306, FetchDependentVersion = 307, InstallDependentVersion = 308, InstallSoftware = 309, RunUpgradeSoftwareScript = 310, UninstallSoftware = 311, RepairSoftware = 313, DownloadInstaller = 314, PostUninstallSoftware = 315, PostInstallSoftware = 316, TestTaskBeforeExecution = 317, TestSoftwareAfterExecution = 318, VerifyTask = 319, VerifySoftwareIsInDesiredState = 320
/// </summary>

public enum ActionProgressPhaseName {

    DetectInstalledAgentVersion = 0,

    UpdateAgentVersion = 1,

    VerifyAgentVersionUpdated = 2,

    DetectInstalledVersion = 3,

    DetermineDesiredVersion = 4,

    TestSoftware = 5,

    CheckForSoftwareLicense = 6,

    AddConfigTask = 7,

    TestTask = 8,

    MonitorTask = 9,

    AuditTask = 10,

    FetchDesiredVersion = 11,

    EnforceTask = 12,

    ApplyWindowsPatch = 13,

    DownloadConfigTaskFiles = 14,

    FetchDependentVersion = 15,

    InstallDependentVersion = 16,

    InstallSoftware = 17,

    RunUpgradeSoftwareScript = 18,

    UninstallSoftware = 19,

    RepairSoftware = 20,

    DownloadInstaller = 21,

    PostUninstallSoftware = 22,

    PostInstallSoftware = 23,

    TestTaskBeforeExecution = 24,

    TestSoftwareAfterExecution = 25,

    VerifyTask = 26,

    VerifySoftwareIsInDesiredState = 27,

}
