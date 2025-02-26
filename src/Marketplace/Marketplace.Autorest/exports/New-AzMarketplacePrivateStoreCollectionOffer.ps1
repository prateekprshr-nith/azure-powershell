
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
Update or add an offer to a specific collection of the private store.
.Description
Update or add an offer to a specific collection of the private store.
.Example
$acc = @{Accessibility = "azure_managedservices_professional"}
New-AzMarketplacePrivateStoreCollectionOffer -CollectionId fdb889a1-cf3e-49f0-95b8-2bb012fa01f1 -PrivateStoreId 7f5402e4-e8f4-46bd-9bd1-8d27866a606b  -OfferId aumatics.azure_managedservices -Plan $acc

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IMarketplaceIdentity
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IOffer
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IOffer
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

COLLECTIONINPUTOBJECT <IMarketplaceIdentity>: Identity Parameter
  [AdminRequestApprovalId <String>]: The admin request approval ID to get create or update
  [CollectionId <String>]: The collection ID
  [Id <String>]: Resource identity path
  [OfferId <String>]: The offer ID to update or delete
  [PrivateStoreId <String>]: The store ID - must use the tenant ID
  [RequestApprovalId <String>]: The request approval ID to get create or update

PAYLOAD <IOffer>: The privateStore offer data structure.
  [ETag <String>]: Identifier for purposes of race condition
  [IconFileUri <IOfferPropertiesIconFileUris>]: Icon File Uris
    [(Any) <String>]: This indicates any property can be added to this object.
  [Plan <List<IPlan>>]: Offer plans
    [Accessibility <String>]: Plan accessibility
  [SpecificPlanIdsLimitation <List<String>>]: Plan ids limitation for this offer
  [UpdateSuppressedDueIdempotence <Boolean?>]: Indicating whether the offer was not updated to db (true = not updated). If the allow list is identical to the existed one in db, the offer would not be updated.

PLAN <IPlan[]>: Offer plans
  [Accessibility <String>]: Plan accessibility

PRIVATESTOREINPUTOBJECT <IMarketplaceIdentity>: Identity Parameter
  [AdminRequestApprovalId <String>]: The admin request approval ID to get create or update
  [CollectionId <String>]: The collection ID
  [Id <String>]: Resource identity path
  [OfferId <String>]: The offer ID to update or delete
  [PrivateStoreId <String>]: The store ID - must use the tenant ID
  [RequestApprovalId <String>]: The request approval ID to get create or update
.Link
https://learn.microsoft.com/powershell/module/az.marketplace/new-azmarketplaceprivatestorecollectionoffer
#>
function New-AzMarketplacePrivateStoreCollectionOffer {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IOffer])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Path')]
    [System.String]
    # The offer ID to update or delete
    ${OfferId},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Parameter(ParameterSetName='CreateViaIdentityPrivateStore', Mandatory)]
    [Parameter(ParameterSetName='CreateViaIdentityPrivateStoreExpanded', Mandatory)]
    [Parameter(ParameterSetName='CreateViaJsonFilePath', Mandatory)]
    [Parameter(ParameterSetName='CreateViaJsonString', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Path')]
    [System.String]
    # The collection ID
    ${CollectionId},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Parameter(ParameterSetName='CreateViaJsonFilePath', Mandatory)]
    [Parameter(ParameterSetName='CreateViaJsonString', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Path')]
    [System.String]
    # The store ID - must use the tenant ID
    ${PrivateStoreId},

    [Parameter(ParameterSetName='CreateViaIdentityCollection', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='CreateViaIdentityCollectionExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IMarketplaceIdentity]
    # Identity Parameter
    # To construct, see NOTES section for COLLECTIONINPUTOBJECT properties and create a hash table.
    ${CollectionInputObject},

    [Parameter(ParameterSetName='CreateViaIdentityPrivateStore', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='CreateViaIdentityPrivateStoreExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IMarketplaceIdentity]
    # Identity Parameter
    # To construct, see NOTES section for PRIVATESTOREINPUTOBJECT properties and create a hash table.
    ${PrivateStoreInputObject},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityCollectionExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityPrivateStoreExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Body')]
    [System.String]
    # Identifier for purposes of race condition
    ${ETag},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityCollectionExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityPrivateStoreExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IOfferPropertiesIconFileUris]))]
    [System.Collections.Hashtable]
    # Icon File Uris
    ${IconFileUri},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityCollectionExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityPrivateStoreExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPlan[]]
    # Offer plans
    # To construct, see NOTES section for PLAN properties and create a hash table.
    ${Plan},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityCollectionExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityPrivateStoreExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Body')]
    [System.String[]]
    # Plan ids limitation for this offer
    ${SpecificPlanIdLimitation},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityCollectionExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityPrivateStoreExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Indicating whether the offer was not updated to db (true = not updated).
    # If the allow list is identical to the existed one in db, the offer would not be updated.
    ${UpdateSuppressedDueIdempotence},

    [Parameter(ParameterSetName='CreateViaIdentityCollection', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='CreateViaIdentityPrivateStore', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IOffer]
    # The privateStore offer data structure.
    # To construct, see NOTES section for PAYLOAD properties and create a hash table.
    ${Payload},

    [Parameter(ParameterSetName='CreateViaJsonFilePath', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Body')]
    [System.String]
    # Path of Json file supplied to the Create operation
    ${JsonFilePath},

    [Parameter(ParameterSetName='CreateViaJsonString', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Body')]
    [System.String]
    # Json string supplied to the Create operation
    ${JsonString},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Category('Runtime')]
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

        if ($null -eq [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion) {
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion = $PSVersionTable.PSVersion.ToString()
        }         
        $preTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        if ($preTelemetryId -eq '') {
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId =(New-Guid).ToString()
            [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
        } else {
            $internalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
            if ($internalCalledCmdlets -eq '') {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $MyInvocation.MyCommand.Name
            } else {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets += ',' + $MyInvocation.MyCommand.Name
            }
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = 'internal'
        }

        $mapping = @{
            CreateExpanded = 'Az.Marketplace.private\New-AzMarketplacePrivateStoreCollectionOffer_CreateExpanded';
            CreateViaIdentityCollection = 'Az.Marketplace.private\New-AzMarketplacePrivateStoreCollectionOffer_CreateViaIdentityCollection';
            CreateViaIdentityCollectionExpanded = 'Az.Marketplace.private\New-AzMarketplacePrivateStoreCollectionOffer_CreateViaIdentityCollectionExpanded';
            CreateViaIdentityPrivateStore = 'Az.Marketplace.private\New-AzMarketplacePrivateStoreCollectionOffer_CreateViaIdentityPrivateStore';
            CreateViaIdentityPrivateStoreExpanded = 'Az.Marketplace.private\New-AzMarketplacePrivateStoreCollectionOffer_CreateViaIdentityPrivateStoreExpanded';
            CreateViaJsonFilePath = 'Az.Marketplace.private\New-AzMarketplacePrivateStoreCollectionOffer_CreateViaJsonFilePath';
            CreateViaJsonString = 'Az.Marketplace.private\New-AzMarketplacePrivateStoreCollectionOffer_CreateViaJsonString';
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        if ($null -ne $MyInvocation.MyCommand -and [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PromptedPreviewMessageCmdlets -notcontains $MyInvocation.MyCommand.Name -and [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.MessageAttributeHelper]::ContainsPreviewAttribute($cmdInfo, $MyInvocation)){
            [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.MessageAttributeHelper]::ProcessPreviewMessageAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PromptedPreviewMessageCmdlets.Enqueue($MyInvocation.MyCommand.Name)
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }

    finally {
        $backupTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        $backupInternalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
    }

}
end {
    try {
        $steppablePipeline.End()

        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $backupTelemetryId
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $backupInternalCalledCmdlets
        if ($preTelemetryId -eq '') {
            [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
