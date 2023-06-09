### Example 1: Get a Windows Virtual Desktop Scaling Plan by name
```powershell
Get-AzWvdScalingPlan -ResourceGroupName ResourceGroupName -Name scalingPlan1
```

```output
Location      Name             Type
--------      ----             ----
westcentralus scalingPlan1     Microsoft.DesktopVirtualization/scalingplans
```

This command gets a Windows Virtual Desktop Scaling Plan in a Resource Group.

### Example 2: List Windows Virtual Desktop Scaling Plans
```powershell
Get-AzWvdScalingPlan -ResourceGroupName ResourceGroupName
```

```output
Location      Name             Type
--------      ----             ----
westcentralus scalingPlan1     Microsoft.DesktopVirtualization/scalingplans
westcentralus scalingPlan2     Microsoft.DesktopVirtualization/scalingplans
```

This command lists all the Windows Virtual Desktop Scaling Plans in a Resource Group.
