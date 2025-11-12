BeforeAll {
    . "$PSScriptRoot\_setup.Tests.ps1"
    Connect-ImmyApi -UseSavedConfig
}

Describe "Get-ImmyAccessRequestResponse" {
    It "should return the access request response for a given request ID" {
        Get-ImmyAccessRequestResponse
        $? | Should -Be $true
    }
}

AfterAll {
    . "$PSScriptRoot\_teardown.Tests.ps1"
}
