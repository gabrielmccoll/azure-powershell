---
external help file: Microsoft.Azure.PowerShell.Cmdlets.Cdn.dll-Help.xml
Module Name: Az.Cdn
online version: https://docs.microsoft.com/en-us/powershell/module/az.cdn/new-azcdnwafratelimitrule
schema: 2.0.0
---

# New-AzCdnWafRateLimitRule

## SYNOPSIS
Creates a CDN WAF rate limit rule for use in a policy.

## SYNTAX

```
New-AzCdnWafRateLimitRule -RateLimitRuleName <String> [-Disabled] -Priority <Int32>
 -MatchCondition <PSMatchCondition[]> -Action <PSActionType> -RateLimitThreshold <Int32>
 -RateLimitDurationInMinutes <Int32> [-DefaultProfile <IAzureContextContainer>] [<CommonParameters>]
```

## DESCRIPTION
The **New-AzCdnWafRateLimitRule** cmdlet creates an Azure Content Delivery Network (CDN) Web
Application Firewall (WAF) rate limit rule locally, for use in creating a policy.

## EXAMPLES

### Example 1
```powershell
PS C:\> $rateLimitRule1 = New-AzCdnWafRateLimitRule -RateLimitRuleName example-limit -Priority 5 -MatchCondition $condition -Action Redirect -RateLimitThreshold 100 -RateLimitDurationInMinutes 1
```

Saves a custom rule named `redirect-rule` that redirects requests matching `$condition` with priority 10 for use in
creating a CDN WAF policy.

## PARAMETERS

### -Action
The action to take when the rule is matched.

```yaml
Type: Microsoft.Azure.Commands.Cdn.Models.WebApplicationFirewall.PSActionType
Parameter Sets: (All)
Aliases:
Accepted values: Allow, Block, Log, Redirect

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: Microsoft.Azure.Commands.Common.Authentication.Abstractions.Core.IAzureContextContainer
Parameter Sets: (All)
Aliases: AzContext, AzureRmContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Disabled
Disables the rate limit rule.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MatchCondition
The condition under which the rule is matched.

```yaml
Type: Microsoft.Azure.Commands.Cdn.Models.WebApplicationFirewall.PSMatchCondition[]
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Priority
The priority of the rate limit rule.

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RateLimitDurationInMinutes
The rate limit duration in minutes.

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RateLimitRuleName
The name of the rate limit rule.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: Name

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RateLimitThreshold
The rate limit threshold.

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None

## OUTPUTS

### Microsoft.Azure.Commands.Cdn.Models.WebApplicationFirewall.PSRateLimitRule

## NOTES

## RELATED LINKS