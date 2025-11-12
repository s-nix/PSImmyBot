BeforeAll {
    . "$PSScriptRoot\_setup.Tests.ps1"
    Connect-ImmyApi -UseSavedConfig
}

Describe "Get-ImmyApiConnectionConfig" {
    It "should return the current API connection configuration" {
        $response = Get-ImmyApiConnectionConfig
        $response | Should -Not -BeNullOrEmpty
    }
}

AfterAll {
    . "$PSScriptRoot\_teardown.Tests.ps1"
}
