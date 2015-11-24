$hintPathPattern = @"
<HintPath>(\d|\w|\s|\.|\\)*packages
"@

$currentLocation = Get-Location

ls -Recurse -include *.csproj, *.sln, *.fsproj, *.vbproj |
  foreach {
	$projectPath = split-path $_.FullName
	Set-Location $projectPath
	$packagePath = Resolve-Path -relative C:\Dev\packages
    $content = cat $_.FullName | Out-String
    $origContent = $content
    $content = $content -replace $hintPathPattern, "<HintPath>$packagePath"
    if ($origContent -ne $content)
    {	
        $content | out-file -encoding "UTF8" $_.FullName
        write-host Fixed hint paths in $_.Name
    }		    
}

Set-Location $currentLocation