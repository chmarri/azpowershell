### Example 1: Get a Windows Virtual Desktop UserSession by name
```powershell
Get-AzWvdUserSession -ResourceGroupName ResourceGroupName -HostPoolName HostPoolName -SessionHostName SessionHostName -Id 2
```

```output
Name                           Type
----                           ----
HostPoolName/SessionHostName/2 Microsoft.DesktopVirtualization/hostpools/sessionhosts/usersessions
```

This command gets a Windows Virtual Desktop UserSession in a Session Host.

### Example 2: List Windows Virtual Desktop UserSessions
```powershell
Get-AzWvdUserSession -ResourceGroupName ResourceGroupName -HostPoolName HostPoolName -SessionHostName SessionHostName
```

```output
Name                           Type
----                           ----
HostPoolName/SessionHostName/2 Microsoft.DesktopVirtualization/hostpools/sessionhosts/usersessions
HostPoolName/SessionHostName/3 Microsoft.DesktopVirtualization/hostpools/sessionhosts/usersessions
```

This command lists a Windows Virtual Desktop UserSessions in a Session Host.

### Example 3: List Windows Virtual Desktop UserSessions in host pool
```powershell
Get-AzWvdUserSession -ResourceGroupName ResourceGroupName -HostPoolName HostPoolName
```

```output
Name                           Type
----                           ----
HostPoolName/SessionHostName/2 Microsoft.DesktopVirtualization/hostpools/sessionhosts/usersessions
HostPoolName/SessionHostName/3 Microsoft.DesktopVirtualization/hostpools/sessionhosts/usersessions
```

This command lists a Windows Virtual Desktop UserSessions in a Session Host in a host pool.

