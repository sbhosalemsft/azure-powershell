﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Commands.StorageSync.Common;
using Microsoft.Azure.Commands.StorageSync.Common.ArgumentCompleters;
using Microsoft.Azure.Commands.StorageSync.Common.Extensions;
using Microsoft.Azure.Commands.StorageSync.Models;
using Microsoft.Azure.Commands.StorageSync.Properties;
using Microsoft.Azure.Management.Internal.Resources.Utilities.Models;
using Microsoft.Azure.Management.StorageSync;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.StorageSync.SyncGroup
{
    /// <summary>
    /// Class RemoveSyncGroupCommand.
    /// Implements the <see cref="Microsoft.Azure.Commands.StorageSync.Common.StorageSyncClientCmdletBase" />
    /// </summary>
    /// <seealso cref="Microsoft.Azure.Commands.StorageSync.Common.StorageSyncClientCmdletBase" />
    [Cmdlet(VerbsCommon.Remove, StorageSyncNouns.NounAzureRmStorageSyncGroup, DefaultParameterSetName = StorageSyncParameterSets.StringParameterSet, SupportsShouldProcess = true), OutputType(typeof(void))]
    public class RemoveSyncGroupCommand : StorageSyncClientCmdletBase
    {
        /// <summary>
        /// Gets or sets the input object.
        /// </summary>
        /// <value>The input object.</value>
        [Parameter(Mandatory = true,
                   ParameterSetName = StorageSyncParameterSets.InputObjectParameterSet,
                   Position = 0,
                   ValueFromPipeline = true,
                   HelpMessage = HelpMessages.SyncGroupInputObjectParameter)]
        [ValidateNotNullOrEmpty]
        public PSSyncGroup InputObject { get; set; }

        /// <summary>
        /// Gets or sets the resource identifier.
        /// </summary>
        /// <value>The resource identifier.</value>
        [Parameter(Mandatory = true,
            Position = 0,
            ParameterSetName = StorageSyncParameterSets.ResourceIdParameterSet,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = HelpMessages.SyncGroupResourceIdParameter)]
        [ValidateNotNullOrEmpty]
        [ResourceIdCompleter(StorageSyncConstants.SyncGroupType)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the name of the resource group.
        /// </summary>
        /// <value>The name of the resource group.</value>
        [Parameter(
           Position = 0,
           Mandatory = true,
            ParameterSetName = StorageSyncParameterSets.StringParameterSet,
           ValueFromPipelineByPropertyName = false,
           HelpMessage = HelpMessages.ResourceGroupNameParameter)]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// Gets or sets the name of the storage synchronize service.
        /// </summary>
        /// <value>The name of the storage synchronize service.</value>
        [Parameter(
            Position = 1,
            ParameterSetName = StorageSyncParameterSets.StringParameterSet,
            Mandatory = true,
            ValueFromPipelineByPropertyName = false,
            HelpMessage = HelpMessages.StorageSyncServiceNameParameter)]
        [StorageSyncServiceCompleter]
        [ValidateNotNullOrEmpty]
        [Alias(StorageSyncAliases.ParentNameAlias)]
        public string StorageSyncServiceName { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [Parameter(Position = 2,
            Mandatory = true,
            ParameterSetName = StorageSyncParameterSets.StringParameterSet,
            ValueFromPipelineByPropertyName = false,
            HelpMessage = HelpMessages.SyncGroupNameParameter)]
        [ValidateNotNullOrEmpty]
        [Alias(StorageSyncAliases.SyncGroupNameAlias)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the force.
        /// </summary>
        /// <value>The force.</value>
        [Parameter(Mandatory = false,
           ValueFromPipelineByPropertyName = true,
           HelpMessage = HelpMessages.SyncGroupForceParameter)]
        public SwitchParameter Force { get; set; }

        /// <summary>
        /// Gets or sets the pass thru.
        /// </summary>
        /// <value>The pass thru.</value>
        [Parameter(Mandatory = false)]
        public SwitchParameter PassThru { get; set; }

        /// <summary>
        /// Gets or sets as job.
        /// </summary>
        /// <value>As job.</value>
        [Parameter(Mandatory = false, HelpMessage = HelpMessages.AsJobParameter)]
        public SwitchParameter AsJob { get; set; }


        /// <summary>
        /// Executes the cmdlet.
        /// </summary>
        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();

            ExecuteClientAction(() =>
            {
                var resourceName = default(string);
                var resourceGroupName = default(string);
                var parentResourceName = default(string);

                if (!string.IsNullOrEmpty(ResourceId))
                {
                    var resourceIdentifier = new ResourceIdentifier(ResourceId);

                    if (!string.Equals(StorageSyncConstants.SyncGroupType, resourceIdentifier.ResourceType, System.StringComparison.OrdinalIgnoreCase))
                    {
                        throw new PSArgumentException(StorageSyncResources.MissingResourceIdErrorMessage);
                    }
                    resourceName = resourceIdentifier.ResourceName;
                    resourceGroupName = resourceIdentifier.ResourceGroupName;
                    parentResourceName = resourceIdentifier.GetParentResourceName(StorageSyncConstants.StorageSyncServiceTypeName);
                }
                else if (InputObject != null)
                {
                    resourceName = InputObject.SyncGroupName;
                    resourceGroupName = InputObject.ResourceGroupName;
                    parentResourceName = InputObject.StorageSyncServiceName;
                }
                else
                {
                    resourceName = Name;
                    resourceGroupName = ResourceGroupName;
                    parentResourceName = StorageSyncServiceName;
                }

                Target = string.Join("/", resourceGroupName, parentResourceName, resourceName);
                ActionMessage = StorageSyncResources.RemoveSyncGroupActionMessage;
                if (ShouldProcess(Target, ActionMessage))
                {
                    if (Force || ShouldContinue(string.Format(StorageSyncResources.RemoveSyncGroupPromptFormat, Target), string.Empty))
                    {
                        StorageSyncClientWrapper.StorageSyncManagementClient.SyncGroups.Delete(resourceGroupName, parentResourceName, resourceName);
                    }
                }
            });

            if (PassThru.IsPresent)
            {
                WriteObject(true);
            }
        }
    }
}
