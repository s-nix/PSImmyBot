

function Set-UpperCase {
  param (
    [string]$InputString
  )
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
      $objectPrimitiveType
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
    #$cmdletFilePath = "Cmdlets/Get$targetMethodName.cs"
    #$cmdletPayload | Out-File -FilePath $cmdletFilePath -Encoding UTF8
    Write-Host $cmdletPayload
    Write-Host "Generated cmdlet: Get$targetMethodName at $cmdletFilePath"
  }
}

ConvertFrom-SwaggerGet -SwaggerFilePath "C:\Users\stephen.nix\Downloads\immy_swagger.json"