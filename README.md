<img style="display:block; margin:auto" src="./docs/assets/PSImmyBot.png" alt="PSImmyBot Logo" width="100" />

# PSImmyBot

PowerShell module and .NET 8 class library for automating the ImmyBot API.

> **Status: Pre-Alpha**  
> All cmdlets have not yet been tested and will be broken. Expect breaking changes until full release.

## About the project

PSImmyBot compiles a PowerShell module (`PSImmyBot.dll` + `PSImmyBot.psd1`) that exposes cmdlets for managing ImmyBot tenants. Each cmdlet wraps an HTTP endpoint through a shared `ImmyBotApiService`, which handles Azure AD authentication, base URL configuration, and consistent JSON deserialization. Configuration and tokens are persisted via `Globals` under `%AppData%/PSImmyBot`, letting cmdlets share connection context without re-authenticating.

Key directories:

- `Cmdlets/`: Entry-point cmdlet classes (e.g., `Connect-ImmyApi`, `Get-ImmyComputer`).
- `Services/ImmyBotApiService.cs`: Centralized HTTP helper for GET/POST/PATCH with token handling.
- `Globals.cs`: Persists configuration and access tokens.
- `Models/`: DTOs that mirror ImmyBot API payloads and returns.
- `docs/` & `mkdocs.yml`: End-user documentation site.

## Requirements

- .NET 8 SDK (building the class library)
- PowerShell 7.4+ (recommended) with script execution rights
- ImmyBot API access plus Azure AD app registration capable of fetching tokens
- Windows, macOS, or Linux capable of running .NET 8 (tested primarily on Windows)

## Quick start

```powershell
# Clone and build
git clone https://github.com/s-nix/PSImmyBot.git
cd PSImmyBot
dotnet build

# Import the freshly built module (inside bin/Debug/net8.0)
Import-Module "./bin/Debug/net8.0/PSImmyBot.psd1" -Force

# Configure your connection (values will be saved under %AppData%/PSImmyBot)
Connect-ImmyApi -AzureTenantDomain "<tenant-domain>" -AzureClientId "<app-id>" -AzureClientSecret "<client-secret>" -ImmySubdomain "<immy-subdomain>" -Save

# Or if you've already saved the config:
Connect-ImmyApi -UseSavedConfig
```

> Because the project is pre-alpha, individual cmdlets may fail or produce incomplete data. Validate responses against the ImmyBot portal before automating.

## Usage

Typical workflow:

1. `Connect-ImmyApi` to authenticate against Azure and persist the token/config.
2. Run any of the cmdlets to interrogate ImmyBot resources.
3. Use `Disconnect-ImmyApi` to clear cached tokens if switching tenants.

Example: retrieving computers with optional filters.

```powershell
# Using saved configuration from Connect-ImmyApi
Get-ImmyComputer -ComputerId 12345 -IncludeSessions $true -IncludeProviderAgents $true

# Exporting inventory sample
Get-ImmyComputersInventoryExport -OutputPath "./exports/computers.xlsx"
```

All cmdlets rely on shared serialization helpers from `Globals`. Avoid direct HTTP calls when adding new functionality—extend the service layer instead so retry logic, bearer tokens, and query formatting stay consistent.

## Development workflow

- Build with `dotnet build` to compile the class library and copy the PowerShell manifest alongside the DLL.
- Use `Import-Module` from the output folder to test cmdlets locally.
- Author new cmdlets under `Cmdlets/` inheriting from `Cmdlet` and call `ImmyBotApiService` synchronously via `.GetAwaiter().GetResult()`.
- Model classes should mirror API payload names exactly to keep JSON serialization simple.
- Documentation lives under `docs/`; preview with `mkdocs serve` once dependencies are installed.

## Contributing

Contributions are welcome even in pre-alpha—just expect sharp edges. ⚔️ 🐛

1. Open an issue describing the bug/feature and affected endpoint.
2. Follow the established cmdlet naming (`Verb-Noun`) and reuse `Globals` helpers for configuration. (A default prefix of "Immy" is used, so the nouns do not need an explicit prefix)
3. Include a brief usage example or test snippet when possible.

## License

This project is licensed under the [GNU General Public License v3.0](LICENSE).
