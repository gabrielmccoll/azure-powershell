---
external help file:
Module Name: Az.WebSite
online version: https://docs.microsoft.com/en-us/powershell/module/az.website/get-azwebsitesourcecontrol
schema: 2.0.0
---

# Get-AzWebSiteSourceControl

## SYNOPSIS
Gets source control token

## SYNTAX

### List1 (Default)
```
Get-AzWebSiteSourceControl [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### Get1
```
Get-AzWebSiteSourceControl -Type <String> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### GetViaIdentity1
```
Get-AzWebSiteSourceControl -InputObject <IWebSiteIdentity> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

## DESCRIPTION
Gets source control token

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.WebSite.Models.IWebSiteIdentity
Parameter Sets: GetViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Type
Type of source control

```yaml
Type: System.String
Parameter Sets: Get1
Aliases: SourceControlType

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.WebSite.Models.IWebSiteIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.WebSite.Models.Api20180201.ISourceControl

## ALIASES

## NOTES

## RELATED LINKS
