function ConvertFrom-Models {
    [CmdletBinding()]
    param ()
    $modelFiles = Get-ChildItem -Path "Models" -Filter "*.cs" -Recurse
    foreach ($modelFile in $modelFiles) {
        $lines = Get-Content -Path $modelFile.FullName
        if (!($lines | Select-String -Pattern "public record")) {
            continue
        }
        $className = ($lines | Select-String -Pattern "public record (\w+)").Matches[0].Groups[1].Value
        $argLines = [System.Collections.ArrayList]::new()
        $argNames = [System.Collections.ArrayList]::new()
        foreach ($line in $lines) {
            if ($line -match "#pragma") {
                continue
            }
            $multipleArgs = $line -split ","
            foreach ($arg in $multipleArgs) {
                if ($arg -match "(\w+\??|\w+<\w+\??>\??|\w+\[\]+\??) (\w+)(,|\);|$)") {
                    $type = $matches[1]
                    $name = $matches[2]
                    $typeRequired = ($type -notmatch "\?$").ToString().ToLower()
                    $requiredString = if ($typeRequired -eq 'true') { " required" } else { "" }
                    $argNames.Add($name) | Out-Null
                    $argLines.Add("    [Parameter(Mandatory = $typeRequired)] public$requiredString $type $name { get; set; }") | Out-Null
                }
            }
            # if ($line -match "(\w+\??|\w+<\w+\??>\??|\w+\[\]+\??) (\w+)(,|\);|$)") {
            #     $type = $matches[1]
            #     $name = $matches[2]
            #     $typeRequired = ($type -notmatch "\?$").ToString().ToLower()
            #     $requiredString = if ($typeRequired -eq 'true') { " required" } else { "" }
            #     $argNames.Add($name) | Out-Null
            #     $argLines.Add("    [Parameter(Mandatory = $typeRequired)] public$requiredString $type $name { get; set; }") | Out-Null
            # }
        }
        $output = @"
using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Commands;

[Cmdlet(VerbsCommon.New, "$className")]
public class New$className : Cmdlet {
$($argLines -join "`n")

    protected override void ProcessRecord() {
        $className outputObject = new($($argNames -join ", "));
        WriteObject(outputObject);
    }
}
"@
        $outputPath = "Cmdlets/New$className.cs"
        $output | Out-File -FilePath $outputPath -Encoding UTF8
    }
}

ConvertFrom-Models