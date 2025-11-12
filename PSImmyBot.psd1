@{
    RootModule           = 'PSImmyBot.dll'
    
    ModuleVersion        = '1.0.0'
    
    CompatiblePSEditions = @('Core')
    
    GUID                 = '2d90d083-e616-4d12-b93f-21b0fd62bd57'
    
    Author               = 'Stephen Nix'
    
    CompanyName          = 'Stephen Nix'
    
    Copyright            = @"
Copyright (C) 2025 Stephen Nix.
PSImmyBot is free software: you can redistribute it and/or modify it
under the terms of the GNU General Public License as published by the
Free Software Foundation, either version 3 of the License, or
(at your option) any later version.
"@
    Description          = 'PSImmyBot is a PowerShell module that provides cmdlets for interacting with the ImmyBot API, allowing users to manage and automate tasks related to ImmyBot services.'
    
    PowerShellVersion    = '7.4'

    FunctionsToExport    = @()

    CmdletsToExport      = @(
        "Connect-Api", "Disconnect-Api", "Get-AccessRequestResponse", "Get-ApiConnectionConfig",
        "Get-ApplicationLocksResponse", "Get-AppRegistrationOption", "Get-Audit", "Get-AzureErrorLogItem",
        "Get-AzureTenantAuthDetails", "Get-AzureTenantCustomersResult", "Get-BillingPlatformDetails", "Get-ChangeRequestDiff",
        "Get-ChangeRequestResponse", "Get-ChangeRequestsOpenCount", "Get-ChocoPackageVersion", "Get-ChocoSearchResult",
        "Get-CircuitBreakerState", "Get-ComputerAgentStatusDto", "Get-ComputerInventoryAllSoftware", "Get-ComputerInventorySoftware",
        "Get-ComputerNameResponse", "Get-ComputerPageResponse", "Get-ComputerSearch", "Get-ComputersExport",
        "Get-ComputersInventoryExport", "Get-ComputersInventoryScriptResults", "Get-ComputersProviderLinksScreenShareUrl", "Get-ComputersStatus",
        "Get-ComputersUserAffinitiesExport", "Get-ComputerUserAffinityResponse", "Get-DetectedComputerSoftwareResponse", "Get-DisabledPreflightScriptResponse",      
        "Get-DxComputerInventoryScriptResult", "Get-DynamicIntegrationTypeResponse", "Get-EphemeralSession", "Get-EphemeralSessionDevelopmentLatestEphemeralBinary",
        "Get-GetAgentSha256HashResponse", "Get-GetAuthResponse", "Get-GetAzureGroupResponse", "Get-GetBrandingResponse",
        "Get-GetClaimsResponse", "Get-GetCommandResult", "Get-GetComputerDeviceUpdateFormDataResponse", "Get-GetComputerResponse",
        "Get-GetEphemeralAgentResponse", "Get-GetFailedPendingAgentResponse", "Get-GetGlobalMaintenanceTaskResponse", "Get-GetGlobalScriptResponse",
        "Get-GetGlobalSoftwareResponse", "Get-GetGlobalSoftwareVersionResponse", "Get-GetLatestActionForComputer", "Get-GetLicenseResponse",
        "Get-GetLocalMaintenanceTaskResponse", "Get-GetLocalScriptResponse", "Get-GetLocalSoftwareResponse", "Get-GetLocalSoftwareVersionResponse",
        "Get-GetMaintenanceActionResponse", "Get-GetMaintenanceSessionLogResponse", "Get-GetMaintenanceSessionPhaseResponse", "Get-GetMaintenanceSessionResponse",        
        "Get-GetOnboardingComputerResponse", "Get-GetOptionalTargetAssignmentApprovalResponse", "Get-GetPendingCountsResponse", "Get-GetPendingResponse",
        "Get-GetPreferencesResponse", "Get-GetProductCatalogItemsResponse", "Get-GetProviderAgentIdentificationLogResponse", "Get-GetProviderClientResponse",
        "Get-GetRoleResponse", "Get-GetScheduleResponse", "Get-GetScriptNameResponse", "Get-GetSessionStatusCountsPayload",
        "Get-GetSimplePersonResponse", "Get-GetSmtpConfigResponse", "Get-GetSourceContextsResponse", "Get-GetSubscriptionDetailsResponse",
        "Get-GetSupportBrandingResponse", "Get-GetTargetAssignmentTypeResponse", "Get-GetTenantResponse", "Get-GetTenantSoftwareFromInventoryResponse",
        "Get-GettingStartedChecklist", "Get-GetUserResponse", "Get-GlobalMediaResponse", "Get-GlobalTargetAssignmentResource",
        "Get-IClientGroup", "Get-IClientStatus", "Get-IClientType", "Get-IDeviceGroup",
        "Get-ImmyIpAndHostnamesResponse", "Get-InventoryTaskResource", "Get-ISubjectMetadata", "Get-LicensesRequestDownload",
        "Get-LoadResult", "Get-LocalMediaResponse", "Get-LocalTargetAssignmentResource", "Get-MaintenanceActionsLatestForTenant",
        "Get-MaintenanceActionsLatestNonCompliantActionsForTenant", "Get-MaintenanceEmailsJobsNow", "Get-MaintenanceEmailsJobsPostpone", "Get-MaintenanceEmailsJobsRebootnow",
        "Get-MaintenanceItemOrder", "Get-MaintenanceSessionsCancel", "Get-MaintenanceSessionsCancelForSchedule", "Get-MaintenanceTaskSearchResult",
        "Get-MaintenanceTasksReferenceCount", "Get-MediaGlobalDownloadUrl", "Get-MediaLocalDownloadUrl", "Get-MediaSearchResponse",
        "Get-MetricsProviderLinks", "Get-MigrationPreviewResponse", "Get-MspInstanceImmySupportAccessGrantDetails", "Get-MyComputerResponse",
        "Get-Notification", "Get-Oauth2AccessTokenWithTenantNameResponse", "Get-OpResult", "Get-OpResultCircuitBreakerState",
        "Get-ParentTenantInfo", "Get-ProviderTypeDto", "Get-ResolveOnboardingOverridableAssignmentsResponseBody", "Get-SchedulesRunningScheduleIds",
        "Get-ScriptActionAuditResult", "Get-ScriptReference", "Get-ScriptReferenceCounts", "Get-ScriptSearchResult",
        "Get-ScriptsLanguageServiceLanguage", "Get-SoftwareGlobalVersionsRequestDownload", "Get-SoftwareLocalVersionsRequestDownload", "Get-Tags",
        "Get-TargetAssignmentResource", "Get-TechnicianPageInfoFromPsaTicket", "Get-TenantComputerCountResponse", "Get-TenantInfoResult",
        "Get-TenantPreferences", "Get-TenantsSoftwareFromInventoryExport", "Get-TimelineEvent", "Get-TimeZoneResource",
        "Get-UserSilencedNotificationResponse", "Get-Webhooks", "Remove-ApiConnectionConfig", "Save-ApiConnectionConfig",
        "New-DataSourceLoadOptions", "New-GroupingInfo", "New-SortingInfo", "New-SumamryInfo")

    VariablesToExport    = '*'

    AliasesToExport      = @()

    PrivateData          = @{
        PSData = @{
            Tags                       = @('MSP', 'RPA', 'ImmyBot')

            LicenseUri                 = 'https://github.com/s-nix/PSImmyBot/blob/main/LICENSE'

            ProjectUri                 = 'https://github.com/s-nix/PSImmyBot'

            IconUri                    = ''

            ReleaseNotes               = ''

            Prerelease                 = ''

            RequireLicenseAcceptance   = $false

            ExternalModuleDependencies = @()
        }
    }

    # HelpInfo URI of this module
    # HelpInfoURI = ''

    DefaultCommandPrefix = 'Immy'
}

