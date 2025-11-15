@{
    RootModule           = 'PSImmyBot.dll'
    
    ModuleVersion        = '0.0.1'
    
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
        "Connect-Api", "Disconnect-Api", "Get-AccessRequest", "Get-AgentSha256Hash",
        "Get-ApiConnectionConfig", "Get-ApplicationLocks", "Get-AppRegistrationOptions", "Get-AuditLocal", "Get-AuditGlobal"
        "Get-Auth", "Get-AzureErrorLogItems", "Get-AzureGroup", "Get-AzureTenantAuthDetails",
        "Get-AzureTenantCustomers", "Get-BillingPlatformDetails", "Get-Branding", "Get-BrandingById", "Get-ChangeRequest", "Get-ChangeRequestByDeployment",
        "Get-ChangeRequestDiff", "Get-ChangeRequestsOpenCount", "Get-ChocoPackageVersion", "Get-ChocoSearchResult",
        "Get-CircuitBreakerState", "Get-Claims", "Get-CommandResult", "Get-Computer",
        "Get-ComputerAgentStatusDto", "Get-ComputerDeviceUpdateFormData", "Get-ComputerInventory", "Get-ComputerInventoryAllSoftware",
        "Get-ComputerInventorySoftware", "Get-ComputerSearch", "Get-ComputersExport", "Get-ComputersInventoryExport",
        "Get-ComputersInventoryScriptResults", "Get-ComputersPaged", "Get-ComputersProviderLinksScreenShareUrl", "Get-ComputerStatus",
        "Get-ComputersUserAffinitiesExport", "Get-ComputerUserAffinities", "Get-DetectedComputerSoftware", "Get-DetectedComputerSoftwareByComputer", "Get-DisabledPreflightScripts",
        "Get-DynamicIntegrationType", "Get-EphemeralAgent", "Get-EphemeralSessionBinary", "Get-EphemeralSessionDevelopmentBinary",
        "Get-FailedPendingAgent", "Get-GlobalMaintenanceTask", "Get-GlobalMediaResponse", "Get-GlobalScript",
        "Get-GlobalSoftware", "Get-GlobalSoftwareVersion", "Get-GlobalTargetAssignmentResource", "Get-IClientGroup",
        "Get-IClientStatus", "Get-IClientType", "Get-IDeviceGroup", "Get-InventoryTaskResource",
        "Get-IpAndHostnames", "Get-ISubjectMetadata", "Get-LatestActionForComputer", "Get-License",
        "Get-LicensesRequestDownload", "Get-LoadResult", "Get-LocalMaintenanceTask", "Get-LocalMediaResponse",
        "Get-LocalScript", "Get-LocalSoftware", "Get-LocalSoftwareVersion", "Get-LocalTargetAssignmentResource",
        "Get-MaintenanceAction", "Get-MaintenanceActionsLatestForTenant", "Get-MaintenanceActionsLatestNonCompliantActionsForTenant", "Get-MaintenanceEmailsJobsNow",
        "Get-MaintenanceEmailsJobsPostpone", "Get-MaintenanceEmailsJobsRebootnow", "Get-MaintenanceExcludedComputers", "Get-MaintenanceItemOrder",
        "Get-MaintenanceSession", "Get-MaintenanceSessionLog", "Get-MaintenanceSessionPhase", "Get-MaintenanceSessionsCancel",
        "Get-MaintenanceSessionsCancelForSchedule", "Get-MaintenanceTaskSearchResult", "Get-MaintenanceTasksReferenceCount", "Get-MediaGlobalDownloadUrl",
        "Get-MediaLocalDownloadUrl", "Get-MediaSearchResponse", "Get-MetricsProviderLinks", "Get-MigrationPreviewResponse",
        "Get-MspInstanceImmySupportAccessGrantDetails", "Get-MyComputerResponse", "Get-Notification", "Get-Oauth2AccessTokenWithTenantNameResponse",
        "Get-OnboardingComputer", "Get-OpResult", "Get-OpResultCircuitBreakerState", "Get-OptionalTargetAssignmentApproval",
        "Get-ParentTenantInfo", "Get-Pending", "Get-PendingCounts", "Get-Preferences",
        "Get-ProductCatalogItems", "Get-ProviderAgentIdentificationLog", "Get-ProviderClient", "Get-ProviderLink",
        "Get-ProviderTypeDto", "Get-RdpInfo", "Get-RecommendedApproval", "Get-Releases",
        "Get-ResolveOnboardingOverridableAssignmentsResponseBody", "Get-Role", "Get-Schedule", "Get-SchedulesRunningScheduleIds",
        "Get-ScriptActionAuditResult", "Get-ScriptName", "Get-ScriptReference", "Get-ScriptReferenceCounts",
        "Get-ScriptSearchResult", "Get-ScriptsLanguageServiceLanguage", "Get-SessionStatusCountsPayload", "Get-SimplePerson",
        "Get-SmtpConfig", "Get-SoftwareGlobalVersionsRequestDownload", "Get-SoftwareLocalVersionsRequestDownload", "Get-SourceContexts",
        "Get-SubscriptionDetails", "Get-SupportBranding", "Get-Tags", "Get-TargetAssignmentResource",
        "Get-TargetAssignmentType", "Get-TechnicianPageInfoFromPsaTicket", "Get-Tenant", "Get-TenantComputerCountResponse",
        "Get-TenantInfoResult", "Get-TenantPreferences", "Get-TenantSoftwareFromInventory", "Get-TenantsSoftwareFromInventoryExport",
        "Get-TimelineEvent", "Get-TimeZoneResource", "Get-GetGettingStartedChecklist", "Get-User",
        "Get-UserSilencedNotificationResponse", "Get-Webhooks", "New-AccessRequest", "New-AccessRequestResponse",
        "New-AcknowledgeNotificationsRequest", "New-ActiveSession", "New-AddChangeRequestCommentBody", "New-AddTagsRequest",
        "New-AgentIdentificationFailure", "New-AgentIdentificationLog", "New-AgentInstallationDetails", "New-AgentOnboardingOptions",
        "New-AgentStartupInfo", "New-AgentStatusDto", "New-AgentUpdateFormSchema", "New-AgentUpdateFormSchemaInput",
        "New-AnalyzeGlobalSoftwarePackageResponse", "New-AnalyzeLocalSoftwarePackageResponse", "New-AnalyzePackageParams", "New-ApiConnectionConfig",
        "New-ApiResponseErrorContent", "New-ApplicationLockCallerInfo", "New-ApplicationLockEvent", "New-ApplicationLockEventEventStream",
        "New-ApplicationLocksResponse", "New-ApplicationPreferences", "New-ApplicationPreferencesOperation", "New-AppRegistrationOption",
        "New-Assembly", "New-Audit", "New-AuditPropertyChange", "New-AzureError",
        "New-AzureErrorLogItem", "New-AzureGdapRelationshipDetails", "New-AzureSyncResult", "New-AzureTenant",
        "New-AzureTenantAuthDetails", "New-AzureTenantConsentDetails", "New-AzureTenantCustomer", "New-AzureTenantCustomerICollectionAzureErrorOneOf",
        "New-AzureTenantCustomersResult", "New-AzureTenantDetailsSyncResult", "New-AzureTenantInfo", "New-AzureTenantInfoAzureErrorOneOf",
        "New-AzureTenantLink", "New-AzureTenantLinkDomainFilter", "New-AzureTenantLinkResponse", "New-AzureTenantResponse",
        "New-AzureTenantTokenCredentialDetails", "New-AzureTenantUserSyncResult", "New-AzureTokenEndpointMetadataResponse", "New-AzureTokenResponse",
        "New-BatchSetExcludedFromUserAffinityRequestBody", "New-BatchUpdateAssignmentRequest", "New-BeginAuthCodeFlowRequest", "New-BeginAuthCodeFlowResponse",
        "New-BillingPlatformDetails", "New-Branding", "New-BulkCreateTenantRequestBody", "New-BulkCreateTenantRequestBodyListItem",
        "New-BulkDeleteRequest", "New-BulkDeleteResponse", "New-BulkLinkClientsToTenantsRequestBody", "New-BulkScheduleOperationResult",
        "New-BulkScheduleRequest", "New-BulkScheduleStatusRequest", "New-BulkUpdateRoleRequest", "New-CalculateTargetedComputerResponse",
        "New-CalculateTargetsRequest", "New-CancelApplicationLockRequest", "New-CancelSessionsRequestBody", "New-ChangeRequest",
        "New-ChangeRequestComment", "New-ChangeRequestCommentResponse", "New-ChangeRequestDiff", "New-ChangeRequestParameterDiff",
        "New-ChangeRequestResponse", "New-ChangeTenantsPayload", "New-CheckTenantPartnerStatusResponseBody", "New-ChocoPackageVersion",
        "New-ChocoSearchResult", "New-CircuitBreakerState", "New-ClaimResponse", "New-ClearApplicationLogSourceContextRequest",
        "New-ClientGroupTypeDto", "New-CloneRoleRequest", "New-CommandResult", "New-CommandResultResponse",
        "New-Computer", "New-ComputerAgentStatusDto", "New-ComputerDto", "New-ComputerInDeploymentDto",
        "New-ComputerInventoryAllSoftware", "New-ComputerInventorySoftware", "New-ComputerInventoryTaskScriptResult", "New-ComputerLatestProviderEvent",
        "New-ComputerListViewModel", "New-ComputerNameResponse", "New-ComputerNote", "New-ComputerPageResponse",
        "New-ComputerPerson", "New-ComputerSearch", "New-ComputerTag", "New-ComputerUserAffinityResponse",
        "New-ConstructorInfo", "New-CreateBrandingRequestBody", "New-CreateDynamicIntegrationTypePayload", "New-CreateGlobalMaintenanceTaskPayload",
        "New-CreateGlobalScriptRequestBody", "New-CreateGlobalSoftwareRequestBody", "New-CreateGlobalSoftwareVersionRequestBody", "New-CreateGlobalTargetAssignmentPayload",
        "New-CreateLicenseRequestBody", "New-CreateLinkedProviderReferenceRequestBody", "New-CreateLocalMaintenanceTaskPayload", "New-CreateLocalScriptRequestBody",
        "New-CreateLocalSoftwareRequestBody", "New-CreateLocalSoftwareVersionRequestBody", "New-CreateLocalTargetAssignmentPayload", "New-CreateOrUpdateRoleRequest",
        "New-CreatePersonPayload", "New-CreateProviderLinkRequestBody", "New-CreateProviderLinkWithExternalProviderReferenceRequestBody", "New-CreateScheduleRequest",
        "New-CreateSmtpRequest", "New-CreateTagPayload", "New-CreateTenantRequestBody", "New-CreateTenantTagAuthorizationPayload",
        "New-CreateUserFromPersonRequest", "New-CustomAttributeData", "New-CustomAttributeNamedArgument", "New-CustomAttributeTypedArgument",
        "New-DataSourceLoadOptions", "New-DefaultEmailBccList", "New-DefaultScriptTimeouts", "New-DeleteAzureTenantAuthDetailsCmdPayload",
        "New-DeleteAzureTenantAuthDetailsCmdResult", "New-DeleteTenantResult", "New-DeleteTenantsCmdResponse", "New-DeploymentParameterValue",
        "New-DetectedComputerSoftware", "New-DetectedComputerSoftwareResponse", "New-DeviceDetails", "New-DeviceGroupTypeDto",
        "New-DeviceUpdateFormDataResponse", "New-DevInstanceDetails", "New-DisabledPreflightScriptResponse", "New-DisambiguateAzureTenantTypeRequestBody",
        "New-DoesScriptHaveParamBlockRequest", "New-DuplicateAssignmentRequestBody", "New-DuplicateMaintenanceTaskRequestbody", "New-DuplicateScriptRequestBody",
        "New-DuplicateTargetAssignmentPayload", "New-DxComputerInventoryScriptResult", "New-DynamicFormBindResult", "New-DynamicFormBindResultOpResult",
        "New-DynamicFormBindResultWithConvertedParameters", "New-DynamicIntegrationType", "New-DynamicIntegrationTypeProperties", "New-DynamicIntegrationTypeResponse",
        "New-EventInfo", "New-ExcludeFromMaintenanceRequest", "New-FailAuthCodeFlowRequest", "New-FastCreateGlobalVersionRequestBody",
        "New-FastCreateLocalVersionRequestBody", "New-Feature", "New-FeatureEnabledFromSubscription", "New-FeatureUsageDetails",
        "New-FieldInfo", "New-FinishAuthCodeFlowRequest", "New-GdapRelationshipAccessAssignment", "New-GdapRelationshipRole",
        "New-GetAgentIdentificationFailureResponse", "New-GetAgentSha256HashResponse", "New-GetAuthResponse", "New-GetAzureGroupResponse",
        "New-GetBashInstallScriptParameters", "New-GetBashInstallScriptParametersWithOnboardingOptions", "New-GetBrandingResponse", "New-GetClaimsResponse",
        "New-GetComputerDeviceUpdateFormDataResponse", "New-GetComputerResponse", "New-GetCustomerPortalSessionResult", "New-GetEphemeralAgentResponse",
        "New-GetExecutableUriParameters", "New-GetExecutableUriParametersWithOnboardingOptions", "New-GetFailedPendingAgentResponse", "New-GetFileDownloadUrlRequest",
        "New-GetFunctionSyntaxRequest", "New-GetGlobalMaintenanceTaskResponse", "New-GetGlobalScriptResponse", "New-GetGlobalSoftwareResponse",
        "New-GetGlobalSoftwareVersionResponse", "New-GetIpAddressesResponse", "New-LatestActionForComputer", "New-GetLatestActionForComputersRequestBody",
        "New-GetLatestActionForTenantsRequestBody", "New-GetLicenseResponse", "New-GetLocalMaintenanceTaskResponse", "New-GetLocalScriptResponse",
        "New-GetLocalSoftwareResponse", "New-GetLocalSoftwareVersionResponse", "New-GetMaintenanceActionResponse", "New-GetMaintenanceSessionLogResponse",
        "New-GetMaintenanceSessionPhaseResponse", "New-GetMaintenanceSessionResponse", "New-GetMaintenanceSessionStageResponse", "New-GetMaintenanceTaskParameterResponse",
        "New-GetOnboardingComputerResponse", "New-GetOptionalTargetAssignmentApprovalResponse", "New-GetPendingAgentResponse", "New-GetPendingCountsResponse",
        "New-GetPendingResponse", "New-GetPersonResponse", "New-GetPowerShellInstallScriptParameters", "New-GetPowerShellInstallScriptParametersWithOnboardingOptions",
        "New-GetPreferencesResponse", "New-GetProductCatalogItemsResponse", "New-GetProviderAgentIdentificationLogResponse", "New-GetProviderAgentResponse",
        "New-GetProviderClientResponse", "New-GetProviderLinkResponse", "New-GetProvisioningPackageUriParameters", "New-GetProvisioningPackageUriParametersWithOnboardingOptions",
        "New-GetRdpInfoResponse", "New-GetRecommendedApprovalResponse", "New-GetReleasesResponse", "New-GetRoleClaimResponse",
        "New-GetRoleResponse", "New-GetScheduleResponse", "New-GetScriptNameResponse", "New-GetScriptVariablesAndParametersRequest",
        "New-GetScriptVariablesAndParametersResponse", "New-GetSessionLogResponse", "New-SessionStatusCountsPayload", "New-GetSimplePersonResponse",
        "New-GetSmtpConfigResponse", "New-GetSoftwarePrerequisiteResponse", "New-GetSourceContextsResponse", "New-GetSpecifiedSoftwareResponse",
        "New-GetSubscriptionDetailsResponse", "New-GetSupportBrandingResponse", "New-GetTargetAssignmentTypeResponse", "New-GetTenantResponse",
        "New-GetTenantSoftwareFromInventoryResponse", "New-GettingStartedChecklist", "New-GetUserAffinityResponse", "New-GetUserResponse",
        "New-GlobalMediaResponse", "New-GlobalSoftware", "New-GlobalSoftwareVersion", "New-GlobalTargetAssignmentResource",
        "New-GrantAccessRequest", "New-GrantAccessRequestRbac", "New-GroupingInfo", "New-IClientGroup",
        "New-IClientStatus", "New-IClientType", "New-ICustomAttributeProvider", "New-IdentifyAgentRequest",
        "New-IDeviceGroup", "New-ImmyIpAndHostnamesResponse", "New-ImpersonationRequest", "New-Int32OpResult",
        "New-IntegrationBindParametersRequest", "New-IntPtr", "New-InventoryDeviceCmdResponse", "New-InventoryTask",
        "New-InventoryTaskPayload", "New-InventoryTaskResource", "New-InventoryTaskScript", "New-InventoryTaskScriptPayload",
        "New-InventoryTaskScriptResource", "New-IPermissionMetadata", "New-IProviderAgentDetails", "New-IScript",
        "New-IScriptDetailsBase", "New-ISubjectMetadata", "New-LastException", "New-License",
        "New-LinkClientsToTenantRequestBody", "New-LinkClientToNewTenantRequestBody", "New-LinkClientToNewTenantResponseBody", "New-LinkedExternalLink",
        "New-LoadResult", "New-LocalMaintenanceTaskTenantPayload", "New-LocalMediaResponse", "New-LocalSoftware",
        "New-LocalSoftwareVersion", "New-LocalTargetAssignmentResource", "New-MaintenanceAction", "New-MaintenanceActionActivity",
        "New-MaintenanceActionActivityResponse", "New-MaintenanceActionDependency", "New-MaintenanceAgentUpdatesConfiguration", "New-MaintenanceEmailConfiguration",
        "New-MaintenanceItem", "New-MaintenanceItemOrder", "New-MaintenanceOnboardingConfiguration", "New-MaintenanceSchedulingConfiguration",
        "New-MaintenanceSession", "New-MaintenanceSessionStage", "New-MaintenanceSpecifier", "New-MaintenanceTask",
        "New-MaintenanceTaskParameter", "New-MaintenanceTaskParameterPayload", "New-MaintenanceTaskParameterValue", "New-MaintenanceTaskParameterValueDetails",
        "New-MaintenanceTaskSearchResult", "New-Media", "New-MediaResponseBase", "New-MediaSearchResponse",
        "New-MemberInfo", "New-MergeTenantsPayload", "New-MethodBase", "New-MethodInfo",
        "New-MigrateToSupersedingAssignmentRequest", "New-MigrateToSupersedingAssignmentWhatIfResponse", "New-MigrateToSupersedingAssignmentWhatIfResponseOpResult", "New-MigrationPreviewResponse",
        "New-MigratorDataDto", "New-MissingAccessTokenDetails", "New-Module", "New-ModuleHandle",
        "New-MsalErrorDetails", "New-MspInstanceImmySupportAccessGrantDetails", "New-MyComputerResponse", "New-Notification",
        "New-NuGetVersion", "New-Oauth2AccessToken", "New-Oauth2AccessTokenErrorResponse", "New-Oauth2AccessTokenWithTenantNameResponse",
        "New-Oauth2AuthCodeErrorResponse", "New-OauthConsentData", "New-ObjectOpResult", "New-ODataErrorDetails",
        "New-OpResult", "New-OpResultCircuitBreakerState", "New-OverrideTargetAssignmentRequest", "New-Parameter",
        "New-ParameterDropdownTextValue", "New-ParameterInfo", "New-ParameterSet", "New-ParameterType",
        "New-ParameterValue", "New-ParentTenantInfo", "New-Person", "New-PersonTag",
        "New-PreconsentCustomerTenantsRequest", "New-PropertyInfo", "New-ProviderAgent", "New-ProviderClient",
        "New-ProviderClientLinkToTenantByExactNameResponse", "New-ProviderLink", "New-ProviderLinkCrossReference", "New-ProviderLinkExternalReferenceDataBody",
        "New-ProviderLinkInternalData", "New-ProviderLinkUpdate", "New-ProviderTypeDto", "New-ProvisioningPackageOptions",
        "New-RecommendedTargetAssignmentApproval", "New-RegistryKeyDto", "New-RegistryKeyDtoArrayOpResult", "New-RegistryPayload",
        "New-RegistryValueDto", "New-RegistryValueDtoArrayOpResult", "New-ReleaseChannelUpdatedRequestBody", "New-ReleaseDetails",
        "New-RemoteControlRecording", "New-RemoveParentTenantRequest", "New-RemoveTagsRequest", "New-RequestFormSupportBody",
        "New-RequestSessionSupportRequestBody", "New-RerunSessionsRequestBody", "New-ResolveAssignmentsForMaintenanceItemRequest", "New-ResolveAssignmentsForMaintenanceItemResult",
        "New-ResolveAssignmentsForMaintenanceItemResultItem", "New-ResolveFailuresRequestBody", "New-ResolveOnboardingOverridableAssignmentsResponseBody", "New-ResolveVisibilityTargetAssignmentsRequest",
        "New-Role", "New-RoleClaim", "New-RoleType", "New-RunImmybotComputerRequestBody",
        "New-RunImmybotMaintenanceRequestBody", "New-RunImmybotPersonRequestBody", "New-RunImmybotTenantRequestBody", "New-RunImmyServiceRequestBody",
        "New-RunImmyServiceResponseBody", "New-RunImmyServiceResponseSession", "New-RunScriptRequestBody", "New-RuntimeFieldHandle",
        "New-RuntimeMethodHandle", "New-RuntimeTypeHandle", "New-Schedule", "New-Script",
        "New-ScriptActionAudit", "New-ScriptActionAuditResult", "New-ScriptReference", "New-ScriptReferenceCounts",
        "New-ScriptSearchResult", "New-ScriptSyntaxCheckRequestBody", "New-SemanticVersion", "New-SendTestBrandingEmailRequest",
        "New-SendTestEmailRequest", "New-SessionJobArgs", "New-SessionLog", "New-SessionPhase",
        "New-SetExcludedFromUserAffinityRequestBody", "New-SetParentTenantRequest", "New-SetPreflightScriptEnablementRequest", "New-SetupTestIntegrationRequest",
        "New-ShowCommandInfo", "New-SkipOnboardingRequest", "New-SkipOnboardingResponse", "New-SmtpConfig",
        "New-SoftwareFileUploadData", "New-SoftwarePrerequisite", "New-SoftwareSpecifier", "New-SortingInfo",
        "New-SourceContextLogLevel", "New-StartEditorServicesRequest", "New-StructLayoutAttribute", "New-SubmitFeedbackRequestBody",
        "New-SubscriptionAddonDto", "New-SubscriptionDetails", "New-SubscriptionFeature", "New-SubscriptionFeatureBasicInfo",
        "New-SubscriptionFeatureLevelInfo", "New-SubscriptionItemBasicInfo", "New-SummaryInfo", "New-SupportedCrossProviderLinkage",
        "New-SyncAgentsForClientsRequest", "New-SyncAzureDataForTenantsRequest", "New-SyntaxCheckerResult", "New-Tag",
        "New-TargetAssignment", "New-TargetAssignmentDuplicateResponse", "New-TargetAssignmentNotes", "New-TargetAssignmentResource",
        "New-TargetAssignmentVisibility", "New-TargetAssignmentVisibilityPayload", "New-TargetAssignmentVisibilityResource", "New-TargetedPerson",
        "New-TechnicianPageInfoFromPsaTicket", "New-Tenant", "New-TenantComputerCountResponse", "New-TenantConsentRequestBody",
        "New-TenantConsentResponseBody", "New-TenantInfoResult", "New-TenantMaintenanceTask", "New-TenantMedia",
        "New-TenantPreferences", "New-TenantPreferencesOperation", "New-TenantScript", "New-TenantSoftware",
        "New-TenantTag", "New-TenantTagAuthorization", "New-TestIntegrationBindConfigurationFormRequest", "New-TestIntegrationMethodRequest",
        "New-TimelineEvent", "New-TimeZoneResource", "New-ToggleApplicationLogStreamingRequest", "New-Type",
        "New-TypeInfo", "New-UnifiedComputerInfo", "New-UnlinkClientsRequestBody", "New-UpdateApplicationLogSourceContextRequest",
        "New-UpdateAzureTenantAuthDetailsCmdPayload", "New-UpdateAzureTenantAuthDetailsCmdResult", "New-UpdateAzureTenantLinkRequest", "New-UpdateBrandingRequestBody",
        "New-UpdateComputerAdditionalPersonsRequestBody", "New-UpdateComputerPrimaryPersonRequestBody", "New-UpdateComputerRequestBody", "New-UpdateDynamicIntegrationTypePayload",
        "New-UpdateExpirationRequest", "New-UpdateGlobalMaintenanceTaskPayload", "New-UpdateGlobalMediaPayload", "New-UpdateGlobalScriptRequestBody",
        "New-UpdateGlobalSoftwareRequestBody", "New-UpdateGlobalSoftwareVersionRequestBody", "New-UpdateGlobalTargetAssignmentPayload", "New-UpdateLicenseRequestBody",
        "New-UpdateLocalMaintenanceTaskPayload", "New-UpdateLocalMediaPayload", "New-UpdateLocalScriptRequestBody", "New-UpdateLocalSoftwareRequestBody",
        "New-UpdateLocalSoftwareVersionRequestBody", "New-UpdateLocalTargetAssignmentPayload", "New-UpdateMaintenanceItemOrderPayload", "New-UpdateNotesPayload",
        "New-UpdateOptionalTargetAssignmentApprovalPayload", "New-UpdatePersonPayload", "New-UpdateProviderLinkRequestBody", "New-UpdateRecommendedApprovalPayload",
        "New-UpdateRecommendedApprovalsRequestBody", "New-UpdateReleaseChannelRequest", "New-UpdateScheduleRequest", "New-UpdateTagPayload",
        "New-UpdateTargetVisibilityPayload", "New-UpdateTenantPayload", "New-UpdateUserPayload", "New-User",
        "New-UserAffinity", "New-UserAuthInfo", "New-UserImpersonation", "New-UserPreferences",
        "New-UserPreferencesOperation", "New-UserRole", "New-UserSilencedNotification", "New-UserSilencedNotificationResponse",
        "New-ValidateParamBlockParametersFromScriptRequest", "New-ValidateParamBlockParametersFromTaskRequest", "Push-CreateOrUpdateRoleRequest", "Push-UpdateBrandingRequestBody",
        "Push-UpdateComputerRequestBody", "Push-UpdateGlobalTargetAssignmentPayload", "Push-UpdateLicenseRequestBody", "Push-UpdateLocalTargetAssignmentPayload",
        "Push-UpdatePersonPayload", "Push-UpdateProviderLinkRequestBody", "Push-UpdateScheduleRequest", "Push-UpdateTenantPayload",
        "Remove-ApiConnectionConfig", "Remove-Brandings", "Remove-ChangeRequests", "Remove-ComputersEphemeralAgent",
        "Remove-DynamicProviderTypesGlobal", "Remove-DynamicProviderTypesLocal", "Remove-DynamicProviderTypesTestEnvironment", "Remove-InventoryTasksLocal",
        "Remove-InventoryTasksLocalScripts", "Remove-Licenses", "Remove-MaintenanceTasksGlobal", "Remove-MaintenanceTasksLocal",
        "Remove-ManagerRelease", "Remove-MediaGlobal", "Remove-MediaLocal", "Remove-NotificationsUnsilence",
        "Remove-OauthOauthAccessTokens", "Remove-Persons", "Remove-ProviderLinks", "Remove-ProviderLinksCrossReferences",
        "Remove-Roles", "Remove-Schedules", "Remove-ScriptsGlobal", "Remove-ScriptsLocal",
        "Remove-SmtpConfigs", "Remove-SoftwareGlobal", "Remove-SoftwareGlobalVersions", "Remove-SoftwareLocal",
        "Remove-SoftwareLocalVersions", "Remove-Tags", "Remove-TargetAssignments", "Remove-TargetAssignmentsGlobal",
        "Remove-Users", "Remove-UsersBulkDelete", "Save-ApiConnectionConfig", "Send-AcknowledgeNotificationsRequest",
        "Send-AddChangeRequestCommentBody", "Send-AddTagsRequest", "Send-AnalyzePackageParams", "Send-BatchSetExcludedFromUserAffinityRequestBody",
        "Send-BeginAuthCodeFlowRequest", "Send-BillingCreateCustomerPortalSession", "Send-BrandingsGlobalDefault", "Send-BrandingsValidateTimeFormat",
        "Send-BulkCreateTenantRequestBody", "Send-BulkDeleteRequest", "Send-BulkLinkClientsToTenantsRequestBody", "Send-BulkScheduleRequest",
        "Send-BulkUpdateRoleRequest", "Send-CalculateTargetsRequest", "Send-CancelApplicationLockRequest", "Send-CancelSessionsRequestBody",
        "Send-ChangeRequestsApprove", "Send-ChangeRequestsDeny", "Send-ChangeRequestsRequireChanges", "Send-ChangeTenantsPayload",
        "Send-ClearApplicationLogSourceContextRequest", "Send-CloneRoleRequest", "Send-ComputersEphemeralAgentCircuitBreakerReset", "Send-ComputersReinventory",
        "Send-ComputersRestore", "Send-ComputersSetToNeedsOnboarding", "Send-CreateBrandingRequestBody", "Send-CreateDynamicIntegrationTypePayload",
        "Send-CreateGlobalMaintenanceTaskPayload", "Send-CreateGlobalScriptRequestBody", "Send-CreateGlobalSoftwareRequestBody", "Send-CreateGlobalSoftwareVersionRequestBody",
        "Send-CreateGlobalTargetAssignmentPayload", "Send-CreateLicenseRequestBody", "Send-CreateLinkedProviderReferenceRequestBody", "Send-CreateLocalMaintenanceTaskPayload",
        "Send-CreateLocalScriptRequestBody", "Send-CreateLocalSoftwareRequestBody", "Send-CreateLocalSoftwareVersionRequestBody", "Send-CreateLocalTargetAssignmentPayload",
        "Send-CreateOrUpdateRoleRequest", "Send-CreatePersonPayload", "Send-CreateProviderLinkRequestBody", "Send-CreateProviderLinkWithExternalProviderReferenceRequestBody",
        "Send-CreateScheduleRequest", "Send-CreateSmtpRequest", "Send-CreateTagPayload", "Send-CreateTenantRequestBody",
        "Send-CreateUserFromPersonRequest", "Send-DeleteAzureTenantAuthDetailsCmdPayload", "Send-DentityReseedResetClaims", "Send-DentityReseedResetPersons",
        "Send-DentityReseedResetRoles", "Send-DentityReseedResetUserClaims", "Send-DentityReseedResetUsers", "Send-DevInstanceManagementStartHangfireServer",
        "Send-DevInstanceManagementStopHangfireServer", "Send-DevLabUnclaim", "Send-DisambiguateAzureTenantTypeRequestBody", "Send-DoesScriptHaveParamBlockRequest",
        "Send-DuplicateAssignmentRequestBody", "Send-DuplicateMaintenanceTaskRequestbody", "Send-DuplicateScriptRequestBody", "Send-DuplicateTargetAssignmentPayload",
        "Send-DynamicProviderTypesGlobalReload", "Send-DynamicProviderTypesLocalReload", "Send-DynamicProviderTypesReload", "Send-ErsonsDenyAccess",
        "Send-ExcludeFromMaintenanceRequest", "Send-FailAuthCodeFlowRequest", "Send-FastCreateGlobalVersionRequestBody", "Send-FastCreateLocalVersionRequestBody",
        "Send-FinishAuthCodeFlowRequest", "Send-GetBashInstallScriptParameters", "Send-GetBashInstallScriptParametersWithOnboardingOptions", "Send-GetExecutableUriParameters",
        "Send-GetExecutableUriParametersWithOnboardingOptions", "Send-GetFileDownloadUrlRequest", "Send-GetFunctionSyntaxRequest", "Send-GetLatestActionForComputersRequestBody",
        "Send-GetLatestActionForTenantsRequestBody", "Send-GetPowerShellInstallScriptParameters", "Send-GetPowerShellInstallScriptParametersWithOnboardingOptions", "Send-GetProvisioningPackageUriParameters",
        "Send-GetProvisioningPackageUriParametersWithOnboardingOptions", "Send-GetScriptVariablesAndParametersRequest", "Send-GettingStartedChecklistComplete", "Send-GettingStartedChecklistReset",
        "Send-GrantAccessRequest", "Send-GrantAccessRequestRbac", "Send-IdentifyAgentRequest", "Send-ImpersonationRequest",
        "Send-IntegrationBindParametersRequest", "Send-InventoryTaskPayload", "Send-InventoryTaskScriptPayload", "Send-LicationLogsSourceContextClearAll",
        "Send-LicensesUpload", "Send-LinkClientsToTenantRequestBody", "Send-LinkClientToNewTenantRequestBody", "Send-MaintenanceSessionsActionsRerun",
        "Send-MaintenanceSessionsCancelAll", "Send-MaintenanceSessionsRerun", "Send-MaintenanceSessionsResume", "Send-MaintenanceTasksGlobalParamBlockFromParameters",
        "Send-MaintenanceTasksLocalMigrateLocalToGlobal", "Send-MaintenanceTasksLocalParamBlockFromParameters", "Send-ManagerInstanceUpdateFailed", "Send-ManagerInstanceUpdating",
        "Send-ManagerTriggerConfigRefresh", "Send-ManagerTriggerMetricsRefresh", "Send-MediaGlobalUpload", "Send-MediaLocalUpload",
        "Send-MediaSupportUpload", "Send-MergeTenantsPayload", "Send-MetricsCircuitBreakersIsolate", "Send-MetricsCircuitBreakersReset",
        "Send-MigrateToSupersedingAssignmentRequest", "Send-MspInstanceImmySupportAccessGrantDetails", "Send-NotificationsSilence", "Send-OauthOauthAccessTokensRefresh",
        "Send-OverrideTargetAssignmentRequest", "Send-PreconsentCustomerTenantsRequest", "Send-ProviderAgentsResolveFailure", "Send-RegistryPayload",
        "Send-ReleaseChannelUpdatedRequestBody", "Send-ReleaseDetails", "Send-RemoveParentTenantRequest", "Send-RemoveTagsRequest",
        "Send-RequestFormSupportBody", "Send-RequestSessionSupportRequestBody", "Send-RerunSessionsRequestBody", "Send-ResolveAssignmentsForMaintenanceItemRequest",
        "Send-ResolveFailuresRequestBody", "Send-ResolveVisibilityTargetAssignmentsRequest", "Send-RoviderAgentsResolveFailure", "Send-RoviderAgentsResolveFailures",
        "Send-RoviderLinksAgentsDeleteOfflineAgentFromComputer", "Send-RoviderLinksAgentsExternalAgentUrl", "Send-RoviderLinksAgentsInstallOnComputer", "Send-RoviderLinksAgentsRefreshDeviceOnlineStatus",
        "Send-RoviderLinksAgentsSync", "Send-RoviderLinksClientsLinkExactMatchClients", "Send-RoviderLinksClientsSync", "Send-RoviderLinksCrossReferencesDisableClientLinking",
        "Send-RoviderLinksCrossReferencesEnableClientLinking", "Send-RoviderLinksCrossReferencesSyncClients", "Send-RoviderLinksReload", "Send-RunImmyServiceRequestBody",
        "Send-RunScriptRequestBody", "Send-SchedulesCancel", "Send-SchedulesDuplicate", "Send-SchedulesRunNow",
        "Send-ScriptsDebugCancel", "Send-ScriptsLocalMigrateLocalToGlobal", "Send-ScriptSyntaxCheckRequestBody", "Send-SendTestBrandingEmailRequest",
        "Send-SendTestEmailRequest", "Send-SetExcludedFromUserAffinityRequestBody", "Send-SetParentTenantRequest", "Send-SetPreflightScriptEnablementRequest",
        "Send-SetupTestIntegrationRequest", "Send-SkipOnboardingRequest", "Send-SoftwareGlobalUpload", "Send-SoftwareLocalMigrateLocalToGlobal",
        "Send-SoftwareLocalUpload", "Send-StartEditorServicesRequest", "Send-SubmitFeedbackRequestBody", "Send-SubscriptionDetails",
        "Send-SyncAgentsForClientsRequest", "Send-SyncAzureDataForTenantsRequest", "Send-SyncsAzureUserSync", "Send-SyncsTriggerUserAffinitySync",
        "Send-SystemDisableImmySupportAccess", "Send-SystemEnableImmySupportAccess", "Send-SystemIsImmySupportAccessGranted", "Send-SystemPullUpdate",
        "Send-SystemReset", "Send-SystemRestartBackend", "Send-TargetAssignmentsMigrateDeploymentsToProviderLinks", "Send-TenantConsentRequestBody",
        "Send-TestIntegrationBindConfigurationFormRequest", "Send-TestIntegrationMethodRequest", "Send-ToggleApplicationLogStreamingRequest", "Send-UnlinkClientsRequestBody",
        "Send-UpdateApplicationLogSourceContextRequest", "Send-UpdateAzureTenantAuthDetailsCmdPayload", "Send-UpdateAzureTenantLinkRequest", "Send-UpdateComputerAdditionalPersonsRequestBody",
        "Send-UpdateComputerPrimaryPersonRequestBody", "Send-UpdateDynamicIntegrationTypePayload", "Send-UpdateExpirationRequest", "Send-UpdateGlobalMaintenanceTaskPayload",
        "Send-UpdateGlobalMediaPayload", "Send-UpdateGlobalScriptRequestBody", "Send-UpdateLocalMaintenanceTaskPayload", "Send-UpdateLocalMediaPayload",
        "Send-UpdateLocalScriptRequestBody", "Send-UpdateLocalTargetAssignmentPayload", "Send-UpdateMaintenanceItemOrderPayload", "Send-UpdateNotesPayload",
        "Send-UpdateOptionalTargetAssignmentApprovalPayload", "Send-UpdateRecommendedApprovalsRequestBody", "Send-UpdateReleaseChannelRequest", "Send-UpdateTagPayload",
        "Send-UpdateUserPayload", "Send-UsersInvalidateCache", "Send-UsersStopImpersonating", "Send-UthRequestAccess",
        "Send-ValidateParamBlockParametersFromScriptRequest", "Send-ValidateParamBlockParametersFromTaskRequest", "Send-Webhooks", "Update-ApplicationPreferencesOperation",
        "Update-BatchUpdateAssignmentRequest", "Update-BulkScheduleStatusRequest", "Update-GlobalSoftware", "Update-TenantPreferencesOperation",
        "Update-TenantsActivate", "Update-TenantsDeactivate", "Update-UpdateGlobalSoftwareVersionRequestBody", "Update-UpdateLocalSoftwareRequestBody",
        "Update-UpdateLocalSoftwareVersionRequestBody", "Update-UserPreferencesOperation"
    )

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

