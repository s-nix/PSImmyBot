<img style="display:block; margin:auto" src="./docs/assets/PSImmyBot.png" alt="PSImmyBot Logo" width="100" />

# PSImmyBot

PowerShell module and .NET 8 class library for automating the ImmyBot API.

> **Status: Alpha**  
> The cmdlet surface is still evolving and large portions have not been validated end-to-end. Expect breaking changes until full release.

## About the project

PSImmyBot compiles a PowerShell module (`PSImmyBot.dll` + `PSImmyBot.psd1`) that exposes cmdlets for managing ImmyBot tenants. Each cmdlet wraps an HTTP endpoint through a shared `ImmyBotApiService`, which handles Azure AD authentication, base URL configuration, retries, and consistent JSON deserialization. Configuration and tokens are persisted via `Globals` under `%AppData%/PSImmyBot`, letting cmdlets share connection context without re-authenticating. `global.json` pins the repo to the .NET 8.0.415 SDK so builds stay consistent across machines.

Key design points:

- `Cmdlets/` contains the entry points. Each `public class : Cmdlet` does light parameter orchestration before calling `ImmyBotApiService` synchronously via `.GetAwaiter().GetResult()`.
- `Services/ImmyBotApiService.cs` centralizes HTTP verbs, Bearer token headers, endpoint normalization, and JSON fallback logic (root body or nested `data`). Tests can inject `TestResponder` to stub calls.
- `Globals.cs` stores Azure tokens plus ImmyBot connection details on disk and provides helpers such as `ConvertToQueryParameters` for consistent URL building.
- `Models/` mirrors the ImmyBot API DTOs and is kept intentionally dumb to keep serialization predictable.
- `tests/PSImmyBot.Tests` loads the compiled module inside a PowerShell runspace and executes cmdlets against a stubbed API to ensure they build valid endpoints.

## Requirements

- .NET 8 SDK (8.0.415 as pinned in `global.json`)
- PowerShell 7.4+ with script execution permissions
- ImmyBot API access with an Azure AD app registration capable of client-credential flow
- Windows, macOS, or Linux capable of running .NET 8 (primary testing currently on Windows)
- (Optional) Python + `mkdocs-material` if you want to preview the docs site locally

## Project structure

| Path | Purpose |
| --- | --- |
| `Cmdlets/` | Verb-noun entry points that map directly to ImmyBot endpoints. |
| `Services/ImmyBotApiService.cs` | Shared HTTP client logic (Get/Post/Patch/Put/Delete) plus serialization fallback and test hooks. |
| `Globals.cs` | Persists API tokens/config in `%AppData%/PSImmyBot` (or an overridden temp folder during tests). |
| `Models/` | Plain DTOs that mirror API payloads so `System.Text.Json` can (de)serialize without extra converters. |
| `HelperScripts/` | PowerShell utilities for generating cmdlets, formatting lists, and producing docs. |
| `docs/` | MkDocs content (`mkdocs.yml`) that feeds the published documentation; `site/` holds the generated static site. |
| `tests/PSImmyBot.Tests/` | xUnit project that imports the module inside a runspace and validates cmdlet wiring via `ImmyBotApiService.TestResponder`. |
| `assets/` | Branding used by both the README and MkDocs. |
| `PSImmyBot.psd1` | Module manifest copied to `bin/Debug/net8.0/` during builds. |
| `PSImmyBot.csproj` | Class library project referencing `PowerShellStandard.Library`. |

## Build & install

The repo builds as a standard class library. The module manifest is copied next to the DLL so it can be imported immediately.

```powershell
git clone https://github.com/s-nix/PSImmyBot.git
cd PSImmyBot
dotnet build

# Import from the build output
Import-Module "./bin/Debug/net8.0/PSImmyBot.psd1" -Force
```

## Authentication & configuration flow

1. Run `Connect-ImmyApi -AzureTenantDomain <tenant> -AzureClientId <app-id> -AzureClientSecret <secret> -ImmySubdomain <tenant-subdomain>` to trigger the Azure AD client-credential flow.
2. The cmdlet discovers the tenant ID via the `.well-known/openid-configuration` endpoint before requesting an access token for `https://<subdomain>.immy.bot/.default`.
3. Tokens are saved via `Globals.SaveApiToken` and expire if less than five minutes remain. Use `-Force` to bypass an existing, valid token.
4. Pass `-Save` once to persist the connection details with `Globals.SaveApiConnectionConfig`, then reconnect later with `Connect-ImmyApi -UseSavedConfig`.
5. Use `Disconnect-ImmyApi` (clears the cached token + config) when switching tenants or rotating credentials.

If a cmdlet runs without a valid token, `ImmyBotApiService` throws a friendly error instructing you to authenticate first.

## Usage

Typical workflow:

1. `Connect-ImmyApi` to authenticate against Azure and persist the token/config.
2. Run any cmdlet (they all assume a saved config + token). Use `Get-Command -Module PSImmyBot` to list everything exported.
3. `Disconnect-ImmyApi` clears cached tokens if switching tenants.

Example snippets:

```powershell
# Enumerate computers with optional flags
Get-ImmyComputer -ComputerId 12345 -IncludeSessions $true -IncludeProviderAgents $true

# Export inventory to an XLSX file
Get-ImmyComputersInventoryExport -OutputPath "./exports/computers.xlsx"

# Peek at the current API connection config on disk
Get-ImmyApiConnectionConfig | Format-List
```

All cmdlets rely on the `Globals` serialization helpers to keep query-string escaping and payload handling consistent. Avoid direct HTTP calls when adding functionality—extend the service layer instead so retry logic, bearer tokens, and query formatting stay in one place.

## Cmdlets & models

- Over 400 cmdlets live under `Cmdlets/`; each maps to `/api/v1/...` endpoints and trims any trailing `?`/`&` before sending requests (validated in `CmdletSmokeTests`).
- DTOs live in `Models/` and mirror API JSON exactly. `HelperScripts/ConvertFrom-Models.ps1` can scaffold `New-*` cmdlets from record definitions.
- The MkDocs content under `docs/cmdlets` and `docs/models` is generated via `HelperScripts/GenerateDocs.ps1`, which inspects compiled cmdlets/models to capture parameters, HTTP methods, and sample output.

> Because the project is alpha, individual cmdlets may fail or produce incomplete data. Validate responses against the ImmyBot portal before automating.

## Helper scripts

- `HelperScripts/ConvertFrom-Models.ps1` scans record definitions and generates paired `New-*` cmdlets for creating strongly-typed objects from PowerShell.
- `HelperScripts/ConvertFrom-Swagger.ps1` (legacy) parses Swagger/OpenAPI specs to scaffold `Get/Send/Update` cmdlets for endpoints that do not yet exist in the repo.
- `HelperScripts/Format-ListToPrettyPrint.ps1` lays out long cmdlet lists into columns—handy when curating documentation or release notes.
- `HelperScripts/GenerateDocs.ps1` builds the library, loads cmdlets via reflection, and emits Markdown docs for both cmdlets and models.

## Development workflow

- `dotnet build` compiles the library, drops the manifest next to the DLL, and keeps artifacts under `bin/Debug/net8.0`.
- New cmdlets should inherit from `Cmdlet`, keep orchestration minimal, and always trim `?`/`&` before passing endpoints to `ImmyBotApiService`.
- For complex queries, use `Globals.ConvertToQueryParameters(DataSourceLoadOptions)` or `Globals.ConvertToQueryParameters<T>` instead of manual string concatenation.
- When you need custom DTOs, add them beneath `Models/` and keep property names aligned with the API payload. Serialization relies on the defaults from `System.Text.Json`.
- If you are extending HTTP support, follow the existing pattern inside `ImmyBotApiService` so auth, `BaseAddress`, and JSON fallback stay centralized.

## Testing

An xUnit project lives in `tests/PSImmyBot.Tests`. The suite spins up a PowerShell runspace, imports the freshly built module, and drives cmdlets through `CmdletInvocationPlan` definitions while `RecordingApiResponder` captures the resulting HTTP metadata.

```powershell
dotnet test tests/PSImmyBot.Tests/PSImmyBot.Tests.csproj
```

Tests currently verify:

- Every cmdlet can be invoked with a representative parameter set without throwing.
- Endpoints start with `/api/v1/` and never end with dangling `?` or `&` characters.
- The `Connect-ImmyApi` flow can run in isolation by stubbing Azure discovery/token endpoints.

## Documentation site

The user-facing site under `docs/` is driven by MkDocs + Material (`mkdocs.yml`). Use either of the following to work on docs:

- `mkdocs serve` to run a live-reload preview (requires Python + `mkdocs-material`).
- `pwsh ./HelperScripts/GenerateDocs.ps1` to regenerate cmdlet/model reference files from the compiled assembly before publishing.

The static output lands in `site/`. Publish by pointing GitHub Pages (or any static host) at that directory.

## Contributing

Contributions are welcome even in alpha—expect sharp edges and be ready to validate against the ImmyBot portal.

1. Open an issue describing the bug/feature and affected endpoint.
2. Follow the established cmdlet naming (`Verb-Noun`), reuse `Globals` helpers for configuration, and keep nouns Immy-specific only when necessary (the module already prefixes exported names with `Immy`).
3. Update or add docs/tests (`HelperScripts/GenerateDocs.ps1`, `dotnet test`) whenever you touch cmdlets or models, and include a brief usage example where possible.

## License

This project is licensed under the [GNU General Public License v3.0](LICENSE).
