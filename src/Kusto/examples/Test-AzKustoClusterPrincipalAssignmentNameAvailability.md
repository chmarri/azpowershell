### Example 1: Check the availability of a cluster principalassignment name which is in use
```powershell
Test-AzKustoClusterPrincipalAssignmentNameAvailability -ResourceGroupName "testrg" -ClusterName "testnewkustocluster" -Name "myprincipal"
```

```output
Message                                                                                                        Name            NameAvailable Reason
-------                                                                                                        ----            ------------- ------
PrincipalAssignment myprincipal already exists in cluster testnewkustocluster. Please select a different name. myprincipal   False
```

The above command returns whether or not a PrincipalAssignment named "myprincipal" exists in the cluster "testnewkustocluster".

### Example 2: Check the availability of a cluster principalassignment name which is not in use
```powershell
Test-AzKustoClusterPrincipalAssignmentNameAvailability -ResourceGroupName "testrg" -ClusterName "testnewkustocluster" -Name "newprincipal"
```

```output
Message Name                  NameAvailable Reason
------- ----                  ------------- ------
        availablekustocluster True
```

The above command returns whether or not a PrincipalAssignment named "newprincipal" exists in the cluster "testnewkustocluster".
