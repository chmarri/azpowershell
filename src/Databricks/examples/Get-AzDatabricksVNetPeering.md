### Example 1: List all vnet peering under a databricks
```powershell
Get-AzDatabricksVNetPeering -WorkspaceName databricks-test01 -ResourceGroupName lucas-manual-test
```

```output
Name            Type
----            ----
vnetpeering-t01
vnetpeering-t02
```

This command lists all vnet peering under a databricks.

### Example 2: Get a vnet peering
```powershell
Get-AzDatabricksVNetPeering -ResourceGroupName lucas-manual-test -WorkspaceName databricks-test01 -Name MyPeering-test01
```

```output
Name             Type
----             ----
MyPeering-test01
```

This command gets a vnet peering.

### Example 3: Get a vnet peering by object
```powershell
New-AzDatabricksVNetPeering -Name vnetpeering-t02 -WorkspaceName databricks-test01 -ResourceGroupName lucas-manual-test -RemoteVirtualNetworkId '/subscriptions/xxxxx-xxxx-xxx-xxxxx/resourceGroups/azure-manual-test/providers/Microsoft.Network/virtualNetworks/vnet-test02' | Get-AzDatabricksVNetPeering
```

```output
Name            Type
----            ----
vnetpeering-t02
```

This command gets a vnet peering by object.

