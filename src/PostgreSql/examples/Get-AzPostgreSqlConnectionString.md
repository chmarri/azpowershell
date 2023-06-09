### Example 1: Get PostgreSql server connection string by resource group and server name
```powershell
Get-AzPostgreSqlConnectionString -Client ADO.NET -Name PostgreSqlTestServer -ResourceGroupName PostgreSqlTestRG
```

```output
Server=postgresqltestserver.postgres.database.azure.com;Database={your_database};Port=5432;User Id=pwsh@postgresqltestserver;Password={your_password};Ssl Mode=Require;
```

This cmdlet gets PostgreSql server connection string by resource group and server name.

### Example 2: Get PostgreSql server connection string by identity
```powershell
Get-AzPostgreSqlServer -ResourceGroupName PostgreSqlTestRG -ServerName PostgreSqlTestServer | Get-AzPostgreSqlConnectionString -Client PHP
```

```output
host=postgresqltestserver.postgres.database.azure.com port=5432 dbname={your_database} user=pwsh@postgresqltestserver password={your_password} sslmode=require
```

This cmdlet gets PostgreSql server connection string by identity.
