BeforeAll {
    . "$PSScriptRoot\_setup.Tests.ps1"
}

Describe "Connect-ImmyApi" {
    It "should return nothing without error" {
        Connect-ImmyApi -UseSavedConfig
        $? | Should -Be $true
    }
}

AfterAll {
    . "$PSScriptRoot\_teardown.Tests.ps1"
}