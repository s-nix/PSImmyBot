

function Set-UpperCase {
    param (
        [string]$InputString
    )
    $InputString = $InputString.TrimStart("/api/v1/")
    $InputString = $InputString -replace "\/\{.*?\}", ""
    $strings = $InputString.Split("/")
    $result = foreach ($str in $strings) {
        if ($str -ne "") {
            $parts = $str.Split("-")
            $parts | ForEach-Object {
                if ($_.Length -gt 0) {
                    ($_.Substring(0, 1).ToUpper() + $_.Substring(1)).Trim()
                }
            }
        }
    }
    return $result -join ""
}

function ConvertFrom-SwaggerGet {
    [CmdletBinding()]
    param (
        [Parameter(Mandatory = $true)]
        [string]$SwaggerFilePath
    )
    $swaggerContent = Get-Content -Path $SwaggerFilePath -Raw
    $swaggerJson = $swaggerContent | ConvertFrom-Json -Depth 100
    $endpointPaths = $swaggerJson.paths.PSObject.Members.Name | Where-Object { $_ -like "/api*" }
    foreach ($endpointPath in $endpointPaths) {
        if (!$swaggerJson.paths.$endpointPath.get) {
            continue
        }
        $objectPrimitiveType = $swaggerJson.paths.$endpointPath.get.responses.'200'.content.'application/json'.schema.type
        $objectType = $swaggerJson.paths.$endpointPath.get.responses.'200'.content.'application/json'.schema.'$ref' | Split-Path -Leaf -ea 0
        $objectListType = $swaggerJson.paths.$endpointPath.get.responses.'200'.content.'application/json'.schema.items.'$ref' | Split-Path -Leaf -ea 0
    
        $targetMethodName = if ($objectPrimitiveType -and -not $objectType -and -not $objectListType) {
            Set-UpperCase -InputString $endpointPath.TrimStart("/api/v1/")
        }
        elseif ($objectType -and -not $objectListType) {
            $objectType
        }
        elseif ($objectListType) {
            $objectListType
        }
        else {
            #Write-Error "Unable to determine target type for endpoint: $endpointPath" -ErrorAction Stop
            Set-UpperCase -InputString $endpointPath.TrimStart("/api/v1/")
        }
        $targetType = if ($objectPrimitiveType -and -not $objectType -and -not $objectListType) {
            switch ($objectPrimitiveType) {
                "string" { "string" }
                "integer" { "int" }
                "boolean" { "bool" }
                default { "object" }
            }
        }
        elseif ($objectType -and -not $objectListType) {
            $objectType
        }
        elseif ($objectListType) {
            "List<$objectListType>"
        }
        else {
            #Write-Error "Unable to determine target type for endpoint: $endpointPath" -ErrorAction Stop
            "byte[]"
        }
        $parameters = $swaggerJson.paths.$endpointPath.get.parameters
        $cmdletPayload =
        @"
using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "$targetMethodName")]
public class Get$targetMethodName : Cmdlet {
$(foreach ($param in $parameters) {
    $paramName = $param.name
    $paramType = $param.schema.'$ref' | Split-Path -Leaf -ea 0
    $paramRequired = $param.required -eq $true
    if (-not $paramType) {
        $paramType = switch ($param.schema.type) {
            "string" { "string" }
            "integer" { "int" }
            "boolean" { "bool" }
            default { "object" }
        }
    }
    $paramType = if (!$paramRequired) { "$paramType`?" } else { $paramType }
    "    [Parameter(Mandatory = $($paramRequired.ToString().ToLower()))]`n    public $paramType $paramName { get; set; }`n`n"
})
    protected override void ProcessRecord() {
        string endpoint = `$"$endpointPath`?";
$(foreach ($param in $parameters) {
    $paramName = $param.name
    $paramType = $param.schema.'$ref' | Split-Path -Leaf -ea 0
    $paramRequired = $param.required -eq $true
    if (-not $paramType) {
        $paramType = switch ($param.schema.type) {
            "string" { "string" }
            "integer" { "int" }
            "boolean" { "bool" }
            default { "object" }
        }
    }
    $paramType = if (!$paramRequired) { "$paramType`?" } else { $paramType }
    if ($param.in -eq "query") {
        "        endpoint += Globals.ConvertToQueryParameters($paramName);`n"
    }
})
        $targetType response = ImmyBotApiService.Get<$targetType>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
"@
        $cmdletFilePath = "Cmdlets/Get$targetMethodName.cs"
        $cmdletPayload | Out-File -FilePath $cmdletFilePath -Encoding UTF8
    }
}

function ConvertFrom-SwaggerPost {
    [CmdletBinding()]
    param (
        [Parameter(Mandatory = $true)]
        [string]$SwaggerFilePath
    )
    $swaggerContent = Get-Content -Path $SwaggerFilePath -Raw
    $swaggerJson = $swaggerContent | ConvertFrom-Json -Depth 100
    $endpointPaths = $swaggerJson.paths.PSObject.Members.Name | Where-Object { $_ -like "/api*" }
    foreach ($endpointPath in $endpointPaths) {
        if (!$swaggerJson.paths.$endpointPath.post) {
            continue
        }

        $payloadPrimitiveType = $swaggerJson.paths.$endpointPath.post.requestBody.content.'application/json'.schema.type
        $payloadObjectType = $swaggerJson.paths.$endpointPath.post.requestBody.content.'application/json'.schema.'$ref' | Split-Path -Leaf -ea 0
        $payloadObjectListType = $swaggerJson.paths.$endpointPath.post.requestBody.content.'application/json'.schema.items.'$ref' | Split-Path -Leaf -ea 0
        $hasPayload = $payloadPrimitiveType -or $payloadObjectType -or $payloadObjectListType
        $payloadType = if ($payloadPrimitiveType -and -not $payloadObjectType -and -not $payloadObjectListType) {
            switch ($payloadPrimitiveType) {
                "string" { "string" }
                "integer" { "int" }
                "boolean" { "bool" }
                default { "object" }
            }
        }
        elseif ($payloadObjectType -and -not $payloadObjectListType) {
            $payloadObjectType
        }
        elseif ($payloadObjectListType) {
            "List<$payloadObjectListType>"
        }
        else {
            #Write-Error "Unable to determine payload type for endpoint: $endpointPath" -ErrorAction Stop
            "object"
        }
        $returnPrimitiveType = $swaggerJson.paths.$endpointPath.post.responses.'200'.content.'application/json'.schema.type
        $returnObjectType = $swaggerJson.paths.$endpointPath.post.responses.'200'.content.'application/json'.schema.'$ref' | Split-Path -Leaf -ea 0
        $returnObjectListType = $swaggerJson.paths.$endpointPath.post.responses.'200'.content.'application/json'.schema.items.'$ref' | Split-Path -Leaf -ea 0
        $hasReturn = $returnPrimitiveType -or $returnObjectType -or $returnObjectListType

        $targetMethodName = if ($payloadPrimitiveType -and -not $payloadObjectType -and -not $payloadObjectListType) {
            Set-UpperCase -InputString $endpointPath.TrimStart("/api/v1/")
        }
        elseif ($payloadObjectType -and -not $payloadObjectListType) {
            $payloadObjectType
        }
        elseif ($payloadObjectListType) {
            $payloadObjectListType
        }
        else {
            #Write-Error "Unable to determine target type for endpoint: $endpointPath" -ErrorAction Stop
            Set-UpperCase -InputString $endpointPath.TrimStart("/api/v1/")
        }

        $targetMethodName += "Request"

        $targetReturnType = if ($returnPrimitiveType -and -not $returnObjectType -and -not $returnObjectListType) {
            switch ($returnPrimitiveType) {
                "string" { "string" }
                "integer" { "int" }
                "boolean" { "bool" }
                default { "object" }
            }
        }
        elseif ($returnObjectType -and -not $returnObjectListType) {
            $returnObjectType
        }
        elseif ($returnObjectListType) {
            "List<$returnObjectListType>"
        }
        else {
            #Write-Error "Unable to determine target return type for endpoint: $endpointPath" -ErrorAction Stop
            "void"
        }
        $parameters = $swaggerJson.paths.$endpointPath.post.parameters
        $cmdletPayload =
        @"
using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "$targetMethodName")]
public class Send$targetMethodName : Cmdlet {
$(foreach ($param in $parameters) {
    $paramName = $param.name
    $paramType = $param.schema.'$ref' | Split-Path -Leaf -ea 0
    $paramRequired = $param.required -eq $true
    if (-not $paramType) {
        $paramType = switch ($param.schema.type) {
            "string" { "string" }
            "integer" { "int" }
            "boolean" { "bool" }
            default { "object" }
        }
    }
    $paramType = if (!$paramRequired) { "$paramType`?" } else { $paramType }
    "    [Parameter(Mandatory = $($paramRequired.ToString().ToLower()))]`n    public $paramType $paramName { get; set; }`n`n"
})
$(if($hasPayload) {
    "    [Parameter(Mandatory = true)] public $payloadType PayloadBody { get; set; }`n`n"
})
    protected override void ProcessRecord() {
        string endpoint = `$"$endpointPath`?";
$(foreach ($param in $parameters) {
    $paramName = $param.name
    $paramType = $param.schema.'$ref' | Split-Path -Leaf -ea 0
    $paramRequired = $param.required -eq $true
    if (-not $paramType) {
        $paramType = switch ($param.schema.type) {
            "string" { "string" }
            "integer" { "int" }
            "boolean" { "bool" }
            default { "object" }
        }
    }
    $paramType = if (!$paramRequired) { "$paramType`?" } else { $paramType }
    if ($param.in -eq "query") {
        "        endpoint += Globals.ConvertToQueryParameters($paramName);`n"
    }
})
$(if ($hasPayload -and $hasReturn) {
    "        $targetReturnType response = ImmyBotApiService.Post<$targetReturnType>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);"
} elseif ($hasPayload -and -not $hasReturn) {
    "        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();"
} elseif (-not $hasPayload -and $hasReturn) {
    "        $targetReturnType response = ImmyBotApiService.Get<$targetReturnType>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);"
} else {
    "        ImmyBotApiService.Get(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();"
})
    }

})
"@
        $cmdletPayload
        #$cmdletFilePath = "Cmdlets/Send$targetMethodName.cs"
        #$cmdletPayload | Out-File -FilePath $cmdletFilePath -Encoding UTF8
    }
}


# ConvertFrom-SwaggerGet -SwaggerFilePath "C:\Users\stephen.nix\Downloads\immy_swagger.json"
ConvertFrom-SwaggerPost -SwaggerFilePath "C:\Users\stephen.nix\Downloads\immy_swagger.json"
