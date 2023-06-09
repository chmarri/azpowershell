### Example 1: Get PostgreSql server with default context
```powershell
Get-AzPostgreSqlServer
```

```output
Name                        Location AdministratorLogin Version StorageProfileStorageMb SkuName   SkuTier        SslEnforcement
----                        -------- ------------------ ------- ----------------------- -------   -------        --------------
postgresqltestserver        eastus   pwsh               9.6     5120                    GP_Gen5_4 GeneralPurpose Enabled
```

This cmdlet gets PostgreSql server with default context.

### Example 2: Get PostgreSql server by resource group and server name
```powershell
Get-AzPostgreSqlServer -ResourceGroupName PostgreSqlTestRG -Name PostgreSqlTestServer
```

```output
Name                 Location AdministratorLogin Version StorageProfileStorageMb SkuName   SkuTier        SslEnforcement
----                 -------- ------------------ ------- ----------------------- -------   -------        --------------
postgresqltestserver eastus   pwsh               9.6     5120                    GP_Gen5_4 GeneralPurpose Enabled
``` 

This cmdlet gets PostgreSql server by resource group and server name.

### Example 3: Lists all the PostgreSql servers in specified resource group
```powershell
Get-AzPostgreSqlServer -ResourceGroupName PostgreSqlTestRG
```

```output
Name                        Location AdministratorLogin Version StorageProfileStorageMb SkuName   SkuTier        SslEnforcement
----                        -------- ------------------ ------- ----------------------- -------   -------        --------------
postgresqltestserver        eastus   pwsh               9.6     5120                    GP_Gen5_4 GeneralPurpose Enabled
```

This cmdlet lists all the PostgreSql servers in specified resource group.

### Example 4: Get PostgreSql server by identity
```powershell
$ID = "/subscriptions/<SubscriptionId>/resourceGroups/PostgreSqlTestRG/providers/Microsoft.DBforPostgreSQL/servers/postgresqltestserver"
Get-AzPostgreSqlServer -InputObject $ID
```

```output
Name                 Location AdministratorLogin Version StorageProfileStorageMb SkuName   SkuTier        SslEnforcement
----                 -------- ------------------ ------- ----------------------- -------   -------        --------------
postgresqltestserver eastus   pwsh               9.6     5120                    GP_Gen5_4 GeneralPurpose Enabled
```

This cmdlet lists gets PostgreSql server by identity.

