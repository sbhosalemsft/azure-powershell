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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Commands.Network.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.Tags;
using Microsoft.Azure.Management.Network;
using Microsoft.WindowsAzure.Commands.Common.CustomAttributes;
using MNM = Microsoft.Azure.Management.Network.Models;

namespace Microsoft.Azure.Commands.Network
{
    [Cmdlet(VerbsCommon.New, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "FirewallPolicy", SupportsShouldProcess = true, DefaultParameterSetName = DefaultParameterSet), OutputType(typeof(PSAzureFirewall))]
    public class NewAzureFirewallPolicyCommand : AzureFirewallPolicyBaseCmdlet
    {
        private const string DefaultParameterSet = "Default";

        [Alias("ResourceName")]
        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The resource name.")]
        [ValidateNotNullOrEmpty]
        public virtual string Name { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The resource group name.")]
        [ValidateNotNullOrEmpty]
        public virtual string ResourceGroupName { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "location.")]
        [ValidateNotNullOrEmpty]
        public virtual string Location { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The list of AzureFirewallApplicationRuleCollections")]
        public PSAzureFirewallApplicationRuleCollection[] ApplicationRuleCollection { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The list of AzureFirewallNatRuleCollections")]
        public PSAzureFirewallNatRuleCollection[] NatRuleCollection { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The list of AzureFirewallNetworkRuleCollections")]
        public PSAzureFirewallNetworkRuleCollection[] NetworkRuleCollection { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The operation mode for Threat Intelligence.")]
        [ValidateSet(
            MNM.AzureFirewallThreatIntelMode.Alert,
            MNM.AzureFirewallThreatIntelMode.Deny,
            MNM.AzureFirewallThreatIntelMode.Off,
            IgnoreCase = false)]
        public string ThreatIntelMode { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "A hashtable which represents resource tags.")]
        public Hashtable Tag { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "Do not ask for confirmation if you want to overwrite a resource")]
        public SwitchParameter Force { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "Run cmdlet in the background")]
        public SwitchParameter AsJob { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "A list of availability zones denoting where the firewall needs to come from.")]
        public string[] Zone { get; set; }

        public override void Execute()
        {

            base.Execute();

            var present = this.IsAzureFirewallPresent(this.ResourceGroupName, this.Name);
            ConfirmAction(
                Force.IsPresent,
                string.Format(Properties.Resources.OverwritingResource, Name),
                Properties.Resources.CreatingResourceMessage,
                Name,
                () => WriteObject(this.CreateAzureFirewall()),
                () => present);
        }

        private PSAzureFirewall CreateAzureFirewall()
        {
            var firewall = new PSAzureFirewall()
            {
                Name = this.Name,
                ResourceGroupName = this.ResourceGroupName,
                Location = this.Location,
                ApplicationRuleCollections = this.ApplicationRuleCollection?.ToList(),
                NatRuleCollections = this.NatRuleCollection?.ToList(),
                NetworkRuleCollections = this.NetworkRuleCollection?.ToList(),
                ThreatIntelMode = this.ThreatIntelMode ?? MNM.AzureFirewallThreatIntelMode.Alert
            };

            if (this.Zone != null)
            {
                firewall.Zones = this.Zone?.ToList();
            }

            // Map to the sdk object
            var azureFirewallModel = NetworkResourceManagerProfile.Mapper.Map<MNM.AzureFirewall>(firewall);
            azureFirewallModel.Tags = TagsConversionHelper.CreateTagDictionary(this.Tag, validate: true);

            // Execute the Create AzureFirewall call
            this.AzureFirewallClient.CreateOrUpdate(this.ResourceGroupName, this.Name, azureFirewallModel);
            return this.GetAzureFirewall(this.ResourceGroupName, this.Name);
        }
    }
}
