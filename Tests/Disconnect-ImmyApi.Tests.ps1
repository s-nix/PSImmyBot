BeforeAll {
    . "$PSScriptRoot\_setup.Tests.ps1"
    Connect-ImmyApi -UseSavedConfig
}

Describe "Disconnect-ImmyApi" {
    It "should disconnect from the API without error" {
        Disconnect-ImmyApi
        $? | Should -Be $true
    }
}

AfterAll {
    . "$PSScriptRoot\_teardown.Tests.ps1"
}
