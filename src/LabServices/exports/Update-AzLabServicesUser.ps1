
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Operation to update a lab user.
.Description
Operation to update a lab user.
.Example
PS C:\> Update-AzLabServicesUser -ResourceGroupName "Group Name" -LabName "Lab Name" -Name "User Name" -AdditionalUsageQuota $(New-TimeSpan -Hours 2)

Name
----
User Name

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.Lab
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUser
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

LAB <Lab>: 
  Location <String>: The geo-location where the resource lives
  [AdditionalCapabilityInstallGpuDriver <EnableState?>]: Flag to pre-install dedicated GPU drivers.
  [AdminUserPassword <String>]: The password for the user. This is required for the TemplateVM createOption.
  [AdminUserUsername <String>]: The username to use when signing in to lab VMs.
  [AutoShutdownProfileDisconnectDelay <TimeSpan?>]: The amount of time a VM will stay running after a user disconnects if this behavior is enabled.
  [AutoShutdownProfileIdleDelay <TimeSpan?>]: The amount of time a VM will idle before it is shutdown if this behavior is enabled.
  [AutoShutdownProfileNoConnectDelay <TimeSpan?>]: The amount of time a VM will stay running before it is shutdown if no connection is made and this behavior is enabled.
  [AutoShutdownProfileShutdownOnDisconnect <EnableState?>]: Whether shutdown on disconnect is enabled
  [AutoShutdownProfileShutdownOnIdle <ShutdownOnIdleMode?>]: Whether a VM will get shutdown when it has idled for a period of time.
  [AutoShutdownProfileShutdownWhenNotConnected <EnableState?>]: Whether a VM will get shutdown when it hasn't been connected to after a period of time.
  [ConnectionProfileClientRdpAccess <ConnectionType?>]: The enabled access level for Client Access over RDP.
  [ConnectionProfileClientSshAccess <ConnectionType?>]: The enabled access level for Client Access over SSH.
  [ConnectionProfileWebRdpAccess <ConnectionType?>]: The enabled access level for Web Access over RDP.
  [ConnectionProfileWebSshAccess <ConnectionType?>]: The enabled access level for Web Access over SSH.
  [Description <String>]: The description of the lab.
  [ImageReferenceId <String>]: Image resource ID
  [ImageReferenceOffer <String>]: The image offer if applicable.
  [ImageReferencePublisher <String>]: The image publisher
  [ImageReferenceSku <String>]: The image SKU
  [ImageReferenceVersion <String>]: The image version specified on creation.
  [NetworkProfileLoadBalancerId <String>]: The external load balancer resource id
  [NetworkProfilePublicIPId <String>]: The external public IP resource id
  [NetworkProfileSubnetId <String>]: The external subnet resource id
  [NonAdminUserPassword <String>]: The password for the user. This is required for the TemplateVM createOption.
  [NonAdminUserUsername <String>]: The username to use when signing in to lab VMs.
  [PlanId <String>]: The ID of the lab plan. Used during resource creation to provide defaults and acts as a permission container when creating a lab via labs.azure.com. Setting a labPlanId on an existing lab provides organization..
  [RosterProfileActiveDirectoryGroupId <String>]: The AAD group ID which this lab roster is populated from. Having this set enables AAD sync mode.
  [RosterProfileLmsInstance <String>]: The base URI identifying the lms instance.
  [RosterProfileLtiClientId <String>]: The unique id of the azure lab services tool in the lms.
  [RosterProfileLtiContextId <String>]: The unique context identifier for the lab in the lms.
  [RosterProfileLtiRosterEndpoint <String>]: The uri of the names and roles service endpoint on the lms for the class attached to this lab.
  [SecurityProfileOpenAccess <EnableState?>]: Whether any user or only specified users can register to a lab.
  [SkuCapacity <Int32?>]: If the SKU supports scale out/in then the capacity integer should be included. If scale out/in is not possible for the resource this may be omitted.
  [SkuFamily <String>]: If the service has different generations of hardware, for the same SKU, then that can be captured here.
  [SkuName <String>]: The name of the SKU. Ex - P3. It is typically a letter+number code
  [SkuSize <String>]: The SKU size. When the name field is the combination of tier and some other value, this would be the standalone code. 
  [SkuTier <SkuTier?>]: This field is required to be implemented by the Resource Provider if the service has more than one tier, but is not required on a PUT.
  [SystemDataCreatedAt <DateTime?>]: The timestamp of resource creation (UTC).
  [SystemDataCreatedBy <String>]: The identity that created the resource.
  [SystemDataCreatedByType <CreatedByType?>]: The type of identity that created the resource.
  [SystemDataLastModifiedAt <DateTime?>]: The timestamp of resource last modification (UTC)
  [SystemDataLastModifiedBy <String>]: The identity that last modified the resource.
  [SystemDataLastModifiedByType <CreatedByType?>]: The type of identity that last modified the resource.
  [Title <String>]: The title of the lab.
  [VirtualMachineProfileCreateOption <CreateOption?>]: Indicates what lab virtual machines are created from.
  [VirtualMachineProfileUsageQuota <TimeSpan?>]: The initial quota alloted to each lab user. Must be a time span between 0 and 9999 hours.
  [VirtualMachineProfileUseSharedPassword <EnableState?>]: Enabling this option will use the same password for all user VMs.
  [Tag <ITrackedResourceTags>]: Resource tags.
    [(Any) <String>]: This indicates any property can be added to this object.
.Link
https://docs.microsoft.com/powershell/module/az.labservices/update-azlabservicesuser
#>
function Update-AzLabServicesUser {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.IUser])]
[CmdletBinding(DefaultParameterSetName='ResourceId', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Path')]
    [System.String]
    # The name of the lab that uniquely identifies it within containing lab account.
    # Used in resource URIs.
    ${LabName},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Parameter(ParameterSetName='Lab', Mandatory)]
    [Alias('UserName')]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Path')]
    [System.String]
    # The name of the user that uniquely identifies it within containing lab.
    # Used in resource URIs.
    ${Name},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Lab', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.Lab]
    # To construct, see NOTES section for LAB properties and create a hash table.
    ${Lab},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.TimeSpan]
    # The amount of usage quota time the user gets in addition to the lab usage quota.
    ${AdditionalUsageQuota},

    [Parameter(ParameterSetName='ResourceId', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Body')]
    [System.String]
    ${ResourceId},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            UpdateExpanded = 'Az.LabServices.private\Update-AzLabServicesUser_UpdateExpanded';
            Lab = 'Az.LabServices.custom\Update-AzLabServicesUser_Lab';
            ResourceId = 'Az.LabServices.custom\Update-AzLabServicesUser_ResourceId';
        }
        if (('UpdateExpanded', 'Lab', 'ResourceId') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
