if(($null -eq $TestName) -or ($TestName -contains 'Remove-AzWorkloadsSapDatabaseInstance'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Remove-AzWorkloadsSapDatabaseInstance.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Remove-AzWorkloadsSapDatabaseInstance' {
    It 'Delete' {
        Remove-AzWorkloadsSapDatabaseInstance -Name $env.SapDatabseInstanceName -ResourceGroupName $env.DeletionRG -SapVirtualInstanceName $env.DeletionVIS
    }

    It 'DeleteViaIdentity' {
        Remove-AzWorkloadsSapDatabaseInstance -InputObject $env.DeletionVISDbID
    }
}
