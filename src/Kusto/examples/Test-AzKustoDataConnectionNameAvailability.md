### Example 1: Check the availability of a Data Connection name which is in use
```powershell
Test-AzKustoDataConnectionNameAvailability -ClusterName testnewkustocluster -DatabaseName mykustodatabase -ResourceGroupName testrg -Name mykustodataconnection
```

```output
Message                                                                                                                                                          Name                  NameAvailable Reason
-------                                                                                                                                                          ----                  ------------- ------
Data Connection mykustodataconnection already exists in database mykustodatabase in cluster testnewkustocluster. Please select a different data connection name. mykustodataconnection False         AlreadyExists
```

The above command returns whether or not a Data Connection named "mykustodataconnection" exists in the "mykustodatabase" database.

### Example 2: Check the availability of a Data Connection name which is not in use
```powershell
Test-AzKustoDataConnectionNameAvailability -ClusterName testnewkustocluster -DatabaseName mykustodatabase -ResourceGroupName testrg -Name mydataconnection
```

```output
Message Name             NameAvailable Reason
------- ----             ------------- ------
        mydataconnection True
```

The above command returns whether or not a Data Connection named "mydataconnection" exists in the "mykustodatabase" database.
