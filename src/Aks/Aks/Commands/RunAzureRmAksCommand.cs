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
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Management.Automation;
using Microsoft.Azure.Commands.Aks.Models;
using Microsoft.Azure.Commands.Common.Authentication;
using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.ContainerService;
using Microsoft.Azure.Management.ContainerService.Models;
using Microsoft.Azure.Management.Internal.Resources.Utilities.Models;
using Microsoft.WindowsAzure.Commands.Utilities.Common;

namespace Microsoft.Azure.Commands.Aks
{
    [Cmdlet("Invoke", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "AksRunCommand", SupportsShouldProcess = true, DefaultParameterSetName = GroupNameParameterSet)]
    [OutputType(typeof(PSRunCommandResult))]
    public class RunAzureRmAksCommand : KubeCmdletBase
    {
        private const string IdParameterSet = "IdParameterSet";
        private const string GroupNameParameterSet = "GroupNameParameterSet";
        private const string InputObjectParameterSet = "InputObjectParameterSet";
        private const string AksServiceId = "6dae42f8-4368-4678-94ff-3960e28e3630";

        [Parameter(Mandatory = true,
            ParameterSetName = InputObjectParameterSet,
            ValueFromPipeline = true,
            HelpMessage = "A PSKubernetesCluster object, normally passed through the pipeline.")]
        [ValidateNotNullOrEmpty]
        public PSKubernetesCluster InputObject { get; set; }

        /// <summary>
        /// Cluster name
        /// </summary>
        [Parameter(Mandatory = true,
            ParameterSetName = IdParameterSet,
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Id of a managed Kubernetes cluster")]
        [ValidateNotNullOrEmpty]
        [Alias("ResourceId")]
        public string Id { get; set; }

        /// <summary>
        /// Resource group name
        /// </summary>
        [Parameter(
            Position = 0,
            Mandatory = true,
            ParameterSetName = GroupNameParameterSet,
            HelpMessage = "Resource group name")]
        [ResourceGroupCompleter()]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// Cluster name
        /// </summary>
        [Parameter(
            Mandatory = true,
            Position = 1,
            ParameterSetName = GroupNameParameterSet,
            HelpMessage = "Name of your managed Kubernetes cluster")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [Parameter(Mandatory = true, HelpMessage = "Gets or sets the command to run.")]
        [ValidateNotNullOrEmpty]
        public string CommandString { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Gets or sets a base64 encoded zip file containing the files required by the command.")]
        [ValidateNotNullOrEmpty]
        public string[] CommandFile { get; set; }

        [Parameter(Mandatory = false)]
        public SwitchParameter PassThru { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Run cmdlet in the background")]
        public SwitchParameter AsJob { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Remove managed Kubernetes cluster without prompt")]
        public SwitchParameter Force { get; set; }

        private string GetCommandContext()
        {
            if (CommandFile == null || CommandFile.Length == 0)
            {
                return "";
            }
            List<string> filesToAttach = new List<string>();
            string currentDirectory = SessionState.Path.CurrentFileSystemLocation.ToString();
            if (CommandFile.Length == 1 && CommandFile[0].Equals("."))
            {
                WriteDebug(string.Format("Will zip all the files under {0}.", currentDirectory));
                Directory.GetFiles(currentDirectory, "*", SearchOption.AllDirectories).ForEach(filepath =>
                {
                    filesToAttach.Add(filepath);
                });
            }
            else
            {
                foreach (var filepath in CommandFile)
                {
                    filesToAttach.Add(Path.Combine(currentDirectory, filepath));
                }
            }
            if (filesToAttach.Count == 0)
            {
                WriteDebug("There is no files to attach!");
                return "";
            }
            using (var memoryStream = new MemoryStream())
            {
                using (var archive = new ZipArchive(memoryStream, ZipArchiveMode.Create, true))
                {
                    foreach (string filepath in filesToAttach)
                    {
                        var relativePath = filepath.Replace(currentDirectory, "").Trim('/').Trim('\\');
                        var memoryZipFile = archive.CreateEntry(relativePath);
                        var fileContent = File.ReadAllText(filepath);
                        using (var entryStream = memoryZipFile.Open())
                        using (var streamWriter = new StreamWriter(entryStream))
                        {
                            streamWriter.Write(fileContent);
                        }
                    }
                }
                memoryStream.Flush();
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }

        private string GetClusterToken()
        {
            IAzureContext context = DefaultContext;
            IAccessToken accessToken = AzureSession.Instance.AuthenticationFactory.Authenticate(
                                context.Account,
                                context.Environment,
                                context.Tenant?.Id,
                                null,
                                ShowDialog.Never,
                                null,
                                null,
                                AksServiceId);
            return accessToken.AccessToken;
        }

        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();

            switch (ParameterSetName)
            {
                case IdParameterSet:
                    {
                        var resource = new ResourceIdentifier(Id);
                        ResourceGroupName = resource.ResourceGroupName;
                        Name = resource.ResourceName;
                        break;
                    }
                case InputObjectParameterSet:
                    {
                        var resource = new ResourceIdentifier(InputObject.Id);
                        ResourceGroupName = resource.ResourceGroupName;
                        Name = resource.ResourceName;
                        break;
                    }
            }

            RunCmdLet(() =>
            {
                ManagedCluster cluster = Client.ManagedClusters.Get(ResourceGroupName, Name);
                RunCommandRequest request = new RunCommandRequest
                {
                    Command = CommandString,
                    Context = GetCommandContext()
                };
                if (cluster.AadProfile != null && cluster.AadProfile.Managed != null)
                {
                    request.ClusterToken = GetClusterToken();
                }
                RunCommandResult response = Client.ManagedClusters.RunCommand(ResourceGroupName, Name, request);
                WriteObject(PSMapper.Instance.Map<PSRunCommandResult>(response));
            });
        }
    }
}
