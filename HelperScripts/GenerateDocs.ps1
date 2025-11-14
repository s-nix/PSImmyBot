[CmdletBinding()]
param(
    [string]$Root = (Resolve-Path (Join-Path $PSScriptRoot '..')).Path
)

Set-StrictMode -Version Latest
$ErrorActionPreference = 'Stop'

function Invoke-DotnetBuild {
    param([string]$Path)
    Push-Location $Path
    try {
        dotnet build | Out-Null
    }
    finally {
        Pop-Location
    }
}

function Ensure-AssemblyReady {
    param([string]$RootPath)
    $assemblyPath = Join-Path $RootPath 'bin/Debug/net8.0/PSImmyBot.dll'
    if (-not (Test-Path $assemblyPath)) {
        Invoke-DotnetBuild -Path $RootPath
    }
    return $assemblyPath
}

function Get-GenericTypeFromInvocation {
    param(
        [string]$Text,
        [int]$StartIndex
    )

    if ($StartIndex -lt 0 -or [string]::IsNullOrEmpty($Text)) {
        return $null
    }

    $substring = $Text.Substring($StartIndex)
    $angleIndex = $substring.IndexOf('<')
    if ($angleIndex -lt 0) {
        return $null
    }

    $depth = 0
    $builder = [System.Text.StringBuilder]::new()
    for ($i = $angleIndex + 1; $i -lt $substring.Length; $i++) {
        $char = $substring[$i]
        if ($char -eq '<') {
            $depth++
            $null = $builder.Append('<')
            continue
        }
        if ($char -eq '>') {
            if ($depth -eq 0) {
                return $builder.ToString().Trim()
            }
            $depth--
            $null = $builder.Append('>')
            continue
        }
        $null = $builder.Append($char)
    }

    return $null
}

function Get-ServiceCallInfo {
    param([string]$SourceText)

    $info = [pscustomobject]@{
        HttpMethod               = $null
        ReturnType               = $null
        Endpoint                 = $null
        UsesQueryHelper          = $false
        WritesPipelineCollection = $false
        UsesGlobals              = $false
    }

    if ([string]::IsNullOrWhiteSpace($SourceText)) {
        return $info
    }

    $callMatch = [regex]::Match($SourceText, 'ImmyBotApiService\.(Get|Post|Patch|Delete|Put)', 'IgnoreCase')
    if ($callMatch.Success) {
        $info.HttpMethod = $callMatch.Groups[1].Value.ToUpperInvariant()
        $info.ReturnType = Get-GenericTypeFromInvocation -Text $SourceText -StartIndex ($callMatch.Index + $callMatch.Length)
    }

    $endpointMatch = [regex]::Match($SourceText, '"(/api[^"\r\n]*)"', 'IgnoreCase')
    if ($endpointMatch.Success) {
        $info.Endpoint = $endpointMatch.Groups[1].Value
    }

    $info.UsesQueryHelper = $SourceText -match 'Globals\.ConvertToQueryParameters'
    $info.WritesPipelineCollection = $SourceText -match 'WriteObject\s*\([^,]+,\s*true\)'
    $info.UsesGlobals = $SourceText -match 'Globals\.'

    return $info
}

function Get-ParameterMetadata {
    param([Type]$CmdletType)

    $parameterAttributeType = [System.Management.Automation.ParameterAttribute]
    $bindingFlags = [System.Reflection.BindingFlags] 'Instance, Public, DeclaredOnly'
    $results = @()

    foreach ($prop in $CmdletType.GetProperties($bindingFlags)) {
        $attrs = $prop.GetCustomAttributes($parameterAttributeType, $false)
        if (-not $attrs -or $attrs.Length -eq 0) {
            continue
        }

        $positions = @()
        $sets = @()
        $mandatory = $false
        $pipelineValue = $false
        $pipelineProperty = $false

        foreach ($attr in $attrs) {
            if ($attr.Mandatory) {
                $mandatory = $true
            }
            if ($attr.Position -ne [int]::MinValue -and $positions -notcontains $attr.Position) {
                $positions += $attr.Position
            }
            $setName = $attr.ParameterSetName
            if ([string]::IsNullOrWhiteSpace($setName) -or $setName -eq [System.Management.Automation.ParameterAttribute]::AllParameterSets) {
                $setName = 'All'
            }
            if ($sets -notcontains $setName) {
                $sets += $setName
            }
            if ($attr.ValueFromPipeline) {
                $pipelineValue = $true
            }
            if ($attr.ValueFromPipelineByPropertyName) {
                $pipelineProperty = $true
            }
        }

        if ($positions.Count -gt 0) {
            $positions = @($positions | Sort-Object -Unique)
        }
        else {
            $positions = @()
        }
        if ($sets.Count -eq 0) {
            $sets = @('All')
        }
        else {
            $sets = @($sets | Sort-Object -Unique)
        }

        $results += [pscustomobject]@{
            Name             = $prop.Name
            Type             = $prop.PropertyType.Name
            Mandatory        = $mandatory
            Positions        = $positions
            ParameterSets    = $sets
            PipelineValue    = $pipelineValue
            PipelineProperty = $pipelineProperty
        }
    }

    return $results | Sort-Object Name
}

function Escape-Markdown {
    param([string]$Value)
    if ($null -eq $Value -or $Value -eq '') {
        return '—'
    }
    return $Value.Replace('|', '\|')
}

function Get-PipelineText {
    param(
        [bool]$Value,
        [bool]$Property
    )

    $modes = @()
    if ($Value) { $modes += 'Value' }
    if ($Property) { $modes += 'PropertyName' }
    if ($modes.Count -eq 0) { return 'None' }
    return ($modes -join ', ')
}

function Build-BehaviorBullets {
    param(
        $ServiceInfo,
        [string]$SourceText
    )

    $bullets = @()
    if ($ServiceInfo.HttpMethod) {
        $endpointText = if ($ServiceInfo.Endpoint) { (' targeting `{0}`' -f $ServiceInfo.Endpoint) } else { '' }
        $returnText = if ($ServiceInfo.ReturnType) { (' and deserializes to `{0}`' -f $ServiceInfo.ReturnType) } else { '' }
        $bullets += ('Calls `ImmyBotApiService.{0}`{1}{2}.' -f $ServiceInfo.HttpMethod, $endpointText, $returnText)
    }
    if ($ServiceInfo.UsesQueryHelper) {
        $bullets += 'Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.'
    }
    if ($ServiceInfo.WritesPipelineCollection) {
        $bullets += 'Emits collection output with `WriteObject(..., true)` so items stream through the pipeline individually.'
    }
    if ((-not $ServiceInfo.HttpMethod) -and ($SourceText -match 'HttpClient')) {
        $bullets += 'Uses `HttpClient` directly instead of `ImmyBotApiService` for its network call.'
    }
    if ($SourceText -match 'Globals\.SaveApiConnectionConfig') {
        $bullets += 'Persists API configuration to the local profile when requested.'
    }
    if ($SourceText -match 'Globals\.SaveApiToken') {
        $bullets += 'Updates the cached API token via `Globals.SaveApiToken`.'
    }
    if ($SourceText -match 'WriteInformation') {
        $bullets += 'Writes informational messages for user feedback.'
    }
    if ($bullets.Count -eq 0) {
        $bullets += 'Refer to the source implementation for detailed flow; this cmdlet performs custom orchestration beyond simple API proxying.'
    }
    return $bullets
}

function Get-FriendlyTypeName {
    param([Type]$Type)

    if (-not $Type) {
        return 'Unknown'
    }

    if ($Type.IsArray) {
        return '{0}[]' -f (Get-FriendlyTypeName -Type $Type.GetElementType())
    }

    if ($Type.IsGenericType) {
        $genericDefinition = $Type.GetGenericTypeDefinition()
        if ($genericDefinition -eq [Nullable`1]) {
            return (Get-FriendlyTypeName -Type $Type.GenericTypeArguments[0]) + '?'
        }

        $genericArguments = $Type.GetGenericArguments() | ForEach-Object { Get-FriendlyTypeName -Type $_ }
        $name = $Type.Name
        $tickIndex = $name.IndexOf('`')
        if ($tickIndex -ge 0) {
            $name = $name.Substring(0, $tickIndex)
        }
        return '{0}<{1}>' -f $name, ($genericArguments -join ', ')
    }

    switch ($Type.FullName) {
        'System.String' { return 'string' }
        'System.Boolean' { return 'bool' }
        'System.Int32' { return 'int' }
        'System.Int64' { return 'long' }
        'System.Decimal' { return 'decimal' }
        'System.Double' { return 'double' }
        'System.Single' { return 'float' }
        'System.DateTime' { return 'DateTime' }
        'System.Guid' { return 'Guid' }
        'System.Object' { return 'object' }
        Default { return $Type.Name }
    }
}

function Get-NullableDescriptor {
    param([Type]$Type)

    if (-not $Type) {
        return 'Unknown'
    }

    if ($Type.IsValueType) {
        if ($Type.IsGenericType -and ($Type.GetGenericTypeDefinition() -eq [Nullable`1])) {
            return 'Yes (nullable value type)'
        }
        return 'No (value type)'
    }

    return 'Reference type (nullable)'
}

function Get-ModelKind {
    param([Type]$Type)

    if (-not $Type) {
        return 'Unknown'
    }

    if ($Type.IsEnum) { return 'Enum' }
    if ($Type.IsValueType -and -not $Type.IsPrimitive) { return 'Struct' }
    if ($Type.IsClass) {
        if ($Type.IsAbstract) { return 'Abstract Class' }
        return 'Class'
    }
    return 'Type'
}

function Build-ModelDoc {
    param(
        [System.IO.FileInfo]$ModelFile,
        [Type]$ModelType
    )

    $modelName = $ModelFile.BaseName
    if (-not $ModelType) {
        return @(
            '---',
            "title: $modelName",
            '---',
            '',
            "# $modelName",
            '',
            '> Auto-generated reference stub for this model. The generator could not locate a matching compiled type, so only basic metadata is available.',
            '',
            '## Overview',
            ("This type is defined in `Models/{0}`. Rebuild the project to expose richer reflection data." -f $ModelFile.Name),
            '',
            '## Serialization',
            '- Namespace: `PSImmyBot.Models`',
            ('- Source file: `Models/{0}`' -f $ModelFile.Name),
            '- Serializer: `System.Text.Json`',
            '',
            '## Notes',
            'This stub will be replaced with detailed metadata once the type is compiled into the PSImmyBot assembly.'
        )
    }

    $kind = Get-ModelKind -Type $ModelType
    $namespace = $ModelType.Namespace
    $assemblyName = $ModelType.Assembly.GetName().Name
    $baseType = if ($ModelType.BaseType -and $ModelType.BaseType -ne [object]) { Get-FriendlyTypeName -Type $ModelType.BaseType } else { 'object' }
    $interfaces = @($ModelType.GetInterfaces() | Sort-Object Name)
    $interfaceText = if ($interfaces.Count -gt 0) {
        (($interfaces | ForEach-Object { '`{0}`' -f (Get-FriendlyTypeName -Type $_) }) -join ', ')
    }
    else {
        'None'
    }

    $lines = @()
    $lines += '---'
    $lines += "title: $modelName"
    $lines += '---'
    $lines += ''
    $lines += "# $modelName"
    $lines += ''
    $lines += '| Detail | Value |'
    $lines += '| --- | --- |'
    $lines += ('| Namespace | `{0}` |' -f $namespace)
    $lines += ('| Kind | {0} |' -f $kind)
    $lines += ('| Assembly | `{0}` |' -f $assemblyName)
    $lines += ('| Base Type | `{0}` |' -f $baseType)
    $lines += ('| Implements | {0} |' -f $interfaceText)
    $lines += ('| Source | `Models/{0}` |' -f $ModelFile.Name)
    $lines += ''
    $lines += '## Overview'
    $lines += ('`{0}` is a {1} from `PSImmyBot.Models` and participates in ImmyBot API payloads generated by the module.' -f $modelName, $kind)

    if ($ModelType.IsEnum) {
        $underlying = Get-FriendlyTypeName -Type ($ModelType.GetEnumUnderlyingType())
        $lines += ''
        $lines += "### Underlying type"
        $lines += ''
        $lines += ('- `{0}`' -f $underlying)
        $lines += ''
        $lines += '## Members'
        $lines += ''
        $lines += '| Name | Value |'
        $lines += '| --- | --- |'
        foreach ($field in $ModelType.GetFields([System.Reflection.BindingFlags] 'Public, Static')) {
            if (-not $field.IsLiteral) { continue }
            $lines += ('| {0} | {1} |' -f $field.Name, [Convert]::ToInt64($field.GetRawConstantValue()))
        }
    }
    else {
        $properties = @($ModelType.GetProperties([System.Reflection.BindingFlags] 'Instance, Public, DeclaredOnly') | Sort-Object Name)
        $lines += ''
        $lines += '## Structure'
        $lines += ''
        if ($properties.Count -gt 0) {
            $lines += '| Property | Type | Nullable | Notes |'
            $lines += '| --- | --- | --- | --- |'
            foreach ($prop in $properties) {
                $propType = Get-FriendlyTypeName -Type $prop.PropertyType
                $nullable = Get-NullableDescriptor -Type $prop.PropertyType
                $lines += ('| {0} | `{1}` | {2} | — |' -f $prop.Name, $propType, $nullable)
            }
        }
        else {
            $lines += '_No public instance properties declared on this type._'
        }
    }

    $lines += ''
    $lines += '## Serialization'
    $lines += ''
    $lines += '- Namespace: `PSImmyBot.Models`'
    $lines += ('- Source file: `Models/{0}`' -f $ModelFile.Name)
    $lines += '- Serializer: `System.Text.Json`'

    $lines += ''
    $lines += '## Notes'
    $lines += ''
    $lines += 'This page was generated automatically from the compiled PSImmyBot assembly via `HelperScripts/GenerateDocs.ps1`. Regenerate after model changes to keep details current.'

    return $lines
}

$assemblyPath = Ensure-AssemblyReady -RootPath $Root
$assembly = [System.Reflection.Assembly]::LoadFrom($assemblyPath)
$cmdletBaseType = [System.Management.Automation.Cmdlet]

$cmdlets = $assembly.GetTypes() |
Where-Object { $_.IsClass -and -not $_.IsAbstract -and $_.IsSubclassOf($cmdletBaseType) } |
Sort-Object FullName

$cmdletDocsDir = Join-Path $Root 'docs/cmdlets'
$modelDocsDir = Join-Path $Root 'docs/models'
New-Item -ItemType Directory -Force -Path $cmdletDocsDir | Out-Null
New-Item -ItemType Directory -Force -Path $modelDocsDir | Out-Null

foreach ($type in $cmdlets) {
    $cmdletAttr = $type.GetCustomAttributes([System.Management.Automation.CmdletAttribute], $false)
    if (-not $cmdletAttr -or $cmdletAttr.Length -eq 0) {
        continue
    }
    $cmdletAttr = $cmdletAttr[0]
    $cmdletName = "{0}-{1}" -f $cmdletAttr.VerbName, $cmdletAttr.NounName
    $sourcePath = Join-Path $Root "Cmdlets/$($type.Name).cs"
    $sourceText = if (Test-Path $sourcePath) { Get-Content -Path $sourcePath -Raw } else { '' }
    $serviceInfo = Get-ServiceCallInfo -SourceText $sourceText
    $parameters = @(Get-ParameterMetadata -CmdletType $type)

    $tableRows = @()
    foreach ($param in $parameters) {
        $positionText = if ($param.Positions.Count -gt 0) { ($param.Positions -join ', ') } else { '—' }
        $setsText = ($param.ParameterSets -join ', ')
        $pipelineText = Get-PipelineText -Value $param.PipelineValue -Property $param.PipelineProperty
        $tableRows += ('| {0} | `{1}` | {2} | {3} | {4} | {5} |' -f $param.Name, $param.Type, $param.Mandatory, $positionText, $setsText, $pipelineText)
    }

    $parameterSetNames = [System.Collections.Generic.HashSet[string]]::new()
    foreach ($param in $parameters) {
        foreach ($set in $param.ParameterSets) {
            $null = $parameterSetNames.Add($set)
        }
    }
    if ($parameterSetNames.Count -eq 0) {
        $null = $parameterSetNames.Add('All')
    }

    $behaviorBullets = Build-BehaviorBullets -ServiceInfo $serviceInfo -SourceText $sourceText
    $supportsShouldProcess = $cmdletAttr.SupportsShouldProcess
    $supportsPaging = $cmdletAttr.SupportsPaging
    $supportsTransactions = $cmdletAttr.SupportsTransactions
    $defaultParameterSetName = if ([string]::IsNullOrWhiteSpace($cmdletAttr.DefaultParameterSetName)) { 'None' } else { $cmdletAttr.DefaultParameterSetName }
    $confirmImpact = if ($cmdletAttr.ConfirmImpact) { $cmdletAttr.ConfirmImpact } else { 'None' }

    $httpMethodText = if ($serviceInfo.HttpMethod) { $serviceInfo.HttpMethod } else { 'Custom' }
    $endpointText = if ($serviceInfo.Endpoint) { $serviceInfo.Endpoint } else { 'Not applicable' }
    $returnTypeText = if ($serviceInfo.ReturnType) { $serviceInfo.ReturnType } else { 'Varies/none' }

    $lines = @()
    $lines += '---'
    $lines += "title: $cmdletName"
    $lines += '---'
    $lines += ''
    $lines += "# $cmdletName"
    $lines += ''
    $lines += '| Detail | Value |'
    $lines += '| --- | --- |'
    $lines += ('| Class | `{0}` |' -f $type.FullName)
    $lines += ('| Source | `Cmdlets/{0}.cs` |' -f $type.Name)
    $lines += "| HTTP Method | $httpMethodText |"
    $lines += "| Endpoint | $endpointText |"
    $lines += ('| Return Type | `{0}` |' -f $returnTypeText)
    $lines += "| SupportsShouldProcess | $supportsShouldProcess |"
    $lines += "| SupportsPaging | $supportsPaging |"
    $lines += "| SupportsTransactions | $supportsTransactions |"
    $lines += "| ConfirmImpact | $confirmImpact |"
    $lines += "| Default Parameter Set | $defaultParameterSetName |"
    $lines += ''
    $lines += '## Behavior'
    foreach ($bullet in $behaviorBullets) {
        $lines += "- $bullet"
    }

    if ($parameters.Count -gt 0) {
        $lines += ''
        $lines += '## Parameters'
        $lines += ''
        $lines += '| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |'
        $lines += '| --- | --- | --- | --- | --- | --- |'
        $lines += $tableRows

        $lines += ''
        $lines += '### Parameter sets'
        $lines += ''
        foreach ($setName in ($parameterSetNames | Sort-Object)) {
            $lines += ('- `{0}`' -f $setName)
        }
    }
    else {
        $lines += ''
        $lines += '## Parameters'
        $lines += ''
        $lines += '_This cmdlet does not expose custom parameters._'
    }

    $lines += ''
    $lines += '## Outputs'
    $lines += ''
    if ($serviceInfo.HttpMethod) {
        $lines += ('- `{0}` records produced by `ImmyBotApiService.{1}`' -f $returnTypeText, $serviceInfo.HttpMethod)
    }
    else {
        $lines += '- See source for specific output behavior.'
    }

    $lines += ''
    $lines += '## Notes'
    $lines += ''
    $lines += 'This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.'

    $targetPath = Join-Path $cmdletDocsDir "$cmdletName.md"
    Set-Content -Path $targetPath -Value ($lines -join [Environment]::NewLine) -Encoding UTF8
}

$modelTypes = $assembly.GetTypes() | Where-Object { $_.Namespace -eq 'PSImmyBot.Models' }
$modelLookup = @{}
foreach ($modelType in $modelTypes) {
    $modelLookup[$modelType.Name] = $modelType
}

$models = Get-ChildItem -Path (Join-Path $Root 'Models') -Filter '*.cs' | Sort-Object Name
foreach ($model in $models) {
    $modelName = $model.BaseName
    $matchedType = $null
    if ($modelLookup.ContainsKey($modelName)) {
        $matchedType = $modelLookup[$modelName]
    }

    $contentLines = Build-ModelDoc -ModelFile $model -ModelType $matchedType
    $targetPath = Join-Path $modelDocsDir "$modelName.md"
    Set-Content -Path $targetPath -Value ($contentLines -join [Environment]::NewLine) -Encoding UTF8
}
