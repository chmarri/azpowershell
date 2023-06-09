### Example 1: Get connection string by name
```powershell
Get-AzPostgreSqlFlexibleServerConnectionString -Client ADO.NET -ResourceGroupName PowershellPostgreSqlTest -Name postgresql-test
```

```output
Server=postgresql-test.postgres.database.azure.com;Database={your_database};Port=5432;User Id=adminuser;Password={your_password};
```

This cmdlet shows connection string of a client by server name. 

### Example 2: Get PostgreSql server connection string by identity
```powershell
Get-AzPostgreSqlFlexibleServer -ResourceGroupName PostgreSqlTestRG -ServerName PostgreSqlTestServer | Get-AzPostgreSqlFlexibleServerConnectionString -Client PHP
```

```output
host=postgresqltestserver.postgres.database.azure.com port=5432 dbname={your_database} user=pwsh password={your_password} sslmode=require
```

This cmdlet gets PostgreSql server connection string by identity.