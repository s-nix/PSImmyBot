

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
    $objectPrimitiveType = $swaggerJson.paths.$endpointPath.get.responses.'200'.content.'application/json'.schema.type
    $objectType = $swaggerJson.paths.$endpointPath.get.responses.'200'.content.'application/json'.schema.'$ref' | Split-Path -Leaf -ea 0
    $objectListType = $swaggerJson.paths.$endpointPath.get.responses.'200'.content.'application/json'.schema.items.'$ref' | Split-Path -Leaf -ea 0
    
    $targetMethodName = if ($objectPrimitiveType -and -not $objectType -and -not $objectListType) {
      $endpointPath.TrimStart("/api/v1/").Split("/") | ForEach-Object {
        $_.Split("-") | ForEach-Object { $_.Substring(0, 1).ToUpper() + $_.Substring(1) }
      } -join ""
    }
    elseif ($objectType -and -not $objectListType) {
      $objectType
    }
    elseif ($objectListType) {
      $objectListType
    }
    else {
      Write-Error "Unable to determine target type for endpoint: $endpointPath" -ErrorAction Stop
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
      Write-Error "Unable to determine target type for endpoint: $endpointPath" -ErrorAction Stop
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
    $paramType = $param.schema.'#ref' | Split-Path -Leaf -ea 0
    if (-not $paramType) {
        $paramType = switch ($param.schema.type) {
            "string" { "string" }
            "integer" { "int" }
            "boolean" { "bool" }
            default { "object" }
        }
    }
    "    [Parameter(Mandatory = $($param.required))]`n    public $paramType $paramName { get; set; }`n`n"
})
    protected override void ProcessRecord() {
        string endpoint = `$"$endpointPath`?";
$(foreach ($param in $parameters) {
    $paramName = $param.name
    $paramType = $param.schema.'#ref' | Split-Path -Leaf -ea 0
    if (-not $paramType) {
        $paramType = switch ($param.schema.type) {
            "string" { "string" }
            "integer" { "int" }
            "boolean" { "bool" }
            default { "object" }
        }
    }
    if ($param.in -eq "query") {
        "        endpoint += ConvertToQueryParameters<$paramType>($paramName);`n"
    }
})
        $targetType response = ImmyBotApiService.Get<$targetType>(endpoint).GetAwaiter().GetResult();
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