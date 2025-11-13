# AI Assistant Instructions for PSImmyBot

Purpose: This repo is a .NET 8 class library that exposes a PowerShell module (`PSImmyBot`) for interacting with the ImmyBot API. The library compiles cmdlets (classes under `Cmdlets/`) that wrap HTTP endpoints via a common service layer.

## Architecture & Key Concepts
- Entry points: PowerShell cmdlets (each `public class X : Cmdlet` with a `[Cmdlet]` attribute) in `Cmdlets/`. They perform minimal orchestration then call `ImmyBotApiService`.
- Service layer: `Services/ImmyBotApiService.cs` centralizes HTTP verb operations (Get/Post/Patch) with token + base URL setup and uniform JSON deserialization (tries root first, then `data` property fallback).
- Global state: `Globals.cs` persists Azure auth token and API connection config as JSON files under `%AppData%/PSImmyBot`. Always retrieve configuration/token through `Globals` helpers—don’t duplicate file IO paths.
- Models: Plain records / classes under `Models/` mirror API DTOs. Keep them dumb; serialization relies on `System.Text.Json` with default options (indent on save, compact for query parameter building).
- Query parameters: Use `Globals.ConvertToQueryParameters(DataSourceLoadOptions)` or `Globals.ConvertToQueryParameters<T>(value, name)` to build consistently escaped query strings; avoid manual concatenation.

## Auth & Configuration Flow
1. User runs `Connect-Api` (direct parameters or `-UseSavedConfig`). This fetches an Azure token via tenant discovery and saves it (`Globals.SaveApiToken`).
2. Subsequent cmdlets must assume token + config exist; they call `Globals.Token` (null if missing/expiring) and `Globals.GetApiConnectionConfig()`.
3. If token is null, cmdlets should throw a clear message instructing authentication first (pattern in `ImmyBotApiService`).

## Patterns to Follow
- Endpoint construction: Start with a leading `/api/v1/...` and finish with `?` then append query pieces built by helpers; trim trailing `?` or `&` before calling service (see `GetAuth.cs`).
- ParameterSets: Use distinct `ParameterSetName` values for mutually exclusive modes (e.g., saved vs direct config in `ConnectApi`). Mandatory ordering via `Position` is used for direct entry.
- Output: Use `WriteObject(result)` for returning deserialized DTOs; use `WriteInformation` for status messages (e.g., connection success), not `WriteVerbose`.
- Error handling: Let `ImmyBotApiService` throw if HTTP status not success; avoid swallowing exceptions—propagate with added context only when loading saved config.
- Serialization fallback: When deserializing, if root fails and body has `{ "data": ... }`, fallback to `data`—replicate this approach for new verbs if added.
- Do NOT cache `ImmyBotApiService` HttpClient per cmdlet currently; code creates a new client each call (follow existing style unless refactoring globally).

## Adding a New Cmdlet (Example)
1. Create `Cmdlets/GetExampleThing.cs`.
2. Define `[Cmdlet(VerbsCommon.Get, "ExampleThing")] public class GetExampleThing : Cmdlet { protected override void ProcessRecord() { string endpoint = "/api/v1/exampleThings?"; endpoint += Globals.ConvertToQueryParameters(someOptions); var result = ImmyBotApiService.Get<ExampleThingDto>(endpoint.TrimEnd('?','&')).GetAwaiter().GetResult(); WriteObject(result); } }`
3. Add/Update corresponding model in `Models/ExampleThingDto.cs`.
4. Keep synchronous `ProcessRecord` pattern with `.GetAwaiter().GetResult()` for async service calls.

## Build & Test Workflow
- Build: `dotnet build` (targets `net8.0`). The PowerShell module manifest `PSImmyBot.psd1` is copied to output (see `<Content>` in csproj).
- Import locally: After build, from `bin/Debug/net8.0`, run `Import-Module ./PSImmyBot.dll` or place in a module path with the `.psd1` manifest.
- No test project present; if adding tests, prefer xUnit and exercise cmdlets via `System.Management.Automation` PowerShell runspaces.

## Conventions & Naming
- Cmdlet naming uses verb-noun with explicit verb from `System.Management.Automation.Verbs*` sets (`Get`, `Connect`). For API actions lacking a standard verb, choose closest approved verb.
- Avoid abbreviations in model property names; match API JSON fields for seamless (de)serialization.
- File names match class names exactly (PascalCase) and reside in folders (`Cmdlets`, `Services`, `Models`).

## Extending Service Layer
- If adding other HTTP verbs (DELETE, PUT), replicate pattern: acquire token, set `BaseAddress` from saved config, set Bearer header, send request, `EnsureSuccessStatusCode()`, attempt root then `data` property deserialization.

## Security & Secrets
- Azure client secret persisted only if user opts to `-Save` during `Connect-Api`. Do not log secrets. Use existing save helpers; never hardcode paths.

## Pitfalls
- Token may be considered expired if less than 5 minutes remaining (`Globals.Token` returns null). Handle this by prompting re-auth.
- Always trim trailing `?` or `&` before calling service; failing to do so may cause 404s.
- Passing complex filters: Use JSON serialization via helper rather than manual string building to maintain proper escaping.

Feedback welcome—clarify any unclear workflow or propose additions (tests, refactors) separately.
