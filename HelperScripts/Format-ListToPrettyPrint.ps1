function Format-ListToPrettyPrint {
  [CmdletBinding()]
  param (
    [Parameter(Mandatory = $true)]
    [string[]]$Strings,
    [Parameter(Mandatory = $false)]
    [int]$Columns = 3,
    [Parameter(Mandatory = $false)]
    [switch]$IncludeDoubleQuotes,
    [Parameter(Mandatory = $false)]
    [switch]$IncludeCommas
  )

  process {
    $maxLength = ($Strings | ForEach-Object { $_.Length } | Measure-Object -Maximum).Maximum
    $columnWidth = $maxLength + 2
    if ($IncludeDoubleQuotes) {
      $columnWidth += 2
    }
    if ($IncludeCommas) {
      $columnWidth += 1
    }
    # Create a format string to left-align each column with appropriate width for pretty printing
    $formatString = "{0,-$columnWidth}"

    for ($i = 0; $i -lt $Strings.Count; $i += $Columns) {
      $line = ""
      for ($j = 0; $j -lt $Columns; $j++) {
        if ($i + $j -lt $Strings.Count) {
          $item = $Strings[$i + $j]
          if ($IncludeDoubleQuotes) {
            $item = '"' + $item + '"'
          }
          if ($IncludeCommas) {
            $item += ","
          }
          $line += $formatString -f $item
        }
      }
      Write-Output $line.TrimEnd()
    }
  }
}

Format-ListToPrettyPrint -Strings @(
  "Connect-Api", "Disconnect-Api", "Get-AccessRequestResponse", "Get-ApiConnectionConfig", "Get-ApplicationLocksResponse", "Get-AppRegistrationOption", "Get-Audit", "Get-AzureErrorLogItem", "Get-AzureTenantAuthDetails", "Get-AzureTenantCustomersResult", "Get-BillingPlatformDetails", "Get-ChangeRequestDiff", "Get-ChangeRequestResponse", "Get-ChangeRequestsOpenCount", "Get-ChocoPackageVersion", "Get-ChocoSearchResult", "Get-CircuitBreakerState", "Get-ComputerAgentStatusDto", "Get-ComputerInventoryAllSoftware", "Get-ComputerInventorySoftware", "Get-ComputerNameResponse", "Get-ComputerPageResponse", "Get-ComputerSearch", "Get-ComputersExport", "Get-ComputersInventoryExport", "Get-ComputersInventoryScriptResults", "Get-ComputersProviderLinksScreenShareUrl", "Get-ComputersStatus", "Get-ComputersUserAffinitiesExport", "Get-ComputerUserAffinityResponse", "Get-DetectedComputerSoftwareResponse", "Get-DisabledPreflightScriptResponse", "Get-DxComputerInventoryScriptResult", "Get-DynamicIntegrationTypeResponse", "Get-EphemeralSession", "Get-EphemeralSessionDevelopmentLatestEphemeralBinary", "Get-GetAgentSha256HashResponse", "Get-GetAuthResponse", "Get-GetAzureGroupResponse", "Get-GetBrandingResponse", "Get-GetClaimsResponse", "Get-GetCommandResult", "Get-GetComputerDeviceUpdateFormDataResponse", "Get-GetComputerResponse", "Get-GetEphemeralAgentResponse", "Get-GetFailedPendingAgentResponse", "Get-GetGlobalMaintenanceTaskResponse", "Get-GetGlobalScriptResponse", "Get-GetGlobalSoftwareResponse", "Get-GetGlobalSoftwareVersionResponse", "Get-GetLatestActionForComputer", "Get-GetLicenseResponse", "Get-GetLocalMaintenanceTaskResponse", "Get-GetLocalScriptResponse", "Get-GetLocalSoftwareResponse", "Get-GetLocalSoftwareVersionResponse", "Get-GetMaintenanceActionResponse", "Get-GetMaintenanceSessionLogResponse", "Get-GetMaintenanceSessionPhaseResponse", "Get-GetMaintenanceSessionResponse", "Get-GetOnboardingComputerResponse", "Get-GetOptionalTargetAssignmentApprovalResponse", "Get-GetPendingCountsResponse", "Get-GetPendingResponse", "Get-GetPreferencesResponse", "Get-GetProductCatalogItemsResponse", "Get-GetProviderAgentIdentificationLogResponse", "Get-GetProviderClientResponse", "Get-GetProviderLinkResponse", "Get-GetRdpInfoResponse", "Get-GetRecommendedApprovalResponse", "Get-GetReleasesResponse", "Get-GetRoleResponse", "Get-GetScheduleResponse", "Get-GetScriptNameResponse", "Get-GetSessionStatusCountsPayload", "Get-GetSimplePersonResponse", "Get-GetSmtpConfigResponse", "Get-GetSourceContextsResponse", "Get-GetSubscriptionDetailsResponse", "Get-GetSupportBrandingResponse", "Get-GetTargetAssignmentTypeResponse", "Get-GetTenantResponse", "Get-GetTenantSoftwareFromInventoryResponse", "Get-GettingStartedChecklist", "Get-GetUserResponse", "Get-GlobalMediaResponse", "Get-GlobalTargetAssignmentResource", "Get-IClientGroup", "Get-IClientStatus", "Get-IClientType", "Get-IDeviceGroup", "Get-ImmyIpAndHostnamesResponse", "Get-InventoryTaskResource", "Get-ISubjectMetadata", "Get-LicensesRequestDownload", "Get-LoadResult", "Get-LocalMediaResponse", "Get-LocalTargetAssignmentResource", "Get-MaintenanceActionsLatestForTenant", "Get-MaintenanceActionsLatestNonCompliantActionsForTenant", "Get-MaintenanceEmailsJobsNow", "Get-MaintenanceEmailsJobsPostpone", "Get-MaintenanceEmailsJobsRebootnow", "Get-MaintenanceItemOrder", "Get-MaintenanceSessionsCancel", "Get-MaintenanceSessionsCancelForSchedule", "Get-MaintenanceTaskSearchResult", "Get-MaintenanceTasksReferenceCount", "Get-MediaGlobalDownloadUrl", "Get-MediaLocalDownloadUrl", "Get-MediaSearchResponse", "Get-MetricsProviderLinks", "Get-MigrationPreviewResponse", "Get-MspInstanceImmySupportAccessGrantDetails", "Get-MyComputerResponse", "Get-Notification", "Get-Oauth2AccessTokenWithTenantNameResponse", "Get-OpResult", "Get-OpResultCircuitBreakerState", "Get-ParentTenantInfo", "Get-ProviderTypeDto", "Get-ResolveOnboardingOverridableAssignmentsResponseBody", "Get-SchedulesRunningScheduleIds", "Get-ScriptActionAuditResult", "Get-ScriptReference", "Get-ScriptReferenceCounts", "Get-ScriptSearchResult", "Get-ScriptsLanguageServiceLanguage", "Get-SoftwareGlobalVersionsRequestDownload", "Get-SoftwareLocalVersionsRequestDownload", "Get-Tags", "Get-TargetAssignmentResource", "Get-TechnicianPageInfoFromPsaTicket", "Get-TenantComputerCountResponse", "Get-TenantInfoResult", "Get-TenantPreferences", "Get-TenantsSoftwareFromInventoryExport", "Get-TimelineEvent", "Get-TimeZoneResource", "Get-UserSilencedNotificationResponse", "Get-Webhooks", "Remove-ApiConnectionConfig", "Save-ApiConnectionConfig"
) -Columns 4 -IncludeDoubleQuotes -IncludeCommas